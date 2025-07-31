using Snail;

namespace Test;

public class KataTest
{
    [Fact(DisplayName = "Empty array as input returns empty array")]
    public void EmptyArray()
    {
        // Act
        var result = Kata.Snail([[]]);
        
        // Assert
        Assert.Empty(result);
    }

    [Fact(DisplayName = "1x1 array")]
    public void OneByOneArray()
    {
        // Act
        var result = Kata.Snail([[2]]);
        
        // Assert
        Assert.Equal([2], result);
    }

    [Fact(DisplayName = "2x2 array")]
    public void TwoByTwoArray()
    {
        // Act
        var result = Kata.Snail([[1,2],[4,3]]);
        
        // Assert
        Assert.Equal([1,2,3,4], result);
    }
}
