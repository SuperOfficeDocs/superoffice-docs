using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("sam", "sam"))
{
  //Create an Instance of another Entity
  Person newPerson = Person.CreateNew();
  newPerson.SetDefaults();

  //Assigning values for the individual properties of the ContactEntity of the Person Property
  //Assigning basic properties to a Contact Entity
  newPerson.Contact.Name = "EuroCenter";
  newPerson.Contact.OrgNr = "1234523";
  newPerson.Contact.Number1 = "7412885";

  //Creating Email Rows
  EmailRow eMail1 = EmailRow.CreateNew();
  eMail1.EmailAddress = "Anna1@Nicole.com";
  eMail1.Description = "Anna first email";

  EmailRow eMail2 = EmailRow.CreateNew();
  eMail2.EmailAddress = "Anna2@Nicole.com";
  eMail2.Description = "Anna second email";

  //Adding the created Row types to the Properties of Rows type to the Contact Entity Property of the Person Entity
  newPerson.Contact.Emails.Add(eMail1);
  newPerson.Contact.Emails.Add(eMail2);

  //Assigning values to Properties of Entity Collection Types.
  Sale newSale1 = Sale.GetFromIdxSaleId(10);
  Sale newSale2 = Sale.GetFromIdxSaleId(20);
  newPerson.Contact.Sales.Add(newSale1);
  newPerson.Contact.Sales.Add(newSale2);

  //Saving the Updated Entity
  newPerson.Save();
}