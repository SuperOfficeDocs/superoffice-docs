---
# Mandatory fields.
title: get_person_ipersonagent       # (Required) Very important for SEO.
description: Retrieving list of persons with IPersonAgent  # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 06.24.2016
keywords: api-serices, ipersonagent
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Retrieving list of persons with IPersonAgent

You can retrieve a `Person` list is with the `GetPersonList` method available through the `PersonAgent`. To use this service, we must know the IDs of the people we want before we can make the call. If we do not know the ID, we need to use a different service, for example, a method like `GetPersonsFromContact`.

[!code-csharp[CS](includes/getpersonlist-ipersonagent.cs)]

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

Another option is to use the [ContactAgent][1]

<!-- Referenced links -->
[1]: get-persons-icontactagent.md
