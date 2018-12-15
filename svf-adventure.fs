#! /usr/bin/env gforth

s" engine.fs" included
s" generic.fs" included

( Define game words )
game-words set-current
  VERBS: use
  NOUNS: self myself
  NOUNS: man tech body lab lab-tech
  NOUNS: laptop computer n95 mask poster console orange button airlock posters
only forth definitions

ATTRIBUTES: .open .locked

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
DESCRIPTION: This garden supplies the company cafeteria with a bountiful supply of locally grown organic produce. A steel door lies to the west, a dim corridor to the east. A lab-tech is laying face down on the floor.

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

ROOM: R01   Lobby
DESCRIPTION: Say something.

ROOM: R02   Placeholder Room
DESCRIPTION: Say something.

ROOM: R03   Placeholder Room
DESCRIPTION: Say something.

ROOM: R04   Open Office Floorplan
DESCRIPTION: You are in a twisty sea of cubicals, all alike. The cubes continue to the south and east. To the north, past fire doors, lies an exit.

ROOM: R05   Open Office Floorplan
DESCRIPTION: You are in a twisty sea of cubicals, all alike. Personal space, being in conflict with rapid fire collaboration has come decidedly second. The cubes continue to the south and west.

ROOM: R06   Open Office Floorplan
DESCRIPTION: You are in a twisty sea of cubicals, all alike. Keen instincts inherited from your savannah dwelling ancestors allow you to use distant landmarks (posters and hand sanitizer dispensers) to orient yourself. The cubes continue to the north and east. To the west, a small passage leads away from the monotony.

ROOM: R07   Placeholder Room
DESCRIPTION: Say something.

ROOM: R08   A T-shaped Hallway
DESCRIPTION: You are inside a T-shaped hallway. The top of the T contains a padded panel filled with posters held in place by pushpins.

ENTITY: posters   various posters pinned to the wall
CALLED: posters
DESCRIPTION: Several dozen posters promote various company events, describe company policies on bribery and gift giving. (To be clear the company seems to be opposed to both.) Other posters encourage mindfulness. One ominously asks, "Is this good for the company?"
posters R08 into

ROOM: ALK   Airlock
DESCRIPTION: A ten foot radius circular airlock connects the west to the east. A large console sits in the middle of the airlock. A thin layer of dust on either side of the airlock undermines any presense it actually keeps out particulate matter.
hydroponics ALK connect-we

ENTITY: airlock   airlock
CALLED: airlock
DESCRIPTION: The large pair of motorized doors, collection of high speed vents, and lots of glass make for an airlock straight out of a cheap 1960s Sci-Fi episode.
airlock ALK into

ENTITY: airlock-console   airlock control console
CALLED: console
DESCRIPTION: This control console operates the airlock. Prominently placed in the middle of the console is a bright orange button.
airlock-console ALK into

ENTITY: airlock-toggle   airlock toggle button
CALLED: button
CALLED: orange button
DESCRIPTION: The bright orange button the middle of the console calls to you. What ever could it do?
airlock-toggle ALK into

ROOM: R10   Placeholder Room
DESCRIPTION: Say something.

ROOM: R11   Open Office Floorplan
DESCRIPTION: You are in a twisty sea of cubicals, all alike. The simple invention of the noise cancelling headphones has changed so much for modern man. The cubes continue to the north and west. To the east lies a hallway.

ROOM: R12   Copier Room
DESCRIPTION: A combined copied, printer, scanner occupies one side of the small room. On the other, a tall black cabinet. Company policy dictacts no employee shall have to walk more than 500 feet to reach a photocopier or printer.

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
ALK R08  0   0  R13  0  |m
 0  R10  0   0   0   0  |m
;map

0 ALK .east !  ( airlock starts out to the west )

ROOM: shed   Inside Shed
DESCRIPTION: The shed is illuminated by a single dim lightbulb. A small hatch in the floor leads into darkness. A metal ladder, fused with the concrete is visible.

safe-room hydroponics connect-we
R10 shed connect-ud

player safe-room into

: handle-input
  ALK room = if
    q" push" verb= if
      the-object airlock-console = if
        say: You lean on the console, it creaks but does not budge.
        exit
      then
      the-object airlock-toggle = if
        say: You push the button. It sets in motion a clamouring sucking sound.
        airlock-console .open get if
          airlock-console .open clear
          say: The airlock now opens to the west.
          hydroponics ALK .west !
          0 ALK .east !
        else
          airlock-console .open set
          say: The airlock now opens to the east.
          0 ALK .west !
          R08 ALK .east !
        then
        exit
      then
    then
    is-examine? if
      the-object airlock = if
        airlock-console .open get if
          say: The airlock giant airlock surounds you. It currently opens to the east.
        else
          say: The airlock giant airlock surounds you. It currently opens to the west.
        then
        exit
      then
    then
  then

  generic-handling if exit then

  q" use" if
    the-object laptop = if
      say: You'd rather not. That's what got you into this mess in the first place.
      exit
    then
    the-object lab-tech = over player = or if
      say: For what?!
      exit
    then
    the-object n95-mask = if
      say: You breath through the mask. It is exceedingly tight, so you take it off.
      exit
    then
    the-object 0= if
      say: Use what for what again?
      exit
    then
  then

  say: Sadly, I've got no idea what you mean.
;

: run
  page
  bold: A Silicon Valley Forth Adventure
  say: An explosion rocks the building. This reinforces what you had always suspected, joining this startup was a poor career choice.
  describe
  say: What's your next move?
  ['] handle-input play-game
;
run

