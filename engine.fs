( Forth Interactive Fiction Engine )
( ---------------------------------)

( Manipulate the rest of the current line )
: trailing? ( -- f) source nip >in @ - ;
: trailing ( -- a n ) source >in @ - swap >in @ + swap ;
: space? ( -- f ) source drop >in @ + c@ bl = ;
: skip-space   begin trailing? space? and while 1 >in +! repeat ;
: skip-trailing   source nip >in ! ;
: eat-trailing   skip-space trailing skip-trailing ;
: trailing,   eat-trailing dup , dup >r here swap cmove r> allot ;
: while-trailing ( xt -- )
   begin trailing? while dup execute repeat drop ;

( General Utilities )
: cc>s ( ccs -- a n ) dup cell+ swap @ ;
: @++ ( a -- n ) dup @ swap 1 swap +! ;
: and! ( n a -- ) swap over @ and swap ! ;
: or! ( n a -- ) swap over @ or swap ! ;

( Vocabulary for game words )
wordlist constant game-words
: use-game-words   game-words 1 set-order ;

( Handle parts of a phrase )
variable cmd   variable obj   variable failed
variable uid   2 uid !
: noun create uid @++ , does> @ obj @ 8 lshift + obj ! ;
: NOUNS: ['] noun while-trailing ;
: verb create uid @++ , does> @ cmd @ 8 lshift + cmd ! ;
: VERBS: ['] verb while-trailing ;
: filler create does> drop ;
: FILLERS: ['] filler while-trailing ;

( Update/get state of current phrase )
: reset-phrase   0 cmd !  0 obj !  0 failed ! ;
: bad-word   1 obj !  1 failed ! ;
: phrase   obj @ 8 lshift cmd @ + ;
: phrase=   phrase = ;
: verb=   phrase 255 and = ;
: object=   phrase 255 invert and = ;

( Parse current phrase )
: eat-word   bl word find if execute else drop bad-word then ;
: eat-line   ['] eat-word while-trailing ;
: eat-phrase   reset-phrase use-game-words eat-line only forth ;

( Main input and game loop )
: prompt-line ( xt -- ) ." > " query eat-phrase cr cr execute ;
: play-game ( xt -- ) begin dup prompt-line again ;

( Parse canned phrase )
: q"   reset-phrase use-game-words
       [char] " parse state @ if postpone [ evaluate ] else evaluate then
       only forth phrase state @ if postpone literal then ; immediate

( Print with word wrap )
: last-ch ( a n -- ch ) dup 0= if 2drop bl else + 1- c@ then ;
: bl-trim ( a n -- a n ) begin 2dup last-ch bl <> while 1- repeat ;
: wrap-point ( a n -- n )
   dup cols < if nip else drop cols 1- bl-trim nip then ;
: wrap-one ( a n -- a n )
   2dup wrap-point swap >r over >r dup >r type cr
   r> r> over + swap r> swap - ;
: wrap ( a n -- ) begin dup 0<> while wrap-one repeat 2drop cr ;
: cwrap ( ccs -- ) cc>s wrap ;
: say:   eat-trailing postpone sliteral postpone wrap ; immediate

( Game object properties )
variable property-count
: property create property-count @++ , does> @ cells + ;
: PROPERTIES: ['] property while-trailing ;
( Built-in properties )
PROPERTIES: .parent .children .sibling
PROPERTIES: .short-name .description .attributes .called

( Game object attributes )
variable attribute-count
: attribute create attribute-count @++ 1 swap lshift , does> @ ;
: ATTRIBUTES: ['] attribute while-trailing ;
: set ( a attr -- ) swap .attributes or! ;
: clear ( a attr -- ) invert swap .attributes and! ;
: get ( a attr -- f ) swap .attributes @ and 0<> ;
( Built-in attributes )
ATTRIBUTES: .room .entity .prop

( List handling )
: remove' ( o -- )
   dup .parent @ .children begin dup @ while
     2dup @ = if dup @ .sibling @ swap ! drop exit then
     @ .sibling
   repeat 2drop ;
: insert' ( o p -- )
   2dup   swap .parent !
   dup .children @ >r over r> swap .sibling !  .children ! ;
: into ( o p -- ) over remove' insert' ;
: contains ( o p -- f ) swap .parent = ;

: iterate ( o xt -- )
   swap .children begin dup @ while
     2dup dup @ >r >r >r @ swap execute r> r> r>
     over @ = if @ .sibling then
   repeat 2drop ;

: empty? ( o -- f ) .children @ 0= ;

( Walked called items )
: iterate-called ( o xt -- )
  swap .called @ begin dup while
    2dup >r >r cell+ @ swap execute r> r>
  @ repeat 2drop ;

( Create game objects )
variable current-object   : it ( -- o ) current-object @ ;
: object-size ( -- n ) property-count @ cells ;
: raw-object   create here current-object !
               here object-size 0 fill   object-size allot ;
raw-object nowhere
: object   raw-object it nowhere insert' ;
: named-object   object here trailing, it .short-name ! ;
: ROOM:   named-object it .room set ;
: PROP:   named-object it .prop set ;
: ENTITY:   named-object it .entity set ;
: DESCRIPTION:   here trailing, it .description ! ;
: CALLED:   eat-phrase here it .called @ , phrase , it .called !
            failed @ throw ;

