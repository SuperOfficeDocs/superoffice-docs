---
title: Calling the web service
uid: call_ws_from_dotnet_so_tools_method
description: How to call SuperOffice web services from .Net with SuperOffice tools
author: {github-id}
so.date:
keywords:
so.topic: howto
---

# Calling the web service

This method uses the `SoSession` object from the SoCore to handle the authentication logic for us. The **secret** is calculated for us during the `Authenticate` call. The proxy objects returned by the agent factory will automatically add the SOAP authentication header for us. This makes working with the service API much simpler.

**Pre-requisite:** [update the configuration files][1]

```csharp
using SuperOffice.CRM.Services;
using SuperOffice;
using SuperOffice.Security.Principal;

//Authenticate using the SoSession class
using( SoSession mySession = SoSession.Authenticate("SAL0", "") )
{
  //get a contact agent
  using(ContactAgent myContactAgent = new ContactAgent())
  {
    //retrieve a contact entity through the agent
    ContactEntity myContactEntity = myContactAgent.GetContactEntity(4);

    //retrieve the department name
    string dept = myContactEntity.Department;
  }
}
```

What will happen behind the scene is the Proxy DLL will generate the SOAP header using the credentials and makes the SOAP call.

Here we can see that we have retrieved a `Contact` entity using the `ContactAgent`. The proxy DLL will call the `GetContactEntity` method of the Contact web service.

This is the recommended calling pattern. The `Session` object is scoped with `using()` so that it is automatically closed at the end of the scope.

You can use `SoSession.Suspend` and `Continue` to avoid authenticating all the time.

<!-- Referenced links -->
[1]: config.md
