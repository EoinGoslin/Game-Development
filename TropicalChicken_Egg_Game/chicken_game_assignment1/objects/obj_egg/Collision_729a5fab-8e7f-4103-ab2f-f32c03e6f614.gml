if !audio_is_playing(snd_egg_splat) {
	audio_play_sound(snd_egg_splat, 1, false);	
	} 
speed = 0;
direction = 0;
sprite_index = spr_egg_broken;
// Delete object after 1 second
alarm[0] = room_speed*0.5;

eggFalling = false;

