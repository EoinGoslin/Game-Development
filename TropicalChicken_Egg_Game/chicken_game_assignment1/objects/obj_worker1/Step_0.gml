//if left key, tilt ship a certain direction
//Right is 0
//Down is 270
//Top is 90
//left was pressed
//If the alarm is not on, turn on its timer to 2 again
//This alarm causes eggs to be randomly dropped under random chickens
if !alarm[0] { alarm[0] = room_speed * 2 }

if keyboard_check(ord("Z") ){
	//moving fast then
	
	if (keyboard_check(ord("C"))){
	
	if hard {
	//move slower
	motion_set(image_angle, -2);
	} else {
	motion_set(image_angle, -4);
	}
	
	
	//obj_basket1.x -= 5;
	
}

if (keyboard_check(ord("V"))){


	if hard {
	//move slower
	motion_set(image_angle, 2);
	} else {
	motion_set(image_angle, 4);
	}
	
	
	
}
}

if keyboard_check(ord("X") ){
	//moving slow then
	
	if (keyboard_check(ord("C"))){
	
	if hard {
	//move slower
	motion_set(image_angle, -1);
	} else {
	motion_set(image_angle, -2);
	}

	//obj_basket1.x -= 2;
}

if (keyboard_check(ord("V"))){
	
	if hard {
	//move slower
	motion_set(image_angle, 1);
	} else {
	motion_set(image_angle, 2);
	}
	

}


}


