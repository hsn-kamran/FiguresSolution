namespace Figures.Tests;

public class RectangleTests
{
    [Fact]
    public void RectangleNegativeHeight_ShouldThrow_InvalidFigureArgumentException()
    {
        // Assert
        Assert.Throws<InvalidFigureArgumentException>(() => new Rectangle(-5, 2));
    }

    [Fact]

    public void RectangleZeroHeight_ShouldThrow_InvalidFigureArgumentException()
    {
        // Assert
        Assert.Throws<InvalidFigureArgumentException>(() => new Rectangle(0, 2));
    }


    [Fact]
    public void RectangleNegativeWidth_ShouldThrow_InvalidFigureArgumentException()
    {
        // Assert
        Assert.Throws<InvalidFigureArgumentException>(() => new Rectangle(3, -4));
    }


    [Fact]
    public void RectangleZeroWidth_ShouldThrow_InvalidFigureArgumentException()
    {
        // Assert
        Assert.Throws<InvalidFigureArgumentException>(() => new Rectangle(3, 0));
    }



    [Fact]
    public void RectangleArea_ShouldReturn_ExpectedValue()
    {
        // Arrange
        double expected = 30;
        Figure rectangle = new Rectangle(6, 5);

        // Act
        double actual = rectangle.Area;

        //Assert
        Assert.Equal(expected, actual);
    }
}
