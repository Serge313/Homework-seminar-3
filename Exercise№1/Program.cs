int fiveDigitNumber = GetNumber("Enter your five-digit number ");


int a = fiveDigitNumber / 10000;
int b = (fiveDigitNumber / 1000) % 10;
int c = (fiveDigitNumber % 100) / 10;
int d = fiveDigitNumber % 10;
if ((fiveDigitNumber.ToString()).Length == 5)
{
    if ((a == d) && (b == c))
    {
        Console.WriteLine("Yes");
    }
    else
    {   
        Console.WriteLine("No");
    }
}
else
{
    Console.WriteLine("Please, enter a FIVE-DIGIT number!");
}


int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}