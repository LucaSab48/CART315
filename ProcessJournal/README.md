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