if room == rm_start {
//Start playing menu music
//Play win sound
if !audio_is_playing(snd_menu) {
audio_play_sound(snd_menu, 1, false);	
} 
	
if keyboard_check_pressed(49) {
	//Play click noise
	if !audio_is_playing(snd_mouse_click) {
	audio_play_sound(snd_mouse_click, 1, false);	
	}
	
	breakNumber = 20;
	room_goto(rm_game);
}	

if keyboard_check_pressed(50) {
	//Hard mode has been activated
	//Play click noise
	if !audio_is_playing(snd_mouse_click) {
	audio_play_sound(snd_mouse_click, 1, false);	
	}
	hard = true;
	breakNumber = 40;
	room_goto(rm_game);
}
}


if room == rm_help {
	
	if keyboard_check_pressed(vk_enter) {
	//Play click noise
	if !audio_is_playing(snd_mouse_click) {
	audio_play_sound(snd_mouse_click, 1, false);	
	}
	
	room_goto(rm_start);
	}
}

if room == rm_start {
	if keyboard_check_pressed(vk_enter) {
		//Play click noise
		if !audio_is_playing(snd_mouse_click) {
		audio_play_sound(snd_mouse_click, 1, false);	
		}
		room_goto(rm_help);
		}
	
}

//Player can quit at any time in the game

if keyboard_check_pressed(vk_escape) game_end();

if room == rm_game {
    
	
	//Play game background music
	//Stop menu music first
	if audio_is_playing(snd_menu) {
	audio_stop_sound(snd_menu);	
	} 
	if !audio_is_playing(snd_tropical_background) {
	audio_play_sound(snd_tropical_background, 1, false);	
	}
	//Check time limit
	if timeLimit <= 0 {
		//Game is over
		show_debug_message("Game finished");
		room_goto(rm_game_over);
	}
	
}


if room == rm_game_over {
	
	if keyboard_check_pressed(vk_enter) {
	
	
		//Play click noise
	if !audio_is_playing(snd_mouse_click) {
	audio_play_sound(snd_mouse_click, 1, false);	
	}
	game_restart();
	
	}


}









