/// @description Insert description here
// You can write your code in this editor
if(room == rm_game) {
	//Restart song if it is playing
	if(audio_is_playing(spaceRocksSong)) {
	
		audio_stop_sound(spaceRocksSong);
	}  
	
	
	//Play background song
	//True to say do loop the song
	
	audio_play_sound(spaceRocksSong, 2, true);
	//create asteroids at x and y position
	//Want these asteroids to spawn not on top of player
	//Just around the player
	
	//Spawn six asteroids
	repeat(6) {
	
	
	//Choose left third or right third
	
	//Width
	var xx = choose (
		irandom_range(0, room_width*0.3),
		irandom_range(room_width*0.7, room_width)
	);
	
	//Height
	var yy = choose (
		irandom_range(0, room_height*0.3),
		irandom_range(room_height*0.7, room_height)
	);
	
	instance_create_layer(xx,yy, "Instances", obj_asteroid);
	} //end of repeat
	
	
	//Spawn after sixty steps
	//alarm[0] = 60;
	//Or
	//One second = alarm[0] = room_speed*1;
	//Spawn asteroid every 4 seconds
	alarm[0] = 4*room_speed;

}