int x = 5, y = 0, z = 0;

//long way
x = x+ 1;
y = x;

Console.WriteLine("Long way prefix--> x:{0},y:{1}",x,y);

//short hand .. prefix
 x = 5; 
 y = 0; 
 z = 0;
y = ++x;
Console.WriteLine("Short cut prefix--> x:{0},y:{1}",x,y);


//postfix
 //long way
 x = 5; 
 y = 0; 
 z = 0;
y = x;
x = x + 1;
Console.WriteLine("Long way postfix--> x:{0},y:{1}",x,y);

//short hand
 x = 5; 
 y = 0; 
 z = 0;
y = x++;
Console.WriteLine("Short cut postfix--> x:{0},y:{1}",x,y);

