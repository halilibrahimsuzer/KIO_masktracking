using Business.Concrete;
using Entities.Concrete;

public class Program
{
    private static void Main(string[] args)
    {
        Person person1 = new Person()
        {
            FirstName = "Halil İbrahim",
            LastName = "Süzer",
            NationalIdentity = 45447973651,  //not real; It cannot end with a single digit. :)
            DateOfBirthYear = 1910
        };

        PttManager pttManager = new PttManager(new PersonManager());

        pttManager.GiveMask(person1);
    }
}