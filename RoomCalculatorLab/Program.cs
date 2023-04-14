Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!!");

Console.Write("Enter Length: ");
double length = double.Parse(Console.ReadLine());

Console.Write("Enter Width: ");
double width = double.Parse(Console.ReadLine());

double area = length * width;
Console.WriteLine($"The area of the room is: {area}");

double perimeter = 2 * (length + width);
Console.WriteLine($"The perimeter of the room is: {perimeter}");

if (area <= 250)
{
    Console.WriteLine("The room is small.");
}
else if (area > 250 && area < 650 )
{
    Console.WriteLine("The room is medium.");
}
else if (area >= 650 )
{
    Console.WriteLine("The room is large.");
}