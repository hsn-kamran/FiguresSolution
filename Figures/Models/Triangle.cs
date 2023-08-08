using Figures.Exceptions;

namespace Figures.Models;

 public class Triangle : Figure
 {
    private double _sideA;

    private double _sideB;

    private double _sideC;

    private readonly Lazy<bool> _rightAngled;

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0)
            throw new InvalidFigureArgumentException(nameof(sideA));

        if (sideB <= 0)
            throw new InvalidFigureArgumentException(nameof(sideB));

        if (sideC <= 0)
            throw new InvalidFigureArgumentException(nameof(sideC));

        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;

        _rightAngled = new Lazy<bool>(IsRightAngled);
    }


    public double SideA { set => _sideA = value; }
    public double SideB { set => _sideB = value; }
    public double SideC { set => _sideC = value; }

    public bool RightAngled => _rightAngled.Value;


    private double SemiPerimeter() => (_sideA + _sideB + _sideC) / 2;

    private bool IsRightAngled()
    {
        double[] sides = new double[] {_sideA, _sideB, _sideC};
        double hypotenuse = sides.Max();

        var cathets = sides.Where(s => s != hypotenuse).ToArray();

        return hypotenuse * hypotenuse == cathets[0] * cathets[0] + cathets[1] * cathets[1];
    }


    protected sealed override double GetArea()
    {
        double semiPerimiter = SemiPerimeter();

        return Math.Sqrt(semiPerimiter * (semiPerimiter - _sideA) * (semiPerimiter - _sideB) * (semiPerimiter - _sideC));        
    }
 }

