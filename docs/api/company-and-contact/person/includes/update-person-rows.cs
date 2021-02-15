using SuperOffice.CRM.Rows;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  // retrieve the person row that we want to change
  PersonRow myPersonRow = PersonRow.GetFromIdxPersonId(17);

  // change the first name and the last name
  myPersonRow.Firstname = "John";
  myPersonRow.Lastname = "White";

  // change the position here we have to know the position number we want to change to
  myPersonRow.PositionIdx = 1;

  // save the person row
  myPersonRow.Save();

  // retrieve the address of the person using the address type and the person id
  AddressRow personAddressRow = AddressRow.GetFromIdxAtypeIdxOwnerId(SuperOffice.Data.AddressType.PersonPrivateAddress, 17);

  // change the address
  personAddressRow.Address1 = "No: 73";
  personAddressRow.Address2 = "West Gate Street";
  personAddressRow.Address3 = "Lexington";
  personAddressRow.City = "Kentucky";

  // save the address row
  personAddressRow.Save();
}