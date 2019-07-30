var rand = irandom_range(0,1);
//So the egg does not always go to the right of the basket
//50% chance egg will be placed slightly to the right in basket
if(rand <=0) {
x_offset_2+=10;
} else {
x_offset_2 -=2;
}

y_offset_2-=5;
//Setting x and y location of that egg to be the offset amount
egg_x_locations_2[num_eggs_in_basket_2] = x_offset_2;
egg_y_locations_2[num_eggs_in_basket_2] = y_offset_2;
