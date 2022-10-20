Console.Clear();


int possiblepoints = 80;
int grade = 0;
int points = 0;
Console.Write("Did you write the exam? ");
string answer = Console.ReadLine()!;



if (answer == "yes" || answer == "YES")
{
    Console.WriteLine("How many point did you get? ");
    points += int.Parse(Console.ReadLine()!);
}

else { possiblepoints -= 20; }

Console.Write("Did you write the second exam? ");
answer = Console.ReadLine()!;
if (answer == "yes" || answer == "YES")
{
    Console.WriteLine("How many point did you get? ");
    points += int.Parse(Console.ReadLine()!);
}

else { possiblepoints -= 20; }

Console.WriteLine("How many points did you get in your Homework?");
points += int.Parse(Console.ReadLine()!);

 Console.WriteLine("Did you do the Oral Exam? ");
answer = Console.ReadLine()!;
if (answer == "yes" || answer == "YES")
{
    Console.WriteLine("How many Points did yo get? ");
    points += int.Parse(Console.ReadLine()!);
}
else { possiblepoints -= 20; }

double percent = 100d * points / possiblepoints;
if (percent >= 89)
{
    grade = 1;
}
else if (percent >= 76)
{
    grade = 2;
}
else if (percent >= 63)
{
    grade = 3;
}
else if (percent >= 50)
{
    grade = 4;
}
else
{
    grade = 5;
}

Console.WriteLine($"Your grade is: {grade}");