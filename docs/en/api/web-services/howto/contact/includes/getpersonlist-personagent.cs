using SuperOffice;
using SuperOffice.CRM.Services;

using(SoSession newSession = SoSession.Authenticate("sam", "sam"))
{
  //Instantiating the Person Agent
  using(PersonAgent newPerAgt = new PersonAgent())
  { 
    //Local variable Declaration
    int [] personIds = {100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110};

    //Retrieving a List of Persons
    Person[] newPersonArr = newPerAgt.GetPersonList(personIds);

    Console.WriteLine("Full Name" + "\t" + "ContactName" + "\t" + "Email");

    //Retrieving Properties of Person in the Person list
    foreach (Person newPerson in newPersonArr)
    {
      Console.Write(newPerson.Firstname + " " + newPerson.Lastname + "\t");
      Console.Write(newPerson.ContactName + "\t");
      Console.Write(newPerson.Email);
      Console.WriteLine();
    }
  }
}