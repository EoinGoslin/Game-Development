collision = true;
//Check if players lost their eggs

//To see if eggs will break, use this logic

//If random number generated >= 15, egg breaks
//On easy, random number is between 1-20 so only 5 numbers can cause eggs to break
//On hard, random number is between 1-40, so now 25 numbers can cause eggs to break

var outcome = irandom_range(0, breakNumber);
//If the player was going fast when crashed, increase number so increased likelihood of being > 15
if speed > 2 {
 outcome += 4;
}

//Now check if outcome of collision will cause the eggs to break
if outcome >= 15 {
//eggs are broken
brokenMessage = true;
//Same things happens as when picks up hay now, clear eggs from basket that were exposed
//remove instances as well from basket
num_eggs_in_basket_1 = 0;
eggs_in_basket_1 = 0;
x_offset_1 = 0;
y_offset_1 = 40;
//Clear Player 2 eggs as well
num_eggs_in_basket_2 = 0;
eggs_in_basket_2 = 0;
x_offset_2 = 0;
y_offset_2 = 40;

//Remove sprites
//Player 1
var i;
for (i = 0; i < instance_number(obj_basket_egg_left); i += 1)
   {
    var chicken = instance_find(obj_basket_egg_left,i);
	with(chicken) {
		totalPlayer1_eggs -=1;
		instance_destroy();
	}
	
   }

//Player 2
var i;
for (i = 0; i < instance_number(obj_basket_egg_right); i += 1)
   {
    var chicken = instance_find(obj_basket_egg_right,i);
	with(chicken) {
		totalPlayer2_eggs -=1;
		instance_destroy();
	}
	
   }
   alarm[3] = 0.5*room_speed;
} //end of broken egg outcome

alarm[2] = 2*room_speed;
motion_add(image_angle, -3);
with(other){
motion_add(image_angle, 3);


}