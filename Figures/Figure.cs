namespace Figures;


public abstract class Figure
{
    private readonly Lazy<double> _area;

    protected Figure() => _area = new Lazy<double>(GetArea);

    public double Area => _area.Value;


    protected abstract double GetArea(); 

}
