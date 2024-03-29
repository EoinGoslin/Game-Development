with(other) {
//Destroy egg so that total count does not go up more than one each collection
instance_destroy();

var egg = instance_create_layer(obj_basket1.x + array_length_1d(eggs_in_basket_1), obj_basket1.y - 30, "egg_basket", obj_basket_egg_left);
if !audio_is_playing(snd_catch_egg) {
audio_play_sound(snd_catch_egg, 1, false);	
}
//Add the egg to an array of eggs
eggs_in_basket_1[num_eggs_in_basket_1] = egg;
}
num_eggs_in_basket_1 +=1;
totalPlayer1_eggs +=1;


//Now check if that player catching latest egg breaks other non-protected eggs
//On normal mode, there less of a chance that unprotected eggs will break
if !hard {

	var outcome = irandom_range(0,15);
} else {

	var outcome = irandom_range(0, 20);
}


//More eggs player has in basket, regardless of difficulty will cause eggs to break
outcome += num_eggs_in_basket_1;
if outcome >=15 and num_eggs_in_basket_1 > 1 {
	//Then eggs break
	num_eggs_in_basket_1 = 0;
	eggs_in_basket_1 = 0;
	x_offset_1 = 0;
	y_offset_1 = 40;


    //And destroy all the eggs that were in the basket

	var i;
	for (i = 0; i < instance_number(obj_basket_egg_left); i += 1)
   {
		var egg = instance_find(obj_basket_egg_left,i);
		with(egg) {
		totalPlayer1_eggs -=1;
		instance_destroy();
	}
	
   }
   for (i = 0; i < instance_number(obj_basket_egg_left); i += 1)
   {
		var egg = instance_find(obj_basket_egg_left,i);
		with(egg) {
		totalPlayer1_eggs -=1;
		instance_destroy();
	}
	
   }
   //remove last egg after loop
		var egg = instance_find(obj_basket_egg_left,0);
		with(egg) {
		totalPlayer1_eggs -=1;
		instance_destroy();
		}
   brokenMessage = true;
} //end of outcome being broken eggs
//Clear the message from the screen after two seconds
alarm[0] = 2*room_speed;





