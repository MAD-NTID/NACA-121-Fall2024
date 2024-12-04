// var people = new [] {
//     new {name="Agent M.", age=50},
//     new {name="Agent Q.", age=25},
//     new {name="Agent T.", age=20}
// };

// var NameAndAgeIn5YearTime = people.Select(
//     person => new {name = person.name, ageInFiveYearTime = person.age + 5}
// );

// foreach(var person in NameAndAgeIn5YearTime) {
//     Console.WriteLine($"Person Name: {person.name} will be {person.ageInFiveYearTime} years old in five years time");
// }

// List<int> numbers = new() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

// Get all the numbers from the list that are multiples of 3
List<int> evenNumbers = numbers.Where(num => num % 3 == 0).ToList();

// Display all of the numbers that are multiple of 3 collected from the previous lambda expression
foreach(int num in evenNumbers)
    Console.WriteLine(num);