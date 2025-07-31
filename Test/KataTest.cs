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
}
