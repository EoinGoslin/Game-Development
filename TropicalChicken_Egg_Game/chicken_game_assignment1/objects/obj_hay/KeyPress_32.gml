//If there has been at least a 2 second gap since the last hay bale fell
if hayDisabled != true {
	if !audio_is_playing(snd_hay_falling) {
    audio_play_sound(snd_hay_falling, 1, false);	
    }
instance_create_layer(x, y, "Instances", obj_hay_falling);
hayDisabled = true;
}
//Player can drop hay at max 2 second intervals
alarm[0] = 2*room_speed;