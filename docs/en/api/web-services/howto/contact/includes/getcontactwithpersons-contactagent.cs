using SuperOffice;
using SuperOffice.CRM.Services;

using(SoSession newSession = SoSession.Authenticate("sam", "sam"))
{
  //Instantiating the Contact Agent
  using(ContactAgent newConAgt = new ContactAgent())
  {
    //Retrieving a Contact Entity with the use of the Contact Agent
    ContactEntity newConEnt = newConAgt.GetContactWithPersons(143);

    //Retriving properties of a Person from the Contact Entity
    if (newConEnt.Persons.Length > 0)
    {
      Console.WriteLine("Full Name" + "\t" + "ContactName" + "\t" + "Email");
      foreach (Person newPerson in newConEnt.Persons)
      {
        Console.WriteLine(newPerson.Firstname + " " + newPerson.Lastname + "\t");
        Console.Write(newPerson.ContactName + "\t");
        Console.Write(newPerson.Email);
        Console.WriteLine();
      }
    }
  }
}