using TestNewWcfApi.SoPrincipalSvc;
using C=TestNewWcfApi.ContactSvc;

SoPrincipalClient svc = new SoPrincipalClient();
bool bSuccess;
bool bAuthSuccess;
SoTimeZone tz = null;
SoPrincipalCarrier soPrincipal = null;
SoCredentials soCredentials = null;

SoExceptionInfo ex = svc.AuthenticateUsernamePassword("pass", "user", out bSuccess, out tz, out soPrincipal, out bAuthSuccess, out soCredentials);

if (ex != null)
    Console.WriteLine("Error:" + ex.FriendlyText);
else
if( !bAuthSuccess )
    Console.WriteLine("Error: Login failed");
else
{
  // now call another web service using the ticket we got from the auth service
  string ticket = soCredentials.Ticket;
  C.SoTimeZone tz2 = new TestNewWcfApi.ContactSvc.SoTimeZone();
  tz2.SoTimeZoneId = tz.SoTimeZoneId;
  tz2.SoTimeZoneLocationCode = tz.SoTimeZoneLocationCode;
  tz2.ExtensionData = tz.ExtensionData;

  C.SoCredentials soCredentials2 = new TestNewWcfApi.ContactSvc.SoCredentials();
  soCredentials2.Ticket = soCredentials.Ticket;
  soCredentials2.ExtensionData = soCredentials.ExtensionData;

  C.Contact1Client contactSvc = new C.Contact1Client();
  C.Contact aContact = null;
  C.SoExceptionInfo ex2 = contactSvc.GetContact(soCredentials2, ref tz2, 4, out bSuccess, out aContact);

  if (ex2 != null)
  Console.WriteLine("Error: " + ex2.FriendlyText);
  else
  Console.WriteLine(aContact.Name);
}