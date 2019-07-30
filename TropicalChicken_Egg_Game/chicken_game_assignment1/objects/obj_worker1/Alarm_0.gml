//This alarm will spawn an egg every two seconds

//Pick a random chicken to spawn an egg under
if !hard {


var randLocation = irandom_range(0, 5);
} else {

var randLocation = irandom_range(0, 9);
}
//var randLocation = irandom_range(0, 5);
var chicken_laying_egg = chicken_ids[randLocation];
chicken_laying_egg.sprite_index = spr_chicken_laying_egg;
if !audio_is_playing(snd_chicken_laying_egg) {
	audio_play_sound(snd_chicken_laying_egg, 1, false);	
	} 
instance_create_layer(chicken_laying_egg.x, chicken_laying_egg.y + 40, "Instances", obj_egg);
alarm[1] = 1*room_speed;