---
uid: localization-culturesettinghelper
title: Culture Helper
description: CultureSettingHelper class
keywords: CultureSettingHelper
author: SuperOffice Product and Engineering
date: 10.09.2025
content_type: concept
category: localization
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from: /en/globalization-and-localization/culture/culturesettinghelper
language: en
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
