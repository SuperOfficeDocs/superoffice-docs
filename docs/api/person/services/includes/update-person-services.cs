using SuperOffice;
using SuperOffice.CRM.Services;

using(SoSession newSession = SoSession.Authenticate("sam", "sam"))
{
  //Instantiating a Agents required
  using(PersonAgent newPerAgt = new PersonAgent())
  {
    using(ListAgent newLstAgt = new ListAgent())
    {
      //Retrieving a Person Entity
      PersonEntity newPerEnt = newPerAgt.GetPersonEntity(214);

      //Updating Properties of the Person Entity
      //String type properties
      newPerEnt.Firstname = "Luke";
      newPerEnt.Lastname = "Skywalker";

      //Updating a property of LocalizedField type
      LocalizedField[][] newAddress = newPerAgt.GetAddressByCountry(4, 144);
      newAddress[0][0].Value = "65, Sky Lane, LayLand.";
      newPerEnt.Address = newAddress;

      //Updating a Country type property
      newPerEnt.Country = newLstAgt.GetCountry(60);

      //Adding a EntityElement type Property
      //creating an Email
      EntityElement[] newEmailArr = new EntityElement[1];
      newEmailArr[0] = new EntityElement();
      newEmailArr[0].Value = "luke@example.com";
      newEmailArr[0].Description = "Testing";

      //Assigning the Email to the Email property of the Person
      newPerEnt.Emails = newEmailArr;

      //Modifying an existing Email
      newPerEnt.Emails[0].Value = "lukeUpdated@example.com";
      newPerEnt.Emails[0].Description = "Test Updated";

      //Assign the Position
      newPerEnt.Position = newLstAgt.GetPosition(1);

      //Saving the updated Person Entity
      newPerAgt.SavePersonEntity(newPerEnt);
    }
  }
}