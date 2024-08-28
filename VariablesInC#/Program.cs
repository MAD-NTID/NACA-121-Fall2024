int age = 20;
string name = "Travis";
string major = "Game Designing";




Console.WriteLine("Name:" + name + " Age:"+ age + " Major:"+major);

Console.WriteLine($"Name:{name} Age:{age} Major:{major}");

Console.WriteLine("Name:{0} Age:{1} Major:{2}", name, age, major);

//Type conversions

int foo  = 5;
long foo2 = 20;
double meh = 9.5;
foo2 = foo; //implicit type conversion

foo = (int)foo2; //explicit conversion

foo = (int)meh;////explicit conversion

string fooInStringNumeric = "20";
//there are .Parse for all of the different bultin types
int fooStringNumericToActualNumber = int.Parse(fooInStringNumeric); //approach one using .parse


//There are Convert.<something> for the other types as well
int fooStringNumbericToActualUsingConvert  = Convert.ToInt32(fooInStringNumeric);