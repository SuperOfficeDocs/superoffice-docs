---
uid: get-person-ipersonagent
title: Retrieving list of persons with PersonAgent
description: How to retrieve a list of persons with PersonAgent.
keywords: person, contact, services, API, api-services, PersonAgent, GetPersonList
author: Bergfrid Skaara Dias
date: 11.04.2021
content_type: howto
redirect_from:
  - /en/contact/howto/services/get-persons-personagent
  - /en/api/netserver/web-services/howto/contact/get-persons-personagent
---

# Retrieving list of persons with PersonAgent

You can retrieve a `Person` list is with the `GetPersonList` method available through the `PersonAgent`. To use this service, we must know the IDs of the people we want before we can make the call. If we do not know the ID, we need to use a different service, for example, a method like `GetPersonsFromContact`.

```csharp
using SuperOffice;
using SuperOffice.CRM.Services;

using(SoSession newSession = SoSession.Authenticate("sam", "sam"))
{
  //Instantiating the Person Agent
  using(PersonAgent newPerAgt = new PersonAgent())
  { 
    //Local variable Declaration
    int [] personIds = {100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110};

    //Retrieving a List of Persons
    Person[] newPersonArr = newPerAgt.GetPersonList(personIds);

    Console.WriteLine("Full Name" + "\t" + "ContactName" + "\t" + "Email");

    //Retrieving Properties of Person in the Person list
    foreach (Person newPerson in newPersonArr)
    {
      Console.Write(newPerson.Firstname + " " + newPerson.Lastname + "\t");
      Console.Write(newPerson.ContactName + "\t");
      Console.Write(newPerson.Email);
      Console.WriteLine();
    }
  }
}
```

A list of `PersonIds` is passed into the `GetPersonList` method, which returns an array of `Person` data types. Once the values have been assigned to a Person type array, we may access the properties of each person by looping through the array elements.

**Output:**

```text
Full Name         ContactName                  Email
Unni Ukultsted    Uri Geller International     example@example.com
Veronika Viseth   Vertigo AS                   example@example.com
Vebjørn Valstad   Vin & Sprit AB                example@example.com
Werner Wigseth    Warner Brothers Norway        example@example.com
Wenche Wilson     Werner & Werner               example@example.com
Ulf Ulstein       Uniformeffekter AS            example@example.com
Ulster Undervold  Uri Geller International     example@example.com
Vilde Veum        Vertigo AS                    example@example.com
Varg Vigernes     Vin & Sprit AB                example@example.com
Waldorf Weem      Warner Brothers Norway        example@example.com
Wilma Wetter      Werner & Werner               example@example.com
```

We could also have used the Person agent’s `GetPersonsFromContact` method since we are just reading some simple properties out of the results. `GetPersonsFromContact` returns simple read-only carriers.

Another option is to use the [ContactAgent][1].

<!-- Referenced links -->
[1]: get-persons-contactagent.md
