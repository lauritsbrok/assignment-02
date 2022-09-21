namespace Assignment2.Tests;

public class DelegatesTests
{
    [Fact]
    public void firstTest()
    {   
        Action<string> reverseOrder = word => {foreach (char rev in word.Reverse()) Console.WriteLine(rev);}; //word.Reverse return a char[]
        reverseOrder("hej");
    }

    [Fact]

    public void productLamdpa(){
        //Arrange
        Func<int, int, int> product = (n1, n2) => {return n1 * n2;}; //the third int in func is the return type, while the others are paramter types

        //Act 
        var result = product(5,10);

        //Assert
        result.Should().Be(50);
    }

    [Fact]

    public void nummericalEqual(){
        //Arrange
        Func<int, string, bool> nummericalEqual = (int number, string numberAsString) => {return number == Int32.Parse(numberAsString);};

        //Act
        var result = nummericalEqual(42, "0042");

        //Assert
        result.Should().Be(true);
    
    }
}
