int givenNumber = GetNumber("Enter your number ");
int number = 1;

while (number <= givenNumber)
{
    Console.WriteLine(ToThirdPower(number));
    number++;
}


int ToThirdPower(int a)
{
    int thirdPower = (a * a * a);
    return thirdPower;
}

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}