---
# Mandatory fields.
title: call_service_using_ns_binaries       # (Required) Very important for SEO.
description: Calling the services directly using the NetServer binaries # (Required) Important for SEO.including spaces.
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Calling the services directly using the NetServer binaries

To call a NetServer service through the binaries first you have to add the following NetServer binaries to your application.

* SoCore.dll
* SuperOffice.Service.dll
* SuperOffice.Service.Implementation.dll

The following figure shows the added binaries in a windows application.

![01][img1]

After adding the binaries to your project references you can use the namespaces of the binaries in the using section of your code file in the following way:

```csharp
using SuperOffice.CRM.Services;

using (SoSession mySession = SoSession.Authenticate("sam", "sam"))
{
  //Instantiate the Contact Entity
  using(ContactAgent contactAgent = new ContactAgent())
  {
    //Create a Contacts Array and assign values
    Contact[] myContacts = new Contact[5];
    myContacts = contactAgent.GetMyContacts();
  }
}
```

The application’s configuration file should be like this:

```XML
<Services>
  <addkey="DefaultMode" value="Local" />
</Services>
```

The `GetContactAgent` will check the config file and return an object that lives in the *Services.Implementation.dll*. This implementation will in turn use the database directly to work out the result. In this case, there is no web-service call involved in calling the service.

This corresponds to this diagram: everything is running within the same process.

![03][img2]

<!-- Referenced images -->
[img1]: media/image001.jpg
[img2]: media/image003.gif
