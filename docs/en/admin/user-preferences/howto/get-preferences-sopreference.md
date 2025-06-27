---
title: Get preferences
uid: get-preferences-datalayer
description: How to get preferences using SoPreferene at the data layer
author: Bergfrid Dias
date: 02.22.2022
keywords: preference, SoPreference
content_type: howto
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
[1]: ../../../api/caching/index.md
[2]: set-preferences-sopreference.md

<!-- Referenced images -->
