//Remove egg sprites in basket after a collision has occured if that was the outcome
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