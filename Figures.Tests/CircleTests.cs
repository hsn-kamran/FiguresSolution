namespace Figures.Tests;

public class CircleTests
{
    [Fact]
    public void CircleNegativeRadius_ShouldThrow_InvalidFigureArgumentException()
    {
        // Assert
        Assert.Throws<InvalidFigureArgumentException>(() => new Circle(-5));
    }


    [Fact]
    public void CircleZeroRadius_ShouldThrow_InvalidFigureArgumentException()
    {
        // Assert
        Assert.Throws<InvalidFigureArgumentException>(() => new Circle(0));
    }


    [Fact]
    public void CircleArea_ShouldReturn_ExpectedValue()
    {
        // Arrange
        double expected = 314.15926535897931;
        Figure circle = new Circle(10);

        // Act
        double actual = circle.Area;

        //Assert
        Assert.Equal(expected, actual);
    }
}
