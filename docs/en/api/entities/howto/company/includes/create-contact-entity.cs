using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("sam", "sam"))
{
  //Create a Contact Entity
  Contact newContact = Contact.CreateNew();

  //Setting the Defaults for the Contact
  newContact.SetDefaults();

  //Assigning values for the individual properties of the Contact
  //Assigning basic properties to a Contact
  newContact.Name = "EuroCenter";
  newContact.OrgNr = "1234523";
  newContact.Number1 = "7412885";

  //Adding a Row type property to a Contact Entity
  newContact.Country = new CountryRow.IdxCountryId(40);

  //Creating Email Rows
  EmailRow eMail1 = EmailRow.CreateNew();
  eMail1.EmailAddress = "Matt1@Fox.com";
  eMail1.Description = "Mathews first email";

  EmailRow eMail2 = EmailRow.CreateNew();
  eMail2.EmailAddress = "Matt2@Fox.com";
  eMail2.Description = "Mathews second email";

  //Adding the created Row types to the Properties of Rows type to the Contact Entity
  newContact.Emails.Add(eMail1);
  newContact.Emails.Add(eMail2);

  //Assigning values to Properties of Entity Collection Types.
  Sale newSale1 = new Sale.IdxSaleId(10);
  Sale newSale2 = new Sale.IdxSaleId(20);
  newContact.Sales.Add(newSale1);
  newContact.Sales.Add(newSale2);

  //Saving the Created Contact Entity
  newContact.Save();
}