using SuperOffice;
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using(SoSession newSession = SoSession.Authenticate("SAL0", ""))
{
  //create an entity
  Sale mySale = Sale.CreateNew();
  mySale.SetDefaults();

  //here we are accessing a property of another entity
  mySale.Person.Firstname = "Johnny";
  mySale.Person.Lastname = "Depp";
  mySale.Person.DayOfBirth = 09;
  mySale.Person.MonthOfBirth = 06;
  mySale.Person.YearOfBirth = 1963;
  mySale.Person.Gender = 2;

  PhoneRow numerOne = PhoneRow.CreateNew();
  numerOne.PhoneNumber = "123456";
  numerOne.Rank = 1;

  PhoneRow numbrerTwo = PhoneRow.CreateNew();
  numbrerTwo.PhoneNumber = "890112";
  numbrerTwo.Rank = 2;

  //here we are adding rows to another entities property that is exposed as a row.
  mySale.Person.MobilePhones.Add(numerOne);
  mySale.Person.MobilePhones.Add(numbrerTwo);

  //save the sale entity
  mySale.Save();
}