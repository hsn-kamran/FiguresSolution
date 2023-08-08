using Figures.Exceptions;

namespace Figures.Models;

public class Circle : Figure
{
    private double _radius;

    public Circle(double radius)
    {
        if(radius <= 0)
            throw new InvalidFigureArgumentException(nameof(radius));

        _radius = radius;       
    }

    public double Radius { set => _radius = value; }



    protected sealed override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}
