#! /usr/bin/env gforth

s" engine.fs" included
s" generic.fs" included

( Define game words )
game-words set-current
  VERBS: use
  NOUNS: self myself
  NOUNS: man tech body lab lab-tech
  NOUNS: laptop computer n95 mask poster
only forth definitions


ENTITY: player   Me myself and I
CALLED: self
CALLED: myself
DESCRIPTION: A 21st century Morlock, your pallid pallor reflects a life spent in under the glare of artificial lighting.
player the-player !


ROOM: safe-room    Safe Room
DESCRIPTION: A nearly impenetrable safe-room, complete with panic button, bullet proof glass, and a mini-bar. Built in the event dissatisfied customers, investors, or concerned members of the general public decide to take a hands on approach to the company.  A solid steel door lies to the east.

PROP: n95-mask   an N95 mask
CALLED: mask
CALLED: n95
CALLED: n95 mask
it .holdable set
DESCRIPTION: At 60 cents a pop, these N95 personal respiratory masks give you a sense of invincibility in facing a chaotic and toxic particulate filled world.
n95-mask safe-room into


PROP: laptop   a laptop
CALLED: laptop
CALLED: computer
it .holdable set
DESCRIPTION: Having been designed with heat-sinks in place of a proper fan, this late model laptop struggles to run Windows.
laptop safe-room into

ROOM: hydroponics   Hydroponic Garden
DESCRIPTION: This garden supplies the company cafeteria with a bountiful supply of locally grown organic produce. A steel door lies to the west. A lab-tech is laying face down on the floor.

PROP: poster   a motivatational poster
CALLED: poster
it .holdable set
DESCRIPTION: Much like a Soviet era poster, this slice of internal company propaganda encourages the "workers" to give their all to the cause.
poster hydroponics into

ENTITY: lab-tech   a lab technician
CALLED: man
CALLED: tech
CALLED: lab tech
CALLED: lab-tech
CALLED: body
DESCRIPTION: The lab tech has a hideous grin on his face, and seems to be most thoroughly dead.
lab-tech hydroponics into


ROOM: B01   Fence
DESCRIPTION: A large fence blocks your path to the north and west. An occasional sign on its surface indicates danger. Is the danger inside or outside?

ROOM: B02   Fence
DESCRIPTION: A large fence blocks your path to the north. An occasional sign on its surface indicates danger. Is the danger inside or outside?

ROOM: B03   Fence
DESCRIPTION: A large fence blocks your path to the north. An occasional sign on its surface indicates danger. Is the danger inside or outside?

ROOM: B04   Fence
DESCRIPTION: A large fence blocks your path to the north. An occasional sign on its surface indicates danger. Is the danger inside or outside?

ROOM: B05   Fence
DESCRIPTION: A large fence blocks your path to the north. An occasional sign on its surface indicates danger. Is the danger inside or outside?

ROOM: B06   Fence
DESCRIPTION: A large fence blocks your path to the north and east. An occasional sign on its surface indicates danger. Is the danger inside or outside?

ROOM: B07   Fence
DESCRIPTION: A large fence blocks your path to the west. An occasional sign on its surface indicates danger. Is the danger inside or outside?

ROOM: B08   Fence
DESCRIPTION: A large fence blocks your path to the east and south. An occasional sign on its surface indicates danger. Is the danger inside or outside?

ROOM: B09   Fence
DESCRIPTION: A large fence blocks your path to the west. An occasional sign on its surface indicates danger. Is the danger inside or outside?

ROOM: B10   Fence
DESCRIPTION: A large fence blocks your path to the east. An occasional sign on its surface indicates danger. Is the danger inside or outside?

ROOM: B11   Fence
DESCRIPTION: A large fence blocks your path to the west. An occasional sign on its surface indicates danger. Is the danger inside or outside?

ROOM: B12   Fence
DESCRIPTION: A large fence blocks your path to the north and east. An occasional sign on its surface indicates danger. Is the danger inside or outside?

ROOM: B13   Fence
DESCRIPTION: A large fence blocks your path to the west. An occasional sign on its surface indicates danger. Is the danger inside or outside?

ROOM: B14   Fence
DESCRIPTION: A large fence blocks your path to the east and south. An occasional sign on its surface indicates danger. Is the danger inside or outside?

ROOM: B15   Fence
DESCRIPTION: A large fence blocks your path to the south and west. An occasional sign on its surface indicates danger. Is the danger inside or outside?

ROOM: B16   Fence
DESCRIPTION: A large fence blocks your path to the south. An occasional sign on its surface indicates danger. Is the danger inside or outside?

ROOM: B17   Fence
DESCRIPTION: A large fence blocks your path to the south. An occasional sign on its surface indicates danger. Is the danger inside or outside?

ROOM: B18   Fence
DESCRIPTION: A large fence blocks your path to the south and east. An occasional sign on its surface indicates danger. Is the danger inside or outside?

ROOM: B19   Fence
DESCRIPTION: A large fence blocks your path to the south, east, and west. An occasional sign on its surface indicates danger. Is the danger inside or outside?

ROOM: F01   Forest
DESCRIPTION: A thick forest surrounds you. Large ancient pine trees obscure much of the sun. Calls of birds sound occassionally in all directions.

ROOM: F02   Forest
DESCRIPTION: A thick forest surrounds you. Large ancient pine trees obscure much of the sun. Calls of birds sound occassionally in all directions.

