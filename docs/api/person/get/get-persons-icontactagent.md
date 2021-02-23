---
# Mandatory fields.
title: get_person_icontactagent       # (Required) Very important for SEO.
description: Retrieving list of persons with IContactAgent  # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 06.24.2016
keywords: api-serices, icontactagent
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
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
