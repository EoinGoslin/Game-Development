// Clear eggs from obj_basket_2 and reset offsets
num_eggs_in_basket_2 = 0;
eggs_in_basket_2 = 0;
x_offset_2 = 0;
y_offset_2 = 40;


//And destroy all the eggs that were in the basket

var i;
for (i = 0; i < instance_number(obj_basket_egg_right); i += 1)
   {
    var chicken = instance_find(obj_basket_egg_right,i);
	with(chicken) {
		instance_destroy();
	}
	
   }