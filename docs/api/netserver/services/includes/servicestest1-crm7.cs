using ServicesTest1.ContactRef;

SoPrincipal p;
SoPrincipalClient soprincipal = new SoPrincipalClient();
SoPrincipalCarrier principalResponse;
SoCredentials cred;
bool success;
bool authSuccess;
SoTimeZone tz;

SoExceptionInfo ex;
ex = soprincipal.AuthenticateUsernamePassword( "password", "username", out success, out tz, out principalResponse, out authSuccess, out cred );
Console.WriteLine("Auth {0} call={1} auth={2}", "ADM0", success, authSuccess);

Contact1Client contAgent = new Contact1Client();
ContactEntity contactResponse;
ex = contAgent.GetContactEntity(cred, ref tz, 2, out success, out contactResponse);
Console.WriteLine("Contact {0}: {1} {2}", contactResponse.ContactId, contactResponse.Name, contactResponse.Country.Name);

Person1Client persAgent = new Person1Client();
PersonEntity persResult;
ex = persAgent.GetPersonEntity(cred, ref tz, 33, out success, out persResult);

Console.WriteLine("Person {0}: {1} {2} - {3}", persResult.PersonId, persResult.Firstname, persResult.Lastname, persResult.Contact.Name);