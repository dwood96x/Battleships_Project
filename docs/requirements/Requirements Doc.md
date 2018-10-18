# Requirements

## Functional Requirements

## Game board:
	(GB1)Create a game board using a grid system with 10x10 squares for both players
	(GB2)Ability to move and rotate ships before the game starts
	(GB3)Keep players from placing ships adjacent to another ships

## Game logic
	(GL1)Player clicks on a square to fire a round
	(GL2)Fire feedback (EI: Miss, hit, hit and destroyed ship, already fired)
	(GL3)When a hit is made they can fire again
	(GL4)Switch players turn after a miss
	(GL5)If a enemy ship is destroyed, clear all squares adjacent to it
	(GL6)When all ships are destroyed for one player, declare winner (BACK1 & 2)
		
## AI
	(AI1)Generates a random ship layout
	(AI2)Starts with "Searching" fires to find the player ships optimally (EI: Only shoots squares diagonally)
	(AI3)Switches to "Destroying" fires when enemy ship is found (EI: When round hits enemy it keeps shooting in that direction, if no hit it fires in a adjacent possible ship location until the ship is destroyed)
	(AI4)Switches to "Ending" fires when its no longer possible to "Search"
	
## Back-end
	(BACK1)Send up match to database on win (GL6)
	(BACK2)Update database stats