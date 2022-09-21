namespace StudentNamespace;

public record ImmutableStudent(int Id, string GivenName, string Surname, DateTime StartDate, DateTime GraduationDate){
    // internal int Id {get; init;} = Id;

    public DateTime EndDate {get; set;}
    public Status Status {get{return calculateStatus();}}

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

    public override string ToString()
    {
        return "ID: " + Id + ", Given Name: " + GivenName + ", Surname: " + Surname + ", Status: " + Status;

    }
}