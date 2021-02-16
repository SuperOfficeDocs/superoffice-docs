---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: make_soap_calls_crm_7       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: How to make SOAP calls with CRM 7 # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so.topic: howto           # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# How to make SOAP calls with CRM 7

SOAP calls can be made by .Net or Java clients. It is essential to create a website in the web server before implementing any client application. And also, we have to make sure that all the following DLLs are included in the *Bin* directory of the website.

SOCore.dll
SoDateBase.dll
SuperOffice.Plugins.dll
SuperOffice.Services.dll - Web Service internal interface declarations
SuperOffice.Services.Implementation.dll - the business logic implementation
SuperOffice.Services.Wcf.dll - The WCF interface declarations
SuperOffice.Services.WcfService.dll - The WCF web service logic - calls the SuperOffice.Services.dll
SuperOffice.Web.Globalization.dll - Translation utilities
ICSharpCode.SharpZipLib.dll

You will also need the SVC files:

* SoPrincipal.svc
* Contact.svc
* Find.svc
* Person.svc
* User.svc
* ...

In CRM 7 the secret is not used anymore. Instead, you must acquire a ticket from an authentication web service first. The ticket is what you send in the header instead of the secret.

The Service `WcfSoPrincipalService` is responsible for carrying out authentication.

`AuthenticateImplicit` tries to authenticate with whatever information possible. This information is most likely to be an Active Directory user.

`AuthenticateUsernamePassword` authenticates using a username and password. This can be a username and password of a domain user.

A successful response to Authentication is a Ticket that is passed in the Soap header of the subsequent requests.

It is required that the web services are hosted on a machine that is a member of the Active Directory to support Active Directory Integration.

```csharp
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
```

> [!NOTE]
> The parameter order is different from the internal service API - since we are using unwrapped calls here. If we ask Visual Studio to use Data contracts when generating the proxy, then we get the wrapped style of API.

Having multiple services that share the same carrier objects is a scenario that is not well supported in Visual Studio. For help, see: [Proxy Code Generation in Visual Studio][1]

<!-- Referenced links -->
[1]: http://www.hightech.ir/SeeSharp/Proxy-Code-Generation-In-Visual-Studio