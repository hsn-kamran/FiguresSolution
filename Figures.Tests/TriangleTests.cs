namespace Figures.Tests;

public class TriangleTests
{
    [Fact]
    public void TriangleNegativeSideA_ShouldThrow_InvalidFigureArgumentException()
    {
        // Assert
        Assert.Throws<InvalidFigureArgumentException>(() => new Triangle(-5, 2, 4));
    }

    
    [Fact]
    public void TriangleZeroSideA_ShouldThrow_InvalidFigureArgumentException()
    {
        // Assert
        Assert.Throws<InvalidFigureArgumentException>(() => new Triangle(0, 2, 4));
    }


    [Fact]
    public void TriangleNegativeSideB_ShouldThrow_InvalidFigureArgumentException()
    {
        // Assert
        Assert.Throws<InvalidFigureArgumentException>(() => new Triangle(3, -4, 5));
    }


    [Fact]
    public void TriangleZeroSideB_ShouldThrow_InvalidFigureArgumentException()
    {
        // Assert
        Assert.Throws<InvalidFigureArgumentException>(() => new Triangle(3, 0, 5));
    }


    [Fact]
    public void TriangleNegativeSideC_ShouldThrow_InvalidFigureArgumentException()
    {
        // Assert
        Assert.Throws<InvalidFigureArgumentException>(() => new Triangle(3, 4, -5));
    }


    [Fact]
    public void TriangleZeroSideC_ShouldThrow_InvalidFigureArgumentException()
    {
        // Assert
        Assert.Throws<InvalidFigureArgumentException>(() => new Triangle(3, 4, 0));
    }


    [Fact]
    public void RightAngledTriangle_ShouldReturn_True()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5);

        // Act
        bool actual = triangle.RightAngled;

        //Assert
        Assert.True(actual);
    }


    [Fact]
    public void NotRightAngledTriangle_ShouldReturn_False()
    {
        // Arrange
        var triangle = new Triangle(4, 5, 6);

        // Act
        bool actual = triangle.RightAngled;

        //Assert
        Assert.True(!actual);
    }


    [Fact]
    public void TriangleArea_ShouldReturn_ExpectedValue()
    {
        // Arrange
        double expected = 6;
        Figure triangle = new Triangle(3, 4, 5);

        // Act
        double actual = triangle.Area;

        //Assert
        Assert.Equal(expected, actual);
    }
}
