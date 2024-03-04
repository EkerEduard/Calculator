Console.WriteLine("Hello!");

Console.WriteLine("Input the first number: ");
string firstNum = Console.ReadLine();
int numberFirst = int.Parse(firstNum);

Console.WriteLine("Input the second number: ");
string secondNum = Console.ReadLine();
int numberSecond = int.Parse(secondNum);

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");
string userChoice = Console.ReadLine();

if(EqualsCaseInsensitive(userChoice, "A"))
{
    int sum = numberFirst + numberSecond;
    PrintFinalEquation(numberFirst, numberSecond, sum, "+");

} 
else if (EqualsCaseInsensitive(userChoice, "S"))
{
    int difference = numberFirst - numberSecond;
    PrintFinalEquation(numberFirst, numberSecond, difference, "-");
}
else if (EqualsCaseInsensitive(userChoice, "M"))
{
    int multiplied = numberFirst * numberSecond;
    PrintFinalEquation(numberFirst, numberSecond, multiplied, "*");
}
else
{
    Console.WriteLine("Invalid choice!");
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();

bool EqualsCaseInsensitive(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}

void PrintFinalEquation(int numberFirst, int numberSecond, int result, string @operator)
{
    Console.WriteLine(numberFirst + " " + @operator + " " + numberSecond + " = " + result);
}