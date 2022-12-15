using SuperOffice.CRM.Services;
using SuperOffice;

using(SoSession newSession = SoSession.Authenticate("SAL0", ""))
{
  //Retrieve a ContacttAgent
  using(ContactAgent contactAgent = new ContactAgent())
  {
    //Create a new contact Entity with default values set to its properties
    ContactEntity myContact = contactAgent.CreateDefaultContactEntity();

    //Assign values to various properties of the contact entity

    //Assign values to properties of basic data types
    myContact.Name = "Paba Inc.";
    myContact.Department = "Head office";
    myContact.NoMailing = true;

    //Create an array of EntityElement and assign it to the Phones property
    EntityElement[] myPhones = new EntityElement[2];
    myPhones[0] = new EntityElement();
    myPhones[1] = new EntityElement();
    myPhones[0].Value = "0112732006";
    myPhones[1].Value = "0713243288";
    myContact.Phones = myPhones;

    // Set the new contact’s  our-contact to associate 2
    using(AssociateAgent associateAgent = new AssociateAgent())
    {
      Associate myAssociate = associateAgent.GetAssociate(2);
      myContact.Associate = myAssociate;

      // Set the contact’s address
      myContact.Address[0][0].Value = "98/1,Main Street, Inland";
      myContact.Address[3][0].Value = "10620,";
      myContact.Address[3][1].Value = "Inland";  

      //Save the Contact Entity and the new person through the ContactAgent
      // the returned entity has the contact ID filled in
      myContact = contactAgent.SaveContactEntity(myContact);
    }
  }
}