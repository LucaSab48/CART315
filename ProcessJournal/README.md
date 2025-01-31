# Process Journal

## Make a Thing | 01.23.25
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
For this exploration, I decided to continue the prototype we made in class. I added a boundary box on the bottom of the game to destroy any game objects that go off. I then added a score board in the top right corner of the screen using the legacy text UI feature. I used the boundary box to keep count of the score. 
I also changed the sprite of the square to a pop cat and changed the circle prefab to a croissant. I also made the croissants drop slightly faster as time went on by multiplying it with 0.98 very loop and making it have a max drop speed of 0.35. I bounded the pop cat so that it won't go off screen. I also added 3 UI images of the pop cat under the score to illustrate lives of the player. Every time a croissant hits the bound box, one of the images goes away. 
I intended for this to be the whole game loop, where after the lives of the player are all lost, it would change to the end scene and it'll display their score and have a restart button. Alas, I did not have the time to implement this. I wanted to add sound effects as well (like a crunching sound for when the pop cat eats a croissant) but this seemed rather difficult. 
I also wanted to explore the camera aspect of unity as well but this game didn't seem like the best prototype for this exploration. With a little more tweaking, this could be a semi-complete game. I'd love to add some background image and music. 