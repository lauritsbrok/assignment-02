namespace StudentNamespace;

public class ImmutableStudentTest
{
    [Fact]
    public void ImmutableStudentNewToString()
    {
        
        var student = new ImmutableStudent(1, "Bobby", "Man", new DateTime(2023, 05, 17), new DateTime(2026, 05, 18));

        var toString = student.ToString();

        Assert.Equal("ID: 1, Given Name: Bobby, Surname: Man, Status: New", toString);
        
    }

    [Fact]
    public void ImmutableStudentGraduatedToString()
    {
        
        var student = new ImmutableStudent(1, "Peter", "Man", new DateTime(2019, 05, 17), new DateTime(2022, 05, 18));

        var toString = student.ToString();

        Assert.Equal("ID: 1, Given Name: Peter, Surname: Man, Status: Graduated", toString);
        
    }

    [Fact]
    public void ImmutableStudentSameToString()
    {
        
        var student1 = new ImmutableStudent(1, "Peter", "Man", new DateTime(2019, 05, 17), new DateTime(2022, 05, 18));
        var student2 = new ImmutableStudent(1, "Peter", "Man", new DateTime(2019, 05, 17), new DateTime(2022, 05, 18));

        Assert.Equal(student1, student2);
        
    }
}