/// @description Insert description here
// You can write your code in this editor

//Choose to spawn on left or right side

//Use choose 0,1 to select a 50/50 chance

//Do not want to run this function if not in game room
if(room != rm_game) {
exit;
}

if(choose(0,1) == 0) {

	
//spawn at side of the game
var xx = choose(0, room_width);
var yy = irandom_range(0, room_height);

} else {

	//spawn at top of the game
	var xx = irandom_range(0, room_width);
	var yy = choose(0, room_height);

}

instance_create_layer(xx,yy,"Instances", obj_asteroid); 