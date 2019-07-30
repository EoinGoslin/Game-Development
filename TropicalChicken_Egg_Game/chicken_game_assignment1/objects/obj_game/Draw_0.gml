var colour = c_red;
switch (room) {
	case rm_game:
	
	draw_text(20,20, "Left Player total eggs: " + string(totalPlayer1_eggs));
	draw_text(20,40, "Right Player total eggs: " + string(totalPlayer2_eggs));
	draw_text(700,80, "Time Left: " + string(timeLimit));
	if run_once == false
	{
	run_once = true;
	alarm[0] = room_speed * 1;
	}
	if hard {
	draw_text(700,60, " Difficulty: EGGSELLENT");
	} else {
	draw_text(700,60, " Difficulty: NORMAL");
	}
	
	 draw_set_halign(fa_center);
	if collision {
  
	draw_text_transformed_color(
		room_width/2, 100, "Collision!!!!",
		3,3,0, colour, colour, colour, colour, 1
	);
	 
	  collision = false;
	} else {
	  draw_text_transformed_color(
		room_width/2, 100, " ",
		3,3,0, colour, colour, colour, colour, 1
	);
	}
	
	//players collided and eggs broke
	if brokenMessage {
	draw_text_transformed_color(
		room_width/2, 10, "Eggs Broken",
		1,1,0, c_black, c_black, c_black, c_black, 1
	);
	}
	
	
	draw_set_halign(fa_left);
	break;
	
	case rm_start:
	//Align Text in the centre
	draw_set_halign(fa_center);
	
	draw_text_transformed_color(
		room_width/2, 100, "Tropical Egg Collectors!",
		3,3,0, colour, colour, colour, colour, 1
	);
	//@ symbol in a string to type string over multiple lines
	draw_text(room_width/2, 200,
	@"Catch All the Eggs you Can!

	Choose a Difficulty to Play By Entering the Number
	
	1 - Normal Mode
	
	2 - Extreme Mode: Are you eggsellent at the game? ;)
	
	PRESS ENTER For Help 
	
	PRESS Esc To Quit
	"
	);

	draw_set_halign(fa_left);
	break;
	
	
	case rm_help:
	//Align Text in the centre
	draw_set_halign(fa_center);
	var colour = c_green;
	draw_text_transformed_color(
		room_width/2, 50, "YOU Need Help!",
		3,3,0, colour, colour, colour, colour, 1
	);
	//@ symbol in a string to type string over multiple lines
	draw_text(room_width/2, 60,
	@"
	
	Control Left Character:
   
	Z      X     C      V  
	Fast  Slow  Left  Right
  ------------------------------
    Control Right Character:
	
	/      .     M      ,  
	Fast  Slow  Left  Right
  ------------------------------
  
    SPACE BAR - Drop hay
  ------------------------------
	
	.Catch as many eggs as possible within the time limit
	
	.The more eggs in the basket, more likely they are to break
	
	.To stop this, press SPACE to drop hay
	
	.After hay drops, must wait 2 seconds before more hay available again
	
	.Catchers use this hay to safely store their eggs 
	
	.Collisions can cause exposed eggs to break
	
	
	PRESS Enter To Go Back
	"
	
	);

	draw_set_halign(fa_left); 
	
	break;
	
	case rm_game_over:
	//Align Text in the centre
	draw_set_halign(fa_center);
	var colour = c_blue;
	
	
	var finishedMessage = "";
	finishedMessage = "GAME OVER \n" + 
	"Thank you for playing! \n Press Enter to play again :) \n \n" + 
	"Player 1 Score: " + string(totalPlayer1_eggs) + 
	" \n" +
	"Player 2 Score: " + string(totalPlayer2_eggs) + " \n" +
	"To end the game, press ESC";
	draw_text_transformed_color(
		room_width/2, 200, finishedMessage,
		3,3,0, colour, colour, colour, colour, 1
	);

	draw_set_halign(fa_left); 
	
	break;
}