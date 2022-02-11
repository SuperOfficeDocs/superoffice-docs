using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Retrieving a Sale using the index of a Sale
  Sale newSale = Sale.GetFromIdxSaleId(2);

  //Updating a Contact Entity property through a Sale Entity
  newSale.Contact.Name = "Name Changed 2";
  newSale.Contact.OrgNr = "SA-5454545";

  //Creating a Row and assigning it to the Sale Entity and modifying its values
  BusinessRow newBusinessRw = BusinessRow.GetFromIdxBusinessId(10);
  newSale.Contact.Business = newBusinessRw;
  newSale.Contact.Business.Name = "New Business 2";
  newSale.Contact.Business.Tooltip = "New Tool tip";

  //Creating a Row Collection and assigning it the Sale Entity and modifying its values
  PhoneRow newPhoRow = PhoneRow.CreateNew();
  newPhoRow.PhoneNumber = "987654321";
  newPhoRow.Description = "Testing Method 2";
  int posPhoRow = newSale.Contact.Phones.Add(newPhoRow);
  newSale.Contact.Phones[posPhoRow].PhoneNumber = "5555555555";
  newSale.Contact.Phones[posPhoRow].Description = "Testing methods 2B";

  //Creating an Entity and assigning it to the Sale Entity and modifying its values
  Person newPers = Person.CreateNew();
  int posPersonRow = newSale.Contact.Persons.Add(newPers);
  newSale.Contact.Persons[posPersonRow].Firstname = "Will";
  newSale.Contact.Persons[posPersonRow].Lastname = "Turner";

  URLRow newUrl = URLRow.CreateNew();
  int posURLRow = newSale.Contact.Persons[posPersonRow].Urls.Add(newUrl);
  newSale.Contact.Persons[posPersonRow].Urls[posURLRow].UrlAddress1 = "www.testSuperOffice.com";

  if (newSale.IsDirty == true)
  {
    //Saving the Sale Entity
    newSale.Save();
  }
}