#! /usr/bin/env gforth

s" engine.fs" included
s" generic.fs" included

( Define game words )
game-words set-current
  VERBS: use
  NOUNS: self myself
  NOUNS: man tech body lab lab-tech
  NOUNS: laptop computer n95 mask poster console orange button airlock posters
  NOUNS: fire extinguisher
  NOUNS: house shed concrete blue door
  NOUNS: minibar mini-bar panic nickle coin microphone
  NOUNS: usb lamp "lamp" ramen pack toy unicorn roy bevins
only forth definitions

ATTRIBUTES: .open .locked

PLAYER: player   Me myself and I
CALLED: self
CALLED: myself
DESCRIPTION: A 21st century Morlock, your pallid pallor reflects a life spent in under the glare of artificial lighting.
player the-player !


ROOM: SafeR    Safe Room
DESCRIPTION: A nearly impenetrable safe-room, complete with panic button, bullet proof glass, and a mini-bar. Built in the event dissatisfied customers, investors, or concerned members of the general public decide to take a hands on approach to the company. A solid steel door lies to the west.

PROP: n95-mask   an N95 mask
CALLED: mask
CALLED: n95
CALLED: n95 mask
DESCRIPTION: At 60 cents a pop, these N95 personal respiratory masks give you a sense of invincibility in the face of a chaotic and toxic particulate filled world.
n95-mask SafeR into

PROP: laptop   a laptop
CALLED: laptop
CALLED: computer
DESCRIPTION: Having been designed with heat-sinks in place of a proper fan, this late model laptop struggles to run Windows.
laptop SafeR into

ENTITY: roy Roy Bevins
CALLED: roy
CALLED: bevins
CALLED: roy bevins
CALLED: man
DESCRIPTION: Roy is approximately 40 years old, wearing a yellow company T-Shirt and jeans. His glasses are dramatically thicker over his left eye than the right. Roy had always told you bad things would happen, and no doubt underneath his look of abject terror, he must be gloating.
roy SafeR into

SCENERY: mini-bar   the minibar
CALLED: minibar
CALLED: mini-bar
DESCRIPTION: A collection of various single malt whiskeys, sundry bitters, a few cans of tonic water. Cocktail shakers and glasses sit to one side.
mini-bar SafeR into

SCENERY: panic-button   the panic button
CALLED: panic button
CALLED: button
DESCRIPTION: A bright red button is intended to close steel door and summon the authorities in the event love fails to triumph.
panic-button SafeR into

ROOM: Hydro   Hydroponic Garden
DESCRIPTION: This garden supplies the company cafeteria with a bountiful supply of locally grown organic produce. A steel door lies to the west, a dim corridor to the east. A lab-tech is laying face down on the floor.

ROOM: Lunch   Company Cafeteria
DESCRIPTION: In order to compete in attracting top talent, the company provides free meals to its employees for breakfast, lunch, and dinner.

PROP: poster   a motivatational poster
CALLED: poster
DESCRIPTION: Much like a Soviet era poster, this slice of internal company propaganda encourages the "workers" to give their all to the cause.
poster Hydro into

ENTITY: lab-tech   a lab technician
CALLED: man
CALLED: tech
CALLED: lab tech
CALLED: lab-tech
CALLED: body
DESCRIPTION: The lab tech has a hideous grin on his face, and seems to be most thoroughly dead. It's not readily apparent what caused his death.
lab-tech Hydro into


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

ROOM: CLR   Clearing
DESCRIPTION: The forest thins here, allowing you to see a patch of the yellow hazed smog of the late summer sky.

PROP: nickle    a nickle
CALLED: nickle
CALLED: coin
DESCRIPTION: Apparently it's your last five cents. The greasy coin glints slightly in the light.
nickle CLR into

ROOM: F13   Forest
DESCRIPTION: A thick forest surrounds you. Large ancient pine trees obscure much of the sun. Calls of birds sound occassionally in all directions.

ROOM: HOU   Outside Shed
DESCRIPTION: A concrete shed sits curiously in the midst of a dense forest. Its single metal door is painted a bland blue.

SCENERY: outside-shed   a concrete shed
CALLED: shed
CALLED: concrete shed
CALLED: house
DESCRIPTION: The shed consists of mostly concrete, with a lone metal door painted blue.
outside-shed HOU into

SCENERY: shed-door   door to shed
CALLED: blue door
CALLED: door
DESCRIPTION: The blue door to the shed hangs slightly open.

ROOM: F15   Forest
DESCRIPTION: A thick forest surrounds you. Large ancient pine trees obscure much of the sun. Calls of birds sound occassionally in all directions.

