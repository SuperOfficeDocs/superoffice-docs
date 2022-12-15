using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using SuperOffice;
using(SuperOffice.SoSession mySession =
SuperOffice.SoSession.Authenticate("SAL0", ""))
{
  //Retriving a Sale using the index of a Sale
  Sale newSale = Sale.GetFromIdxSaleId(2);

  //Retrieving a Person Entity
  Person newPerson = Person.GetFromIdxPersonId(25);

  //Updating Person Entity Basic properties
  newPerson.Firstname = "Jessica";
  newPerson.Lastname = "Alba";

  //Updating Person Entity properties which are of Row type
  BusinessRow newBusiness = BusinessRow.GetFromIdxBusinessId(9);
  newBusiness.Name = "New Business";
  newPerson.Business = newBusiness;

  //Updating Person Entity properties which are Entities itself
  Contact newContact = Contact.CreateNew();
  newContact.Name = "John Stevens";
  URLRow newUrls = URLRow.CreateNew();
  newUrls.UrlAddress1 = "www.SuperOffice.com/test";
  newContact.Urls.Add(newUrls);
  newContact.Row.Number1 = "SA-147258";
  if (newContact.IsDirty == true)
  {
    //Assigning the Contact to the Person
    newPerson.Contact = newContact;
  }

  //Updating Person Entity porperty which is of Rows type
  EmailRow newEmails = EmailRow.CreateNew();
  newEmails.EmailAddress = "jessica@stars.com";
  newEmails.Description = "Jessica's Email";
  newPerson.Emails.Add(newEmails);

  //Assigning the Person property to the Sale
  newSale.Person = newPerson;
  if (newSale.IsDirty == true)
  {
    //Saving the Sale Entity
    newSale.Save();
  }
}