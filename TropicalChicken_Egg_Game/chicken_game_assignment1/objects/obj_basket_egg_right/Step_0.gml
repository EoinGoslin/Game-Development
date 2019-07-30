//Every frame update eggs in the basket to follow the basket
//So the eggs stay in the basket
var i = 0;
repeat(array_length_1d(eggs_in_basket_2)) {

eggs_in_basket_2[i].x = obj_basket2.x +  egg_x_locations_2[i];
eggs_in_basket_2[i].y = obj_basket2.y - egg_y_locations_2[i];
i += 1;

}
