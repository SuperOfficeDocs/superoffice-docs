using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
//retrieve the person you want to change to a person entity
  Person myPerson = Person.GetFromIdxPersonId(17);

  //change the first name and last name
  myPerson.Firstname = "John";
  myPerson.Lastname = "White";

  //retrieve a person position row that you want to
  //assign as the person position to a row object
  PersPosRow personPosition = PersPosRow.GetFromIdxPersPosId(1);

  //assign retrieved position row as the position of the person
  myPerson.Position = personPosition;

  //fill in the basic properties of the address row
  myPerson.Address.Address1 = "No: 73";
  myPerson.Address.Address2 = "West Gate Street";
  myPerson.Address.Address3 = "Lexington";
  myPerson.Address.City = "Kentucky ";

  //finally save the person entity
  myPerson.Save();
}