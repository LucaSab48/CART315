# Process Journal



## Make a Thing |01.23.25
For this Make a Thing project, I decided to visualize a short story. I initially wanted to pick a short story from Junji-Ito, however I soon realized how difficult it would be to create it with the tools given. I really wanted to make a platformer game using GB studios, yet my computers anti-virus software would not allow me to open GB studios. So I settled on Bitsy as my choice of creation tools. I then decided to adapt one of my favorite HP Lovecraft stories, “The Outsider”. 
This is because of its platformer-esque nature and the fact that there is only one character in the whole story. The story is mainly about a man stuck in a large castle, wrestling with his own identity and existence. Once he finally escapes to the real world, he is faced with the fact that he is a monster and shunned by society.
I was only able to adapt the first half of the story unfortunately, due to time limit constraints. I decided to make a puzzle lock-and-key game where the user must find his way out of the castle to discover who they truly are. I tried making different objects from the story to convey the narrative, however the sprite editor tool in bitsy is very limited. So I adjusted it to be only a couple objects and a bunch of notes scattered across the map. 
I made the ending kind of hidden to extend the game time and play into the narrative of the creature (the player) hiding the exit to avoid his reality. The themes I explore are identity, isolation, and existentialism.

Playtest thoughts:
-	I made the game too annoying
-	I wish I spent more time making better looking sprites and more interesting backgrounds
-	People tend to skip the dialogue
-	Puzzle games are probably not the best games for a small demonstration
-	I think I made the game too long without having a strong enough narrative
-	People did not look for hidden walls without me indicating it to them 



## Exploration Prototype 1 | 01.30.25
For this exploration, I decided to continue the prototype we made in class. I added a boundary box on the bottom of the game to destroy any game objects that go off. I then added a score board in the top right corner of the screen using the legacy text UI feature. I used the boundary box to keep count of the score. I also changed the sprite of the square to a pop cat and changed the circle prefab to a croissant. 
I also made the croissants drop slightly faster as time went on by multiplying it with 0.98 very loop and making it have a max drop speed of 0.35. I bounded the pop cat so that it won't go off screen. I also added 3 UI images of the pop cat under the score to illustrate lives of the player. Every time a croissant hits the bound box, one of the images goes away. I intended for this to be the whole game loop, where after the lives of the player are all lost, it would change to the end scene and it'll display their score and have a restart button. 
Alas, I did not have the time to implement this. I wanted to add sound effects as well (like a crunching sound for when the pop cat eats a croissant) but this seemed rather difficult. I also wanted to explore the camera aspect of unity as well but this game didn't seem like the best prototype for this exploration. With a little more tweaking, this could be a semi-complete game. I'd love to add some background image and music.



## Pong After Hours | 02.06.25
In this exploration, I decided to play with lighting. I originally wanted to make the game more difficult while keeping its cooperative nature, but I could not think of anything. I was thinking of adding paddles on the top and bottom of the screen for a 4 player mode / making a difficult 2 player mode, but this seemed like an inefficient exploration.
Instead, I wanted to make the entire game scene dark and make the ball a source of light. This was easier said than done. I've never really experimented with the lighting in unity before this exploration. I had to learn what URP is and how to make it work as well as figuring out the correct settings for the shader materials.

What I did:
- Made the entire scene dark using global 2D light
- Made the pong ball a source of light using the circular freeform 2D light
- Added a second freeform 2D light to the ball, but used the volumetric aspect to make the ball have a glow
- Added a scoreboard for each player
- Put a game object line in the middle of the scene so it makes the balls movement clearer
- Added 2 end screens (one for left player, one for right player) with a restart button
- Made a title card for the game with a start and quit button