ROOM: F16   Forest
DESCRIPTION: A thick forest surrounds you. Large ancient pine trees obscure much of the sun. Calls of birds sound occassionally in all directions.

map-outside:
B01 B02 B03 B04 B05 B06 |m
B07 F01 F02 F03 F04 B08 |m
B09 F05 F06 F07 B10  0  |m
B11 F08 F09 F10 F11 B12 |m
B13 CLR F13 HOU F15 B14 |m
B15 F16 B16 B17 B18  0  |m
 0  B19  0   0   0   0  |m
;map

ROOM: Lobby   Lobby
DESCRIPTION: Say something.

ROOM: Troph   Trophy Room
DESCRIPTION: Two large glass display cases line the hallway containing awards presented to the company for innovation, disruption, and just plain being cool. In all probability, most are the result of being a "gold circle" sponser of various conferences. They transform the abstract path to a directorship into the mortal realm for all to see.

ROOM: Break   Break Room
DESCRIPTION: While many Bay Area companies are known for lavish in-house meals and snacks, the investors of this privately held company translated their investment in interior security (cameras) into a crisp justification for less being more, i.e. the employees clearly pocket the snacks. This being the weekend, cupboards are largely bare.

PROP: ramen   a pack of ramen
CALLED: ramen
CALLED: pack
DESCRIPTION: It's a package of chicken "flavored" ramen, the de-facto currency in the nation's prisons. Nearly as bad for you as a cigarette, it has displaced them as the coin of choice for felons everywhere.
ramen Break into

ROOM: Off04   Open Office Floorplan
DESCRIPTION: You are in a twisty sea of cubicals, all alike. The cubes continue to the south and east. To the north, past fire doors, lies an exit.

ROOM: Off05   Open Office Floorplan
DESCRIPTION: You are in a twisty sea of cubicals, all alike. Personal space, being in conflict with rapid fire collaboration has come decidedly second. The cubes continue to the south and west.

ROOM: Off06   Open Office Floorplan
DESCRIPTION: You are in a twisty sea of cubicals, all alike. Keen instincts inherited from your savannah dwelling ancestors allow you to use distant landmarks (posters and hand sanitizer dispensers) to orient yourself. The cubes continue to the north and east. To the west, a small passage leads away from the monotony.

ROOM: Lroom   L-shaped Hallway
DESCRIPTION: A bend in the hallway connects east to south. You really should have asked for hazard pay instead of what you assume are now worthless stock options.

ROOM: Troom   A T-shaped Hallway
DESCRIPTION: You are inside a T-shaped hallway. The top of the T contains a padded panel filled with posters held in place by pushpins.

SCENERY: posters   various posters pinned to the wall
CALLED: posters
DESCRIPTION: Several dozen posters promote various company events, describe company policies on bribery and gift giving. (To be clear the company seems to be opposed to both.) Other posters encourage mindfulness. One ominously asks, "Is this good for the company?"
posters Troom into

ROOM: ALock   Airlock
DESCRIPTION: A ten foot radius circular airlock connects the west to the east. A large console sits in the middle of the airlock. A thin layer of dust on either side of the airlock undermines any pretense it actually keeps out particulate matter.

SCENERY: airlock   airlock
CALLED: airlock
DESCRIPTION: A large pair of motorized doors, a collection of high speed vents, and lots of glass make for an airlock straight out of a cheap 1960s Sci-Fi episode.
airlock ALock into

SCENERY: airlock-console   airlock control console
CALLED: console
DESCRIPTION: This control console operates the airlock. Prominently placed in the middle of the console is a bright orange button.
airlock-console ALock into

SCENERY: airlock-toggle   airlock toggle button
CALLED: button
CALLED: orange button
DESCRIPTION: The bright orange button the middle of the console calls to you... What ever could it do?
airlock-toggle ALock into

ROOM: Laddr   Hallway Dead End
DESCRIPTION: At the end of the hallway, a red space for a fire extinguisher fills the right side of the wall. A metal ladder, painted white, leads up into the ceiling.

PROP: extinguisher   a fire extinguisher
CALLED: fire extinguisher
CALLED: extinguisher
DESCRIPTION: Dutifully marked with a regularly updated log, a lone fire extinguisher holds compliant vigil over a world filled with chaos. Its markings call forth a confident prayer to the gods, to the collective judgement of mankind, and to to OSHA, "I was checked regularly, and am therefore not financially liable."
extinguisher Laddr into

