//Find the chicken who laid the egg, and make its sprite back to resting position
var i;
for (i = 0; i < instance_number(obj_chicken); i += 1)
   {
    var chicken = instance_find(obj_chicken,i);
	if chicken.sprite_index != spr_chicken {
		chicken.sprite_index = spr_chicken
	}
   }