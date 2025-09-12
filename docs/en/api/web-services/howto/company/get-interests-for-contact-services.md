---
uid: list-contact-interests-ws
title: How to list all selected interests
description: How to list all selected interests for a contact using services
keywords: contact, company, services, API, interest, ContactAgent, SelectableMDOListItem
author: Tony Yates
date: 11.04.2021
content_type: howto
redirect_from:
  - /en/company/howto/services/get-interests-for-contact-services
  - /en/api/netserver/web-services/howto/company/get-interests-for-contact-services
---

# How to list all selected interests for a contact (services)

You can use  `SuperOffice.Services` and `SuperOffice.Services.Impl` DLLs to list all selected [interests][1] for a specific contact.

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
      //Retrieve only the selected Interest of the Contact
      if(newSelMdoLstItm.Selected)
        Console.WriteLine(newSelMdoLstItm.Name);
    }

  Console.ReadLine();
}
```

## Walk-through

Using the `ContactAgent`, we first retrieve a `Contact` entity. Next is to retrieve the available interests of the contact. We use the `Interests` property of the entity and retrieve the interest list into a `SelectableMDOListItem` array.

By iterating on the array, we can retrieve details of each interest available. Since we want only the *selected* interest, we add an if-condition to filter out any item that is not selected.

Comparing the **Interest** tab of the **Company** card in the SuperOffice and our obtained output we can confirm our results.

<!-- Referenced links -->
[1]: ../../../../company/dev/index.md#interests
