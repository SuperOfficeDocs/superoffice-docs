using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("sam", "sam"))
{
  //Create a Contact Row
  Contact newContact = Contact.CreateNew();
  //Setting the Defaults for the Contact
  newContact.SetDefaults();
  //Assigning values for the individual properties of the ContactEntity
  //Assigning basic properties to a Contact
  newContact.Name = "EuroCenter";
  newContact.OrgNr = "1234523";
  newContact.Number1 = "7412885";
  //Adding a Row type property to a Contact Entity
  newContact.Country = new CountryRow.IdxCountryId(40);
  //Creating Email Rows
  EmailRow eMail1 = EmailRow.CreateNew();
  eMail1.EmailAddress = "Frank@Hardy.com";
  eMail1.Description = "Frank first email";
  EmailRow eMail2 = EmailRow.CreateNew();
  eMail2.EmailAddress = "Frank@Hardy.com";
  eMail2.Description = "Frank second email";
  //Adding the created Row types to the Properties of Rows type to the Contact Entity
  newContact.Emails.Add(eMail1);
  newContact.Emails.Add(eMail2);
  //Assigning values to Properties of Entity Collection Types.
  Sale newSale1 = new Sale.IdxSaleId(10);
  Sale newSale2 = new Sale.IdxSaleId(20);
  newContact.Sales.Add(newSale1);
  newContact.Sales.Add(newSale2);
  //Instantiating a Contact Collection
  ContactCollection newConCol = ContactCollection.CreateNew();
  //Adding the Contact Entity to the Collection and Saving the Collection
  newConCol.Add(newContact);
  newConCol.Save();
}