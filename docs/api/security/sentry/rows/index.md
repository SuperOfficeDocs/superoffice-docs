---
title: Sentry
uid: rows_and_sentry
description: SuperOffice database Using Sentry with rows
author: {github-id}
so.date: 11.05.2016
keywords: netserver, security, sentry, rows
so.topic: concept
---

# Sentry

Sentry is automatically applied to rows as well as entities.

* Attempting to modify a read-only object will throw an exception.
* Attempting to read a hidden property will return a blank value - reading will **not** throw exceptions.

```csharp
  using SuperOffice;
  using SuperOffice.CRM.Rows;
  string lastname = "Hansen";
  PersonRows persons = PersonRows.GetFromIdxLastname(lastname);

// modifications will fail. Anon user will not be allowed
  foreach(PersonRow person in persons)
  {
    person.DayOfBirth = 0; // throws exception!
    person.MonthOfBirth = 0;
    person.YearOfBirth = 0;
    person.Save();
  }
```

See Also: PersonRow SuperOffice.Exceptions.SoSentryException
