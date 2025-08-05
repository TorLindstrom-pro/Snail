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

    [Fact(DisplayName = "3x3 array")]
    public void ThreeByThreeArray()
    {
        // Act
        var result = Kata.Snail([
            [1,2,3],
            [8,9,4],
            [7,6,5]
        ]);
        
        // Assert
        Assert.Equal([1,2,3,4,5,6,7,8,9], result);
    }

    [Fact(DisplayName = "4x4 array")]
    public void FourByFourArray()
    {
        // Act
        var result = Kata.Snail([
            [1,2,3,4],
            [12,13,14,5],
            [11,16,15,6],
            [10,9,8,7]
        ]);
        
        // Assert
        Assert.Equal([1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16], result);
    }
}