ROOM: F03   Forest
DESCRIPTION: A thick forest surrounds you. Large ancient pine trees obscure much of the sun. Calls of birds sound occassionally in all directions.

ROOM: F04   Forest
DESCRIPTION: A thick forest surrounds you. Large ancient pine trees obscure much of the sun. Calls of birds sound occassionally in all directions.

ROOM: F05   Forest
DESCRIPTION: A thick forest surrounds you. Large ancient pine trees obscure much of the sun. Calls of birds sound occassionally in all directions.

ROOM: F06   Forest
DESCRIPTION: A thick forest surrounds you. Large ancient pine trees obscure much of the sun. Calls of birds sound occassionally in all directions.

ROOM: F07   Forest
DESCRIPTION: A thick forest surrounds you. Large ancient pine trees obscure much of the sun. Calls of birds sound occassionally in all directions.

ROOM: F08   Forest
DESCRIPTION: A thick forest surrounds you. Large ancient pine trees obscure much of the sun. Calls of birds sound occassionally in all directions.

ROOM: F09   Forest
DESCRIPTION: A thick forest surrounds you. Large ancient pine trees obscure much of the sun. Calls of birds sound occassionally in all directions.

ROOM: F10   Forest
DESCRIPTION: A thick forest surrounds you. Large ancient pine trees obscure much of the sun. Calls of birds sound occassionally in all directions.

ROOM: F11   Forest
DESCRIPTION: A thick forest surrounds you. Large ancient pine trees obscure much of the sun. Calls of birds sound occassionally in all directions.

ROOM: F12   Forest
DESCRIPTION: A thick forest surrounds you. Large ancient pine trees obscure much of the sun. Calls of birds sound occassionally in all directions.

ROOM: F13   Forest
DESCRIPTION: A thick forest surrounds you. Large ancient pine trees obscure much of the sun. Calls of birds sound occassionally in all directions.

ROOM: HOU   
DESCRIPTION: A concrete shed sits curiously in the midst of a dense forest. Its single metal door is painted a bland blue.

ROOM: F15   Forest
DESCRIPTION: A thick forest surrounds you. Large ancient pine trees obscure much of the sun. Calls of birds sound occassionally in all directions.

ROOM: F16   Forest
DESCRIPTION: A thick forest surrounds you. Large ancient pine trees obscure much of the sun. Calls of birds sound occassionally in all directions.

map-outside:
B01 B02 B03 B04 B05 B06 |m
B07 F01 F02 F03 F04 B08 |m
B09 F05 F06 F07 B10  0  |m
B11 F08 F09 F10 F11 B12 |m
B13 F12 F13 HOU F15 B14 |m
B15 F16 B16 B17 B18  0  |m
 0  B19  0   0   0   0  |m
;map

ROOM: R01   Placeholder Room
DESCRIPTION: Say something.

ROOM: R02   Placeholder Room
DESCRIPTION: Say something.

ROOM: R03   Placeholder Room
DESCRIPTION: Say something.

ROOM: R04   Placeholder Room
DESCRIPTION: Say something.

ROOM: R05   Placeholder Room
DESCRIPTION: Say something.

ROOM: R06   Placeholder Room
DESCRIPTION: Say something.

ROOM: R07   Placeholder Room
DESCRIPTION: Say something.

ROOM: R08   Placeholder Room
DESCRIPTION: Say something.

ROOM: R09   Placeholder Room
DESCRIPTION: Say something.

ROOM: R10   Placeholder Room
DESCRIPTION: Say something.

ROOM: R11   Placeholder Room
DESCRIPTION: Say something.

ROOM: R12   Placeholder Room
DESCRIPTION: Say something.

ROOM: R13   Placeholder Room
DESCRIPTION: Say something.

ROOM: R14   Placeholder Room
DESCRIPTION: Say something.

ROOM: R15   Placeholder Room
DESCRIPTION: Say something.

ROOM: R16   Placeholder Room
DESCRIPTION: Say something.

ROOM: R17   Placeholder Room
DESCRIPTION: Say something.

map-inside:
 0  R01  0   0   0  R17 |m
 0  R02 R03  0   0  R16 |m
 0   0  R04 R05  0  R15 |m
 0  R07 R06 R11 R12 R14 |m
R09 R08  0   0  R13  0  |m
 0  R10  0   0   0   0  |m
;map

ROOM: shed   Inside Shed
DESCRIPTION: The shed is illuminated by a single dim lightbulb. A small hatch in the floor leads into darkness. A metal ladder, fused with the concrete is visible.

safe-room hydroponics connect-we
R10 shed connect-ud

player safe-room into

: handle-input
  generic-handling if exit then

  q" use" if
    player find-object
    dup 0= if
      drop room find-object
    then
    dup laptop = if
      say: You'd rather not. That's what got you into this mess in the first place.
      drop exit
    then
    dup lab-tech = over player = or if
      say: For what?!
      drop exit
    then
    dup n95-mask = if
      say: You breath through the mask. It is exceedingly tight, so you take it off.
      drop exit
    then
    dup 0= if
      say: Use what for what again?
      drop exit
    then
    drop
  then

  say: Sadly, I've got no idea what you mean.
;

: run
  page
  say: As the explosion rocks the building it reinforces what you had always suspected, joining this startup was a poor career choice.
  describe
  say: What's your next move?
  ['] handle-input play-game
;
run

