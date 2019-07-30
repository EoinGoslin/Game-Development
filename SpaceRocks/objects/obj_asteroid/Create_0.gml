/// @description Insert description here
// You can write your code in this editor

//Runs only once when the object is created
//Will randomly choose between arguments given
sprite_index = choose(
	
	spr_asteroid_small,
	spr_asteroid_med,
	spr_asteroid_huge
	
);

//Choose a random direction and head that way
//0 to 360 degrees
direction = irandom_range(0, 359);
//So all asteroids look slightly different
image_angle  = irandom_range(0, 359);
speed = 1;//set it to move