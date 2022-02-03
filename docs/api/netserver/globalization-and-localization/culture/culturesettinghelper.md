---
title: Culture Helper
uid: globalization_culturesettinghelper
description: CultureSettingHelper class
author: {github-id}
so.date: 05.08.2018
so.topic: concept
keywords:
---

# Culture Helper

The `CultureSettingHelper` class is used to perform tasks in a temporary culture context. It remembers the previous culture settings, executes the containing code in the set culture, then resets the culture to the previous culture when disposed.

```csharp
// Here the current culture is known
...
// set both system and UI cultures on current thread
using( new CultureSettingHelper("es-ES") )
{
  // culture-dependent processing
}
// culture has been restored
```

Multiple overloads enable more behaviors. See the [CultureSettingsHelper reference][1] for more details.

<!-- Referenced links -->
[1]: <xref:SuperOffice.Globalization.CultureSettingHelper>
