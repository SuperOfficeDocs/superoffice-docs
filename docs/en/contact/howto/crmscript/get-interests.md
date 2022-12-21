---
uid: crmscript-get-personinterests
title: List interests for a person
description: How to list interests for a person with CRMScript.
author: Bergfrid Skaara Dias
so.date: 15.02.2021
keywords: interest, customer, person, contact
so.topic: howto
---

# List interests for a person

```crmscript!
Void viewPersonInterests(Integer personId) {
  NSPersonAgent personAgent;
  NSPersonEntity p = personAgent.GetPersonEntity(personId);

  NSSelectableMDOListItem[] interests = p.GetInterests();

  for (Integer i = 0; i < interests.length(); i++) {
    printLine(interests[i].GetName());
  }
}

viewPersonInterests(5);
```

> [!TIP]
> To print only the selected interests, add a condition: `if (interests[i].GetSelected())`.

<!-- Referenced links -->
