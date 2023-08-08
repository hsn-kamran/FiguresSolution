namespace Figures.Exceptions;

public class InvalidFigureArgumentException : Exception
{
    public InvalidFigureArgumentException(string argument) : base($"Invalid argument exception {argument}")  { }
}