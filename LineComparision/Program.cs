// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using LineComparision;

Console.Title = "Line Comparison App";
Console.WriteLine("----------------------Geometry Line Comparison App----------------------");

// Create 2 Line objects
CompareLines line1 = new CompareLines();
CompareLines Line2 = new CompareLines();

// Input the points for each line
Console.WriteLine("Enter line 1 details: ");
line1.GetPointsFromUser();
Console.WriteLine("Enter line 2 details: ");
Line2.GetPointsFromUser();

// Display the info of each line
Console.WriteLine("\nLine 1: ");
line1.Describe();
Console.WriteLine("Line 2: ");
Line2.Describe();

// Compare the line lengths and display result
int result = line1.Compare(Line2);
switch (result)
{
    case 0:
        Console.WriteLine("The lines are equal in length");
        break;
    case 1:
        Console.WriteLine("Line 1 length is lesser than line 2");
        break;
    case 2:
        Console.WriteLine("Line 1 length is greater than line 2");
        break;
    default:
        Console.WriteLine("Error!!");
        break;
}
