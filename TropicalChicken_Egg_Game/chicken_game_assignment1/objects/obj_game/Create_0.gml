globalvar hard;
hard = false;



globalvar brokenMessage;
brokenMessage = false;

//Number that is subracted from every second of the game
timeLimit = 15;
//Setting to false, so alarm will be called every second not just once
//Used in Draw event
run_once = false;

globalvar breakNumber;
//Depending on difficulty and speed, will dictate if players lose their eggs or not on collision
breakNumber = 0;

globalvar collision;
collision = false;

draw_set_font(fnt_text);
//Seed game with different starting random point each time
//Otherwise, eggs always fall in same 'random' order each time
randomize();