![alt text](https://github.com/LucaSab48/CART315/blob/main/ProcessJournal/Images/pawngTemplate-Main-WindowsMacLinux-Unity66000.0.34f1_DX11_2025-02-0614-32-23-ezgif.com-crop.gif) 

Future additions:
- A pause button to exit or restart the game
- A quit button on the end screens
- Fireworks for the end screen
- More game elements to increase difficulty or make the game more interesting (maybe powerups or additional balls!)

![alt text](https://github.com/LucaSab48/CART315/blob/main/ProcessJournal/Images/PongAfterHours.p2.gif) 



## BreakOut Test | 02.13.25
This week was an unproductive one for my exploration. I was out of ideas and kind of bummed that my pong game is gone. I knew I wanted to re-explore lighting in the game as a sort of revitalization of my pong after hours game, but was struggling to find any new addition that wasn't just repeating the exact same thing. 
So, I decided to repeat the exact same thing to see if it would generate any new ideas. It did not initially, so I decided to add a trail to the ball because Dorsa's pong game looked pretty cool with it. Then I got an idea to try and make the bricks light up when you hit them. I thought this would be interesting and also allow me to explore lighting for prefabs. 
I wanted to make it so the light would slowly dissipate as time went on, then allow my ball to relight it. I also wanted it to be destructable only if the light was lit. This was not easy to figure out. I had to turn to the dark side of coding (ChatGPT). But even it couldn't get it working the way I envisioned. 
It ended up pretty buggy with the bricks only lighting up once then getting destroyed even when unlit. I tried to fix this problem for a while but ran out of time. I did not even have the time to implement a title screen and an end screen.
What I did:
- Made the entire scene dark like last time
- Made teh ball glow like last time
- Added a trail to the ball to make it look cool
- Made the bricks light up then slowly fade if the ball hit it
- Made an end screen on photoshop

![alt text](https://github.com/LucaSab48/CART315/blob/main/ProcessJournal/Images/BreakOutGif.gif)

Future Additions:
- A fully implemented title card and end screen
- A working version of my idea
- A pause button and menu
- Funny sound effects (like Cartman from South Park saying "You're breaking my balls")
- Particle effects for when the bricks break
- Score and life count
- Powerups and maybe a timer?
- Better sprites and brick placement



## Blind Breaking | 02.20.25
For my exploration this week, I decided to work on my previous iteration of the breakOut game I did last week. I wanted to continue this project because I was unsatisfied with how the last exploration turned out. So, I tried to implement a few features I discussed about in my last entry.
I also fixed a bunch of the issues I was having last week, but ran into a few new ones along the way. This exploration has made me realize how making a game is something that doesn't have a definite conclusion. What I mean is that there is always something to add or something to fix. 
I know this isn't the most profound discovery, but I didn't really grasp the concept of compromising on my ideas until I was doing this exploration. While this isn't a super valuable lesson, it has provided me with the knowledge that its better to have several semi-working implementations than focusing all my time into fien tuning a few implementations. 
What I did:
- Fixed the issue of last week, so now the brick lights up then breaks
- Added a particle system so it seems like the bricks shatter into tiny pieces
- Adjusted the light around the bricks
- Added a title card
- Fully implemented the end card
- Added a pause screen (hit enter to activate it)
- Integrated sound effects for the ball
- Added a life counter

![alt text](https://github.com/LucaSab48/CART315/blob/main/ProcessJournal/Images/BlindBreakingGIF1.gif)
![alt text](https://github.com/LucaSab48/CART315/blob/main/ProcessJournal/Images/BlindBreakingGIF3.gif)

Future Additions:
- Fix the tail renderer issue when the ball resets
- Make the UI look better, especially the buttons
- Add a more diverse amount of sound effects
- More levels
- Powerups could be cool
- A winning screen with fireworks
- Something to keep score
- Maybe the bricks can have different effects for lighting?
- A countdown could be cool as well

![alt text](https://github.com/LucaSab48/CART315/blob/main/ProcessJournal/Images/BlindBreakingGIF2.gif)



## Game Analysis | Titan Souls | 03.06.25

Titan souls is a short boss rush style game that thrives in the simplicity of its mechanics. The game consists of some puzzle-based exploration to find new bosses to beat, leading to a two final big bosses. The reason I chose this game to highlight is because it does not rely on grandiose graphics or complex game mechanics, but only 1 type of attack and and a dodge button.
The player has only 1 life per boss. The attack mechanic is a bow and arrow that has only one arrow. The player can charge the arrow to shoot, then recall the arrow. Both the shot and teh recalled arrow do damage to enemies. The game essentially forces the player to "get good" with its one option for emitting damage. It approaches avoiding damage in a similar manner, with the dash being the sole option. 
![alt text](https://github.com/LucaSab48/CART315/blob/main/ProcessJournal/Images/titanSouls1.gif)

Another major mechanical triumph of Titan Souls is the unique mechanics for each boss in the game. This ranges from hazardous environmental attacks to hidden weak points. Lets examine one boss in particular. This being "The Soul" final boss in the game. There are various mechanics at play in this boss fight. Firstly, it is wearing a protective armour almost at all times which prevents it from taking any damage. 
Secondly, the boss is able to control a large portion of the map utilizing explosive balls of lighting. It also has a copy of your main attack ability. Finally, it has a dash that allows the boss to have great mobility. The trick to this boss fight is hidden within that dash mechanic. As the boss dashes, its body moves out of the invulnerable armor, allowing the player a split second to finish the fight. 
This boss took me the most attempts to figure out how to fight it and beat it.

![alt text](https://github.com/LucaSab48/CART315/blob/main/ProcessJournal/Images/titanSouls2.gif)



## Iterative Prototype 1 | Searching | 03.06.25
For the exploration this week, I mainly tried figuring out how to use the xbox 360 Kinect with Unity. Unfortunately, my efforts were unsuccessful. Turns out the Kinect V1 needs an external power supply to operate, which I don't have. However, I did find the software necessary for the integration. This being Kinect for Windows SDK. I also found a few tutorials on how to get it working in Unity as well. 
Even though I lack the necessary hardware to make the Kinect work with Unity, I do have hope for future iterations on this idea. I found out yesterday that the computation lab is equipped with a bunch of Kinect V2s, so I might go pay them a visit soon to try it out. The reason I am working on using the Kinect in Unity is for an installation idea I have. I want to use the Kinect as a messenger between performance and technology. 
I was thinking of using the Kinect to track the observers body position and depth so that their movements could change an environment I create in Unity. This would be perhaps an exhibition piece for the end of year show or part of my final project for my performance art class. 
![alt text](https://github.com/LucaSab48/CART315/blob/main/ProcessJournal/Images/KinectWindowsSDK.jpg)

I also had a group discussion this week for the central ideas for our final project. We have decided to make a more comedic game in the style of Papers Please / Thank Goodness You're Here based on the retail worker experience. While this isn't a concrete plan, it is a great starting off point. We also discussed the division of labour for the game. I am truly thankful to have great teammates with a range of artistic capabilities. 
My main focus for the game will be the development and game design. So mainly the necessary programming and the game mechanics at play. For the game I have a rough idea for a central loop. I was thinking we could make a game where the main player is a clerk at a retail store where he is in charge of dealing with returns. Similarly to Papers Please, the player will have to determine if the customer is eligible for a return or not. 
While these are just some quick ideas, I am very excited to begin working on this game. 
![alt text](https://github.com/LucaSab48/CART315/blob/main/ProcessJournal/Images/PapersPlease.png)
![alt text](https://github.com/LucaSab48/CART315/blob/main/ProcessJournal/Images/ThankGoodnessYoureHere.png)



## Iterative Prototype 2 | Implementation Prototype | 03.13.25
This week, our team spent time doing different forms of prototyping to get a general gist of the game as well as some building blocks to begin. My efforts were focused on creating the implementation prototype of our main game style, that being and point and click style game. So, I decided to begin by making a button that can be clicked on. I've never really made a cursor game in Unity before, it has all been controller based. 
So I tried learning how to make clickable objects inside Unity and found some neat tutorials examining the input system that already exists within the software itself. However, I spent close to 2 hours trying to make a clickable object using this system and for some reason I couldn't figure it out. I think the issue stems from the way I set up the Unity input system, because my code was looking fine. Anyways, I found out that there is a legacy input system that works through more hard coding and used that instead, which made it work perfectly. 
Since I had a working button, I thought I could continue my exploration by working on the main game loop, which is examining the contents of a suitcase using an x-ray screen and selecting the dangerous objects. I did this by making a screen with a bunch of clickable objects inside that the player could select. I worked on making the clicking feel more responsive, by adding some mouse hover feedback. I also made the button shrink in size when clicked. 
After making all that work, I decided to make a connection between the two objects. I made it so that only specifically selected items would allow a button click to move onto the next scene. This was more challenging than expected. There were a few oversights on my part when attempting to do this, such as making it so a that it'll only transition to the next scene if all the dangerous items were selected and also that if a safe item was selected the scene wouldn't change. I fixed these issues using two types of tags.

![alt text](https://github.com/LucaSab48/CART315/blob/main/ProcessJournal/Images/TSAPrototype1.gif)

After finally getting my prototype to work, I decided to add the sprites my teammate made into the empty scene that appears after the correct items have been selected. I was debating adding it into the working prototype, but I want to discuss with my teammates the way this game will function. Doing this prototype made me really reflect on the whole design of the game. It got me thinking more in depth about how the would really look like.
For example, I had to think about how the game would change scenes for the player, and what to do if there are no dangerous items. Also, what happens if the player fails? Anyways, its good that we got a start to the look and feel of the game and I can't wait to continue working on it.

What I did:
- Making a clickable button
- Making a screen with a bunch of clickable objects
- Allowing player to select items
- Giving more responsive feedback when clicking or maneuvering the mouse (i.e. highlighting object in red when selected, making button shrink when clicked, adding hovering feedback)
- Making a mini game loop where if the correct items are selected, hitting the button would change scenes
- Adding the sprites my teammate made into the empty scene

![alt text](https://github.com/LucaSab48/CART315/blob/main/ProcessJournal/Images/TSAPrototypeUnity1.png)

Future Additions:
- Making a more complete game loop with a better understanding of how the game will work
- Adding sound effects to make it more responsive
- Maybe working on making the sprites have function in the following scene
- Adding dialogue boxes
- Background music



## Iterative Prototype 3 | Further Implementation | 03.20.25
This was a rough week for advancing the previous prototype. After convening in class, our group had a more clear idea where to expand on to advance this project. My main goal for this week was to try and make a complete game loop starting off from our current prototype. So, I started off by working on the passenger check scene (scene with conveyer belt). I wanted to make it working in some capacity, so i made the buttons capable of moving a suitcase. I then wanted the suitcases to automatically spawn at the start of the scene and when the user pushes the suitcase off the screen. Since Dorsa made 5 sprites of suitcases, I wanted to randomize what sprites would show up and prevent doubles from spawning. 
After getting this working, I added another collision box to let the suitcases change scene when they reach a certain point. I initially used the same tags as i have in the x-ray screen scene to do this, but then opted to make a new tag for suitcases specifically for future uses. I was thinking I could make one of the suitcases dangerous and if the player lets that person on the plane then it would crash. I have to talk to my team about this idea however. I then turned my attention back to the x-ray screen scene. In class, we discussed making the objects randomize onto the suitcase, so thats what i decided to implement first. Dorsa made a bunch of sprites for the items, so I made two lists; one for safe items and one for dangerous items. 
I then spawned these items randomly between a certain public int range and position them randomly as well. I decided to add a cap on the amount of dangerous items possible and also a minimum distance the items would have to spawn away from the previously spawned item. This all ended up working fine. 

![alt text]()

After this is when everything starting going downhill. The next step I wanted to work on was making the suitcase respawn in the exact spot it was left off in the previous scene. I could not for the life of me figure out how to do this. I tried putting the prefabs in the DontDestroyOnLoad but this would cause the prefabs to load onto the next scene. So, I tried saving the data on a singleton data script, but even after it would save the position and sprite, I was not able to instantiate it into the reloaded scene. I basically threw myself against a brick wall for the past 2 days. Nothing I try works, I've tried toggling the object off when switching scenes, I tried to turn off the collider that changes scenes (because i thought that it was preventing the prefab from spawning), and many more attempts.
While writing this I got another idea to try, maybe if i just hard code the position it'll be easier to instantiate. But then I would still need to remember what suitcase sprite was used. Anywho, this is where I'm at. Hopefully my teammates can help me today to solve this issue. 

What I did:
- Made the buttons on conveyer belt work
- Made a suitcase spawner with an exit point
- Made a trigger to change scenes to x-ray machine
- Made the items inside suitcase be randomized 
- Made the randomized objects in the suitcase have a cap and min distance between each other

![alt text]()

Future Additions:
- Making the dang respawn work
- Making it so hitting the exit point increases a progression bar
- Making a full game cycle
- Adding more pizazz to the x-ray screen (approve and deny button)
- Maybe working on dialogue?
