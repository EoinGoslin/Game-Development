// Clear eggs from obj_basket_1 and reset offsets
num_eggs_in_basket_1 = 0;
eggs_in_basket_1 = 0;
x_offset_1 = 0;
y_offset_1 = 40;


//And destroy all the eggs that were in the basket

var i;
for (i = 0; i < instance_number(obj_basket_egg_left); i += 1)
   {
    var chicken = instance_find(obj_basket_egg_left,i);
	with(chicken) {
		instance_destroy();
	}
	
   }