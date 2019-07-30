var rand = irandom_range(0,1);
//So the egg does not always go to the right of the basket
if(rand <=0) {
x_offset_1+=10;
} else {
x_offset_1 -=2;
}

y_offset_1-=5;
//For every egg, move it 5 to the right, then set each egg to be that coordinate
egg_x_locations_1[num_eggs_in_basket_1] = x_offset_1;
egg_y_locations_1[num_eggs_in_basket_1] = y_offset_1;
