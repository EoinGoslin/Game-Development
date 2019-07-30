//188 is the , key
//191 is the / key
//190 is the . key
//Using motion_set and image_angle to move player continuously
//just doing x = x + 1 meant the player stop after movement is finished


if keyboard_check(191){
	//moving fast then
	
	if (keyboard_check(ord("M"))){
	
	if hard {
	//move slower
	motion_set(image_angle, -2);
	} else {
	motion_set(image_angle, -4);
	}
}

if keyboard_check(188){
	
	if hard {
	//move slower
	motion_set(image_angle, 2);
	} else {
	motion_set(image_angle, 4);
	}
	
}


}


if keyboard_check(190){
	
	
	if keyboard_check(ord("M")){
	
    if hard {
	//move slower
	motion_set(image_angle, -1);
	} else {
	motion_set(image_angle, -2);
	}
	
	
}

if keyboard_check(188){
	
	if hard {
	//move slower
	motion_set(image_angle, 1);
	} else {
	motion_set(image_angle, 2);
	}
	
	
}
}


