namespace StudentNamespace;

public class Student {
    public int Id { get; init; }
    public string GivenName { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public DateTime StartDate {get; set;}
    public DateTime EndDate {get; set;}
    public DateTime GraduationDate {get; set;}
    public Status Status {get{return calculateStatus();} }

    public override string ToString(){
        return "ID: " + Id + ", Given Name: " + GivenName + ", Surname: " + Surname + ", Status: " + Status;
    }

    public Status calculateStatus(){
        var today = DateTime.Today;
        if(EndDate.CompareTo(GraduationDate) < 0 && EndDate != DateTime.MinValue){
            return Status.Dropout;
        }
        if(GraduationDate.CompareTo(today) < 0){
            return Status.Graduated;
        }
        if(StartDate.CompareTo(today) < 0){
            return Status.Active;
        }
        return Status.New;
    }
}