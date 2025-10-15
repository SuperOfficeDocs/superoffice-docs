---
uid: get-preferences-datalayer
title: Get preferences
description: How to get preferences using SoPreferene at the data layer
keywords: preference, SoPreference
author: digitaldiina
date: 02.22.2022
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
category: settings
topic: user preferences
language: en
redirect_from: /en/admin/user-preferences/howto/get-preferences-sopreference
---

# Get the current value of a given preference

The [SetPreference method][2] has four overloads depending on the value passed (string, int, bool, or DateTime). The `SoPreference` class provides four corresponding methods to retrieve the current value of a given preference.

```csharp
using SuperOffice;
using SuperOffice.Data;
using(SoSession mySession = SoSession.Authenticate("sam", "sam"))
{
  bool value = SoPreference.GetBool("Visual", "SundayFirstDay", false);
}
```

The example above retrieves whether the calendar for the signed-in user begins with Sunday or Monday. In this case, since `GetBool()` requires 3 parameters, the default value of the key should also be passed in. The default value parameter should be passed in only when using the `GetBool` method.

See also: [intro to cache][1]

<!-- Referenced links -->
[1]: ../../../caching/index.md
[2]: set-preferences-sopreference.md

<!-- Referenced images -->