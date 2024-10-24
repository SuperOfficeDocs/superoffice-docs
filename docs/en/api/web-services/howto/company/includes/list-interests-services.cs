using SuperOffice;
using SuperOffice.CRM.Services;

Console.Write("Please Enter the UserName :- ");
string userName = Console.ReadLine();

Console.Write("Please enter the password :- ");
string passWord = Console.ReadLine();
Console.WriteLine();

using (SoSession newSession = SoSession.Authenticate(userName, passWord))
{
  //Retrieve a Contact Entity using the Contact Agent
  ContactAgent newConAgt = new ContactAgent();
  ContactEntity newConEnt = newConAgt.GetContactEntity(10);

  //Retrieve all available Interests for a Contact
  SelectableMDOListItem[] newSelMdoLstItms = newConEnt.Interests;

  foreach(SelectableMDOListItem newSelMdoLstItm in newSelMdoLstItms)
    {
      //Retrieve only the selected Interest of the Contact
      if(newSelMdoLstItm.Selected)
        Console.WriteLine(newSelMdoLstItm.Name);
    }

  Console.ReadLine();
}