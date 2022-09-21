namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void Test1()
    {
        //Arrange
        var uri = new Uri("https://sss.com");

        var test = uri.IsSecure();
        //Assert

        test.Should().Be(true);
    }

    [Fact]
    public void AmountOfCharsWithANumber(){
        string word = "cake5";

        int lengthOfWord = word.WordCount();
        lengthOfWord.Should().Be(4);
    }
}
