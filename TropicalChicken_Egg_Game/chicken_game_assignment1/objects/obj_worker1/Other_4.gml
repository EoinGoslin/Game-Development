//Create global variable to store chicken ids
//This array of chicken ids is used to randomly select a chicken to spawn an egg under
global.chicken_ids = 0;
var i = 0;
pos_x = 80;
pos_y = 250;


if !hard {
repeat(6) {
	
	chicken_ids[i] = instance_create_layer(pos_x, pos_y, "Instances", obj_chicken);
	pos_x += 150;
	i += 1;
}
alarm[0] = 2*room_speed;
} else {


//Double the chickens on hard mode
repeat(10) {
	
	chicken_ids[i] = instance_create_layer(pos_x, pos_y, "Instances", obj_chicken);
	pos_x += 90;
	i += 1;
}
alarm[0] = 2*room_speed;

}
