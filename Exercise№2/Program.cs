double firstDotFirstCoordinate = GetNumber("Enter the first coordinate of the first dot ");
double firstDotSecondCoordinate = GetNumber("Enter the second coordinate of the first dot ");
double firstDotThirdCoordinate = GetNumber("Enter the third coordinate of the first dot ");
double secondDotFirstCoordinate = GetNumber("Enter the first coordinate of the second dot ");
double secondDotSecondCoordinate = GetNumber("Enter the second coordinate of the second dot ");
double secondDotThirdCoordinate = GetNumber("Enter the third coordinate of the second dot ");
double firstCathetus = Cathetus(firstDotFirstCoordinate, secondDotFirstCoordinate);
double secondCathetus = Cathetus(firstDotSecondCoordinate, secondDotSecondCoordinate);
double thirdCathetus = Cathetus(firstDotThirdCoordinate, secondDotThirdCoordinate);
double distance = Distance(firstCathetus, secondCathetus, thirdCathetus);
Console.WriteLine(distance);


double Cathetus(double a, double b)
{
    double cathetus = (b - a);
    return cathetus;
}


double Distance(double a, double b, double c)
{
    double dist = Math.Sqrt((a * a) + (b * b) + (c * c));
    return dist;
}


double GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}