( Additional attributes and properties )
PROPERTIES: .north .south .east .west .up .down
PROPERTIES: .northeast .northwest .southwest .southeast
ATTRIBUTES: .holdable .described
ATTRIBUTES: .open .locked

( Words common to many games )
game-words set-current
  NOUNS: north south east west up down
  NOUNS: northwest northeast southwest southeast
  NOUNS: n s e w nw ne sw se u d
  NOUNS: all
  VERBS: inventory i get drop look search examine eat drink go push pull
  FILLERS: a an the at
  : quit   cr bye ;
only forth definitions

variable the-player   : ego the-player @ ;
: room ( -- o ) ego .parent @ ;

( Handling of holdable objects )
: list-item ( o -- ) 4 spaces .short-name @ cc>s type cr ;
: list-if-holdable ( o -- ) dup .holdable get if list-item else drop then ;
: list-contents ( o -- ) ['] list-if-holdable iterate ;
: tally-holdable ( n o -- n ) .holdable get if 1 + then ;
: count-holdables ( o -- n ) 0 swap ['] tally-holdable iterate ;

( Find object in object by name )
: match-called ( f obj -- f ) object= or ;
: is-called? ( o -- f ) 0 over ['] match-called iterate-called ;
: find-called ( pick o -- pick ) is-called? if nip else drop then ;
: find-object ( parent -- o ) 0 swap ['] find-called iterate ;

( Find object in inventory or room )
: my-object ( -- o ) ego find-object ;
: the-object ( -- o ) my-object dup 0= if drop room find-object then ;
: held? ( o -- f) ego contains? ;
: in-room? ( o -- f) room contains? ;

( Shortcuts )
: is-go? ( -- f ) q" go" verb=  q" " verb= or ;
: is-examine? ( -- f) q" examine" verb=
                      q" search" verb= or
                      q" look" verb= or ;

( Describe each room on first entry )
: describe-contents
   room count-holdables if
     ." You see:" cr
     ego .parent @ list-contents cr
   then ;
: short-describe    bold room .short-name @ cwrap normal ;
: long-describe    room .description @ cwrap
                   room .described set ;
: describe    short-describe long-describe describe-contents ;
: ?describe   room .described get
              if short-describe describe-contents else describe then ;

: drop-all-one ( o -- )
   dup .holdable get if room into else drop then ;
: drop-all ego ['] drop-all-one iterate ;

: get-all-one ( o -- )
   dup .holdable get if ego into else drop then ;
: get-all room ['] get-all-one iterate ;

create direction-table
q" n" ,   q" north" ,      ' .north ,
q" s" ,   q" south" ,      ' .south ,
q" e" ,   q" east" ,       ' .east ,
q" w" ,   q" west" ,       ' .west ,
q" nw" ,  q" northwest" ,  ' .northwest ,
q" ne" ,  q" northeast" ,  ' .northeast ,
q" sw" ,  q" southwest" ,  ' .southwest ,
q" se" ,  q" southeast" ,  ' .southeast ,
q" u" ,   q" up" ,         ' .up ,
q" d" ,   q" down" ,       ' .down ,
10 constant direction-count
: direction ( n n -- ) swap 3 * + cells direction-table + @ ;
: short-direction 0 direction ;
: long-direction 1 direction ;
: in-direction 2 direction execute @ ;

( Connect rooms )
: connect-we ( a b -- ) 2dup .west ! swap .east ! ;
: connect-ns ( a b -- ) 2dup .north ! swap .south ! ;
: connect-nwse ( a b -- ) 2dup .northwest ! swap .southeast ! ;
: connect-nesw ( a b -- ) 2dup .northeast ! swap .southwest ! ;
: connect-ud ( a b -- ) 2dup .up ! swap .down ! ;

( Build up a map )
variable map-width  variable map-height
variable map-start  variable map-outside
: map-init   0 map-width !  0 map-height !  here map-start ! ;
: map-inside: 0 map-outside !  map-init ;
: map-outside: -1 map-outside !  map-init ;
: |m   depth map-width !  1 map-height +!
       depth 0 do , loop ;
: map-x-inside? ( x -- f ) dup 0>= swap map-width @ < and ;
: map-y-inside? ( y -- f ) dup 0>= swap map-height @ < and ;
: map-inside? ( x y -- f ) map-y-inside? swap map-x-inside? and ;
: map-at ( x y -- a ) 2dup map-inside? 0= if 2drop 0 exit then
                      map-width @ * map-width @ 1- rot - +
                      cells map-start @ + @ ;
: validpair ( a b xt -- )
   -rot 2dup 0<> swap 0<> and if rot execute else 2drop drop then ;
: ;map map-height @ 0 do map-width @ 0 do
     i j map-at  i 1+ j    map-at  ['] connect-we validpair
     i j map-at  i j 1+    map-at  ['] connect-ns validpair
     map-outside @ if
       i j map-at  i 1+ j 1+ map-at  ['] connect-nwse validpair
       i j map-at  i 1- j 1+ map-at  ['] connect-nesw validpair
     then
   loop loop ;

: generic-handling
  depth 1 <> if abort" stack leak" then
  -1

  direction-count 0 do
    i short-direction object=
    i long-direction object= or  is-go? and if
      room i in-direction
      dup if
        ego swap into ?describe
      else
        drop
        say: No path in that direction.
      then
      unloop exit
    then
  loop

  q" drop all" phrase= if
    drop-all say: Done.
    exit
  then

  q" get all" phrase= if
    get-all say: Done.
    exit
  then

  q" look" phrase= if describe exit then

  q" inventory" phrase=
  q" i" phrase= or if
    ego empty? if
      say: You have nothing.
    else
      say: You have:
      ego list-contents
    then
    exit
  then

  is-examine? if
    the-object if
      the-object .description @ cwrap
    else
      say: I don't see that here.
    then
    exit
  then

  q" get" verb= if
    room find-object
    dup if
      dup .holdable get if
        ego into
        say: Taken.
      else
        drop
        say: That certainly won't fit in your pocket.
      then
    else
      drop
      say: I don't see that here.
    then
    exit
  then

  q" drop" verb= if
    my-object
    dup if
      room into
      say: Dropped.
    else
      drop
      say: I don't have that.
    then
    exit
  then

  drop 0
;

