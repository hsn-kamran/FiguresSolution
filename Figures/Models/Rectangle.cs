namespace Figures.Models;

/// <summary>
/// As an example of adding new figure
/// </summary>
public class Rectangle : Figure
{
    private double _height;
    private double _width;


    public Rectangle(double height, double width)
    {
        if (height <= 0)
            throw new InvalidFigureArgumentException(nameof(height));

        if (width <= 0)
            throw new InvalidFigureArgumentException(nameof(width));

        _height = height;
        _width = width;
    }


    public double Width { set => _width = value; }
    public double Height { set => _height = value; }


    protected sealed override double GetArea()
    {
        return _width * _height;
    }
}
