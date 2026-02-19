using Project498.WebApi.Services;

namespace Project498.WebApi.Tests;

public class StringServiceTests
{
    private readonly StringService _stringService = new();
    private readonly StringService _stringService2 = new();

    [Theory]
    [InlineData("hello", "olleh")]
    [InlineData("", "")]
    [InlineData(null, "")]
    [InlineData("a", "a")]
    [InlineData("racecar", "racecar")]
    [InlineData("hello world", "dlrow olleh")]
    [InlineData("hello  world", "dlrow  olleh")]
    [InlineData(" hello world", "dlrow olleh ")]
    [InlineData("hello world ", " dlrow olleh")]
    public void Reverse_WithVariousInputs_ReturnsExpectedResult(string? input, string expected)
    {
        var result = _stringService.Reverse(input!);

        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData("hello", "hello")]
    [InlineData("", "")]
    [InlineData(null, "")]
    [InlineData("a", "a")]
    [InlineData("racecar", "racecar")]
    [InlineData("hello world", "world hello")]
    [InlineData("hello  world", "world  hello")]
    [InlineData(" hello world", "world hello ")]
    [InlineData("hello world ", " world hello")]
    public void Reverse_WithMoreInputs_ReturnExpectedResults(string? input, string expected)
    {
        var result = _stringService2.ReverseWords(input!);

        Assert.Equal(expected, result);
    }
}