ROOM: Off11   Open Office Floorplan
DESCRIPTION: You are in a twisty sea of cubicals, all alike. The simple invention of the noise cancelling headphone has changed so much for modern man. The cubes continue to the north and west. To the east lies a hallway.

ROOM: CopyR   Copier Room
DESCRIPTION: A combined copied, printer, scanner occupies one side of the small room. On the other, a tall black cabinet. Company policy dictacts no employee shall have to walk more than 500 feet to reach a photocopier or printer.

ROOM: Machn   Machine Room
DESCRIPTION: Despite the general silence the pervades the building, this small collection of rack mounted computers continues to hum along till doomsday. Various red and green LEDs blink throughout. While the bulk of the company's computing resources are in the cloud, a small batch of local rackmounted systems are kept on site for particularly sensitive, or incriminating data.

PROP: lamp   a usb "lamp"
CALLED: usb lamp
CALLED: lamp
CALLED: usb "lamp"
DESCRIPTION: A cheap prize handed out at some event or other, branded with the company logo, this USB-A device powers a small LED lamp.
lamp Machn into

ROOM: Off14   Corner Office
DESCRIPTION: The proverbial corner office, the company's enigmatic founder shares this small space with the company's COO. One is known for wild ideas and behavior, the other as the cautious adult in the room. Doors lead west, east, and north, to provide multiple means of escape.

PROP: unicorn   a toy unicorn
CALLED: toy
CALLED: toy unicorn
CALLED: unicorn
DESCRIPTION: Talisman against quarterly losses, SEC investigations, and megalomaniacal self doubt the company founder no doubt holds this plastic toy dear.
unicorn Off14 into

ROOM: Ramp   Ramp
DESCRIPTION: The hallway slopes downward as the hallway runs south to north.

ROOM: Sound   Soundproof Room
DESCRIPTION: Ironically, this soundproof room is used by the company to simulate conditions in a noisy train station. Said simulation not being in progress, the dead silence gives you a feeling of unrelenting dread. You are eagerly drawn to the southern exit.

PROP: microphone   a professional microphone
CALLED: microphone
DESCRIPTION: A $10,000 professinal grade microphone, this device can hear the drop of a pin.
microphone Sound into

map-inside:
  0     0     0   Lobby   0     0     0     0     0   |m
  0     0     0   Troph Break   0     0   Sound   0   |m
  0     0     0     0   Off04 Off05   0   Ramp    0   |m
  0     0     0   Lroom Off06 Off11 CopyR Off14 SafeR |m
Lunch Hydro ALock Troom   0     0   Machn   0     0   |m
  0     0     0   Laddr   0     0     0     0     0   |m
;map


( airlock starts out to the east )
0 ALock .west !
airlock-console .open set

ROOM: shed   Inside Shed
DESCRIPTION: The shed is illuminated by a single dim lightbulb. A small hatch in the floor leads into darkness. A metal ladder, fused with the concrete is visible.

( Glue in the start rooms )
shed Laddr connect-ud

( Start in the safe room )
player SafeR into

: handle-input
  ALock room = if
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
          Hydro ALock .west !
          0 ALock .east !
        else
          airlock-console .open set
          say: The airlock now opens to the east.
          0 ALock .west !
          Troom ALock .east !
        then
        exit
      then
    then
    is-examine? if
      the-object airlock = if
        airlock-console .open get if
          say: The giant airlock surounds you. It currently opens to the east.
        else
          say: The giant airlock surounds you. It currently opens to the west.
        then
        exit
      then
    then
  then
  
  shed room = if
    q" exit" verb= if
      ego HOU into ?describe
      exit
    then
  then

  HOU room = if
    q" enter" verb= if
      the-object outside-shed = 
      the-object shed-door = or if
        ego shed into ?describe
        exit
      then
    then
  then

  generic-handling if exit then

  q" talk" verb= if
    the-object roy = if
      say: Roy says, "What the hell was that? I don't care. We're all gonna die, containment must have broke down."
      exit
    then
  then

  q" ask" verb= if
    the-object roy = if
      the-other unicorn = if
        say: Roy says, "Have you lost it? It's no time for toys. We have to think of something!"
        exit
      then
      the-other laptop = if
        say: Roy says, "Sure, whatever, take my laptop, I don't care anymore."
        exit
      then
      the-other n95-mask = if
        say: Roy says, "Hah, yeah right, that won't make any difference."
        exit
      then
      the-other 0 <> if
        say: Roy says, "Get that out of my face. I need to find my happy place."
        exit
      then
    then
  then

  q" use" verb= if
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

