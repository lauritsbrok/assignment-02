namespace Assignment2;

public class Queries
{
    public IEnumerable<string> getWizards(string authorName)
    {
        var wizardList = WizardCollection.Create(); 
        
        var rowlingWizards = (
            from wizard in wizardList
            where wizard.Creator == authorName
            select wizard.Name
        ).ToList();
        return rowlingWizards;
    }

    public int getYearOFTheFirstSithLord()
    {
        var wizardList = WizardCollection.Create(); 

        var sithWizards = (
            (from wizard in wizardList
            where wizard.Creator == "George Lucas" && wizard.Name.Contains("Darth")
            select wizard.Year)
            .Min()
        );
        return (int)sithWizards!;
    }

    public IEnumerable<Tuple<string, string>> getListOfHPWizards()
    {
        var wizardList = WizardCollection.Create(); 

        var rowlingWizards = (
            from wizard in wizardList
            where wizard.Creator == "J.K Rowling"
            select new Tuple<string, string>(wizard.Name, wizard.Year.ToString()!)
        ).ToList();
        return rowlingWizards;
    }

    //List of wizard names grouped by creator in reverse order by creator name and then wizard name.
    public IEnumerable<Tuple<string, string>> getCreatorNameAndWizard()
    {
        var wizardList = WizardCollection.Create(); 

        var rowlingWizards = (
            from wizard in wizardList
            orderby wizard.Creator descending
            select new Tuple<string, string>(wizard.Creator, wizard.Name)
        ).ToList();
        return rowlingWizards;
    }
}    