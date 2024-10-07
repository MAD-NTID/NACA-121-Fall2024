// Beast dragon = new Dragon("Meh", 300,300);

// if(dragon is Dragon){
//     Dragon toChild = (Dragon)dragon;
//     toChild.Breath();   
// }


// Dragon drag = new Dragon("Travis", 500,900);

// PrintInfo(dragon);

// Beast godzilla = new Godzilla("Foo", 200,200);


// void PrintInfo(IBeast beast)
// {
//     Console.WriteLine($"Name:{beast.Name}, Current HP: {beast.CurrentHealthPoint}, Max HP:{beast.MaxHealthPoint}");
// }

Beast dragon = new Dragon("Meh", 300,300);
Beast dragon2 = new Dragon("Meh", 300,300);

Console.WriteLine(dragon.Equals(dragon2));



