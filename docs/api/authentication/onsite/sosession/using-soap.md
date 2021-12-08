---
title: Authentication and SOAP calls
uid: auth_and_soap_calls
description: Authentication and SOAP calls
 Bergfrid Dias
so.date: 11.22.2021
keywords: authentication, SOAP, SoSession, WcfSoPrincipalService, SoCredentials
so.topic: concept
so.envir: onsite
# so.client: 
---

# Authentication and SOAP calls

SOAP is a simple XML-based protocol used to let applications exchange information over HTTP. In SuperOffice we can access the web services using SOAP calls.

To authenticate, you must acquire a ticket from an authentication web service first. The ticket is what you send in the header.

> [!NOTE]
> In version 6, authentication was done using a special secret hash that was calculated and sent on each request. The secret is not used anymore.

The Service `WcfSoPrincipalService` is responsible for carrying out authentication.

`AuthenticateImplicit` tries to authenticate with whatever information possible. This information is most likely to be an Active Directory user.

`AuthenticateUsernamePassword` authenticates using a username and password. This can be a username and password of a domain user.

A successful response to Authentication is a ticket that is passed in the SOAP header of the subsequent requests.

It is required that the web services are hosted on a machine that is a member of the Active Directory to support Active Directory Integration.

It is required that Active Directory credentials are passed along a request to `AuthenticateImplicit` to support Integrated Authentication. This means you need to enable ASP.net impersonation in IIS:

* Either use classic pipeline mode
* Or disable Integrated pipeline mode validation:

```XML
<system.webServer>
   <validation validateIntegatedModeConfiguration="false" />
```

## Methods on an agent correspond to SOAP calls

A simple agent call and the resulting SOAP message that the client sends to the server:

```csharp
using SuperOffice.CRM.Services;

using (SoSession mySession = SoSession.Authenticate("SAL0", "SAL0"))
{
  using(ContactAgent contactAgent = new ContactAgent())
  {
    Contact aContact = contactAgent.GetContact(5);
  }
}
```

[!code-xml[XML](includes/soap-env.xml)]

To authenticate SOAP calls against the NetServer backend, a special SOAP header must be used, and a special value sent back. This is to avoid sending the password directly to the server.

The encrypted value of the password is sent to the server. Once the request is received by the server, it matches the encrypted value contained in the request with the encrypted value in the server if both match then the password is correct. This provides a secure means of providing passwords without actually sending the password across the network.

An [agent][1] contains a set of methods corresponding to SOAP calls. These methods determine the properties of the `SoCredentials` header.

### Behind the scenes

What will happen behind the scene is the Proxy DLL will generate the SOAP header using the credentials and makes the SOAP call.

This is the recommended calling pattern. The `Session` object is scoped with `using()` so that it is automatically closed at the end of the scope.

You can use `SoSession.Suspend` and `Continue` to avoid authenticating all the time.

<!-- Referenced links -->
[1]: ../../../netserver/web-services/index.md#agents
