---
title: sentry_in_services       
description: Sentry in services
author: {github-id}             # Your GitHub alias.
so.date:
keywords: sentry
so.topic: concept
so.area: api-services
---

# Sentry in services

In the following code, we are using the sentry mechanisms that are provided in NetServer services.

```csharp
using SuperOffice;
using SuperOffice.CRM.Services;

using (SoSession mySession = SoSession.Authenticate("sal0", ""))
{
  //get the contact agent
  using(ContactAgent contactAgent = new ContactAgent())
  {
    //retrieve the entity you want
    ContactEntity myEntity = contactAgent.GetContactEntity(4);

    //check to see the logged-in user have rights to the field that you are about to modify
    if (myEntity.FieldProperties["department"].FieldRight.IsActive)
    {
      //change the department
      myEntity.Department = "Sales";

      //save the entity
      contactAgent.SaveContactEntity(myEntity);
    }
  }
}
```

In the NetServer service layer, the sentry information is provided in 2 properties:

* [FieldProperties][1]
* [TableRight][2]

<!-- Referenced links -->
[1]: fieldproperties.md
[2]: tableright.md
