---
uid: display-in-current-culture
title: Display values in current culture
description: How to display values in current culture
keywords: CultureDataFormatter, localize, current culture
author: SuperOffice Product and Engineering
date: 10.09.2025
content_type: howto
category: localization
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from: /en/globalization-and-localization/culture/display-in-current-culture
language: en
---

# Display values in current culture

The [CultureDataFormatter][1] handles conversion to and from the neutral format. This class is strictly not part of the DCF, since it lives in the `SoCore` assembly.

```csharp
using SuperOffice.CRM.Globalization;

string encoded = "[I:12345]";
string localized = CultureDataFormatter.LocalizeEncoded( encoded );
// localized = "12345"
```

Floating point:

```csharp
using SuperOffice.CRM.Globalization;

string encoded = "[D:1234.5]";
string localized = CultureDataFormatter.LocalizeEncoded( encoded );
// localized = "1234,5" 
```

<!-- Referenced links -->
[1]: culturedataformatter.md
