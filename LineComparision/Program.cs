// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using LineComparision;

GeometricLine line1 = new GeometricLine();
GeometricLine Line2 = new GeometricLine();
Console.WriteLine("Enter line 1 details: ");
line1.GetPointsFromUser();
Console.WriteLine("Enter line 2 details: ");
Line2.GetPointsFromUser();
Console.WriteLine("\nLine 1: ");
line1.Describe();
Console.WriteLine("Line 2: ");
Line2.Describe();
