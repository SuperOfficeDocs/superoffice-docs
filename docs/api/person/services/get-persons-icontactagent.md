---
title: Retrieving list of persons with IContactAgent
uid: get_person_icontactagent
description: How to retrieve a list of persons with IContactAgent.
author: Bergfrid Skaara Dias
so.date: 11.04.2021
keywords: person, contact, services, API, api-serices, IContactAgent, PersonAgent, GetContactWithPersons
so.topic: howto
# so.envir:
# so.client:
---

# Retrieving list of persons with IContactAgent

You can retrieve a `Person` list is with the `GetPersonList` method available through the `PersonAgent`. To use this service, we must know the IDs of the people we want before we can make the call. If we do not know the ID, we need to use a different service, for example, a method like `GetPersonsFromContact`.

[!code-csharp[CS](includes/getcontactwithpersons-icontactagent.cs)]

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
[1]: get-persons-ipersonagent.md
