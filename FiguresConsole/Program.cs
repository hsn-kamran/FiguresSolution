using Figures.Models;
using Figures;

Figure figure = new Triangle(3, 4, 5); 
Figure figure2 = new Circle(5);


Console.WriteLine(((Triangle)figure).RightAngled);
Console.WriteLine(figure2.Area);