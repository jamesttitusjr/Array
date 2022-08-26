// See https://aka.ms/new-console-template for more information

// Maximum index is 1 less than the number you choose so 4 would be as far as this would go. (Console.Writline for aligning scores to the
// right and it goes behind the box quote (ex. [0],5). Currency (ex. [0],8:C). One decimal place (ex. [0],8:N1).

int[] scores = new int[5];
scores[0] = 100;
scores[1] = 95;
scores[2] = 97;
scores[3] = 100;
Console.WriteLine($"{ scores[0],5}, { scores[1],5}, { scores[2],5}, { scores[3],5}, { scores[4],5}");

// Same with last score not recorded (? behind ints).
int?[] scores2 = new int?[] { 100, 95, 97, 100, null };
Console.WriteLine($"{scores2[0]}, {scores2[1]}, {scores2[2]}, {scores2[3]}, {scores2[4]}");

// An array of names with Strings
string[] names = { "Josh", "Billy", "Karl", "Caleb", "Ian", "Jack", "Sam", "James" };


//?? Not is instructors example ??
names[0] = Karl;
names[1] = Caleb;
names[2] = Ian;
names[3] = Josh;
names[4] = Billy;
names[5] = Jack;
names[0] = Sam;
names[0] = James;
Console.WriteLine($"{names[0]}, {names[1]}, {names[2]}, {names[3]}, {names[4], {names[5]}, {names[6]}, {names[7}}");

// 1. Bowling 145, 264, 244  

int[] games = { 145, 264, 244 };
//int seriesScore = games[0] + games[1] + games[2];
Console.WriteLine($"Series score is {games[0]}, {games[1]}, {games[2]}");

// 2.Asking User for scores

int[] scores = new int[3];

Console.Write("Please give me the score of the first game: ");
string answer = Console.ReadLine();
scores[0] = Convert.ToInt32(answer);

Console.Write("Please give me the score of the second game: ");
answer = Console.ReadLine();
scores[1] = Convert.ToInt32(answer);

Console.Write("Please give me the score of the third game: ");
answer = Console.ReadLine();
scores[2] = Convert.ToInt32(answer);

int total = scores[0] + scores[1] + scores[2];
Console.WriteLine($"The total of scores {scores[0]}, {scores[1]}, and {scores[2]} is {total}");


// To get data from User.
Console.Write("Enter a string and press Enter: ");
string? response = Console.ReadLine();
Console.WriteLine($"You typed {response}");

// To convert to a number.
Console.Write("Guess a number from 1 to 10: ");
string answer = Console.ReadLine();
int myNumber = Convert.ToInt32(answer);
Console.WriteLine($"The number is {myNumber}");

