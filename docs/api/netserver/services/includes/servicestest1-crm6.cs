using ServicesTest1.ContactRef;
public Contact Authenticate()
{
  //Create an instance of the class Contact
  ContactRef.Contact myContact = new ContactRef.Contact();

  //Set the SOAP header
  myContact.SoCredentials = new SoCredentialsHeader();
  myContact.SoCredentials.AuthenticationType = SoAuthenticationType.CRM5;
  myContact.SoCredentials.UserId = "SAL0";

  //Generate the secret for CRM5 associate SAL0 with a blank password
  //The secret contains : "CRM5"+[AssociateName]+[AssociatePassword]+[Days]
  myContact.SoCredentials.Secret =  CalculateCredentialsSecret(SoAuthenticationType.CRM5,GetDays(),"SAL0","");

  //Retrieve a ContactEntity
  ContactRef.ContactEntity myContactEntity = myContact.GetContactEntity(12);
  string name = myContactEntity.Name;
}