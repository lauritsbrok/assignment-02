namespace Assignment2.Tests;

public class QueriesTests
{
    [Fact]
    public void GetJKRowlingWizard()
    {
        // Arrange
        Queries queries = new Queries();

        // Act
        var wizName = queries.getWizards("J.K Rowling");
        //wizName.GetEnumerator().MoveNext();
        var acWL = new List<string>
        {
            "Harry Potter",
            "Ron Weasley"
        };

        // Assert
        Assert.Equal(acWL, wizName);
    }

    [Fact]
    public void GetYearOfTheFirstSithLord()
    {
        // Arrange
        Queries queries = new Queries();
        // Act
        int wizName = queries.getYearOFTheFirstSithLord();
        // Assert
        Assert.Equal(1977, wizName);
    }
    [Fact]
    public void GetJKRowlingWizardsTest()
    {
        // Arrange
        Queries queries = new Queries();
        var tupleList = new List<Tuple<string, string>>
        {
            Tuple.Create("Harry Potter", "1997"),
            Tuple.Create("Ron Weasley", "1997")
        };
        // Act
        var wizList = queries.getListOfHPWizards().ToList();
        // Assert
        Assert.Equal(tupleList, wizList);
    }

    [Fact]
    public void GetCreatorAndWizardNameTest()
    {
        // Arrange
        Queries queries = new Queries();
        var tupleList = new List<Tuple<string, string>>
        {
            Tuple.Create("J.R.R. Tolkien","Sauron"),
            Tuple.Create("J.R.R. Tolkien","Gandalf"),
            Tuple.Create("J.K Rowling","Harry Potter"),
            Tuple.Create("J.K Rowling","Ron Weasley"),
            Tuple.Create("George Lucas","Darth Vader"),
            Tuple.Create("George Lucas","Darth Maul"),
            Tuple.Create("George Lucas","Obi-Wan Kenobi"),
            Tuple.Create("George Lucas","Qui-Gon Jinn"),
            Tuple.Create("George Lucas","Luke Skywalker"),
            Tuple.Create("George Lucas","Anakin Skywalker")
        };
        // Act
        var wizList = queries.getCreatorNameAndWizard().ToList();
        // Assert
        Assert.Equal(tupleList, wizList);
    }  
}
