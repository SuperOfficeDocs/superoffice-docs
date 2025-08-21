---
uid: get-person-contactagent
title: Retrieving list of persons with ContactAgent
description: How to retrieve a list of persons with ContactAgent.
keywords: person, contact, services, API, api-services, ContactAgent, PersonAgent, GetContactWithPersons
author: Bergfrid Skaara Dias
date: 11.04.2021
content_type: howto
redirect_from:
  - /en/contact/howto/services/get-persons-contactagent
  - /en/api/netserver/web-services/howto/contact/get-persons-contactagent
---

# Retrieving list of persons with ContactAgent

You can retrieve a `Person` list is with the `GetPersonList` method available through the `PersonAgent`. To use this service, we must know the IDs of the people we want before we can make the call. If we do not know the ID, we need to use a different service, for example, a method like `GetPersonsFromContact`.

```csharp
using SuperOffice;
using SuperOffice.CRM.Services;

using(SoSession newSession = SoSession.Authenticate("sam", "sam"))
{
  //Instantiating the Contact Agent
  using(ContactAgent newConAgt = new ContactAgent())
  {
    //Retrieving a Contact Entity with the use of the Contact Agent
    ContactEntity newConEnt = newConAgt.GetContactWithPersons(143);

    //Retriving properties of a Person from the Contact Entity
    if (newConEnt.Persons.Length > 0)
    {
      Console.WriteLine("Full Name" + "\t" + "ContactName" + "\t" + "Email");
      foreach (Person newPerson in newConEnt.Persons)
      {
        Console.WriteLine(newPerson.Firstname + " " + newPerson.Lastname + "\t");
        Console.Write(newPerson.ContactName + "\t");
        Console.Write(newPerson.Email);
        Console.WriteLine();
      }
    }
  }
}
```

After we have created an instance of the `ContactEntity` calling the `ContactAgent`’s `GetContactWithPersons` method, we can iterate through the `Person` property of the instantiated entity and retrieve its properties.

**Output:**

```text
Full Name         ContactName             Email
Admin Adminson    StateZeroDatabase       example@example.com
Arne Arnesen      StateZeroDatabase       example@example.com
Brede Bredesen    StateZeroDatabase       example@example.com
Cato Carlsson     StateZeroDatabase       example@example.com
Donald Duck       StateZeroDatabase       example@example.com
Erik Eide         StateZeroDatabase       example@example.com
```

Another option is to use the [PersonAgent][1]

<!-- Referenced links -->
[1]: get-persons-personagent.md
