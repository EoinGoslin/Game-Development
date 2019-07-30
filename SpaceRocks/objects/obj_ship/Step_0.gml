/// @description Insert description here
// You can write your code in this editor
//if left key, tilt ship a certain direction
//Right is 0
//Down is 270
//Top is 90
//left was pressed
if (keyboard_check(vk_left)) {
	//Adding 5 onto itself
	image_angle = image_angle + 5;
	
}

if (keyboard_check(vk_right)) {
	//Adding 5 onto itself
	image_angle = image_angle - 5;
	
}

//Change x and y position 
//x is horizontal, y is bottom to top
if (keyboard_check(vk_up)) {
	//Adds a certain amount of motion in a certain direction
	//To simulate in Space
	motion_add(image_angle, 0.05);	
}

//Shoot function
//Check pressed is only once every time clicked so prevents holding and firing multiple bullets
if (keyboard_check_pressed(vk_space)) {
	
	audio_play_sound(snd_zap, 1, false);
	//Adds a certain amount of motion in a certain direction
	//To simulate in Space
	//Returns id of object of instance created
	//var are local/temporary variables
	//x and y are instance variables every object has
	//Location of the current object 
	
	var instId = instance_create_layer(x,y, "Instances", obj_bullet)
	instId.direction = image_angle;	 
} 
 
//Check if went outside the room
//using room wrap
//Horizontal or Vertical Margin

//Wait for whole ship to be outside the room before warping
move_wrap(true, true, sprite_width/2);