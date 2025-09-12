---
uid: toggle-contact-interest-ws
title: How to set an interest on or off
description: How to set an interest on or off for a contact using services
keywords: contact, company, services, API, interest, ContactAgent, electableMDOListItem
author: Tony Yates
date: 11.04.2021
content_type: howto
redirect_from:
  - /en/company/howto/services/set-interest-on-off-services
  - /en/api/netserver/web-services/howto/company/set-interest-on-off-services
---

# How to set an interest on or off for a contact (services)

You can use web services to alter the selected status of an [interest][1] of a specific contact.

## Code

```csharp
using SuperOffice;
using SuperOffice.CRM.Services;

Console.Write("Please Enter the UserName :- ");
string userName = Console.ReadLine();

Console.Write("Please enter the password :- ");
string passWord = Console.ReadLine();
Console.WriteLine();

using (SoSession newSession = SoSession.Authenticate(userName, passWord))
{
  //Retrieve a Contact Entity using the Contact Agent
  ContactAgent newConAgt = new ContactAgent();
  ContactEntity newConEnt = newConAgt.GetContactEntity(10);

  //Retrieve all available Interests for a Contact
  SelectableMDOListItem[] newSelMdoLstItms = newConEnt.Interests;

  foreach(SelectableMDOListItem newSelMdoLstItm in newSelMdoLstItms)
  {
    //Changing the Selected status and displaying only the selected items
    if (newSelMdoLstItm.Selected)
      newSelMdoLstItm.Selected = false;
    else
    {
      newSelMdoLstItm.Selected = true;
      Console.WriteLine(newSelMdoLstItm.Name);
    }
  }

  Console.ReadLine();

  //Save the modified Contact Entity
  newConAgt.SaveContactEntity(newConEnt);
}
```

## Walk-through

We have first retrieved a `Contact` entity using the `ContactAgent`. And then used its `Interests` property to retrieve the contact’s interests into a `SelectableMDOListItem` array.

Next, we iterate on the array and change its Boolean `Selected` property status. By using the `SaveContactEntity` method available in the `Contact` agent, we save the modifications made to the entity.

<!-- Referenced links -->
[1]: ../../../../company/dev/index.md#interests
