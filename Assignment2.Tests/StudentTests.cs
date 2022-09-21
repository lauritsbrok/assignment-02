
namespace StudentNamespace;

public class Studenttest
{
    [Fact]
    public void StudentNewToString()
    {
        
        var student = new Student{Id = 1, GivenName = "Thomas"};
        student.Surname = "Holt";
        student.StartDate = (new DateTime(2023, 09, 30));
        student.GraduationDate = (new DateTime(2026, 09, 30));

        var toString = student.ToString();

        Assert.Equal("ID: 1, Given Name: Thomas, Surname: Holt, Status: New", toString);
        
    }

    [Fact]
    public void StudentActiveToString()
    {
        
        var student = new Student{Id = 1, GivenName = "Bob"};
        student.Surname = "Andersen";
        student.StartDate = (new DateTime(2021, 09, 30));
        student.GraduationDate = (new DateTime(2024, 09, 30));

        var toString = student.ToString();

        Assert.Equal("ID: 1, Given Name: Bob, Surname: Andersen, Status: Active", toString);
        
    }

    [Fact]
    public void StudentDropoutToString()
    {
        
        var student = new Student{Id = 1, GivenName = "Lisa"};
        student.Surname = "Jensen";
        student.StartDate = (new DateTime(2021, 09, 30));
        student.EndDate = (new DateTime(2022, 05, 17));
        student.GraduationDate = (new DateTime(2024, 09, 30));

        var toString = student.ToString();

        Assert.Equal("ID: 1, Given Name: Lisa, Surname: Jensen, Status: Dropout", toString);
        
    }

    [Fact]
    public void StudentGraduateToString()
    {
        
        var student = new Student{Id = 1, GivenName = "Matt"};
        student.Surname = "Scott";
        student.StartDate = (new DateTime(2017, 09, 30));
        student.GraduationDate = (new DateTime(2021, 09, 30));

        var toString = student.ToString();

        Assert.Equal("ID: 1, Given Name: Matt, Surname: Scott, Status: Graduated", toString);
        
    }
}
