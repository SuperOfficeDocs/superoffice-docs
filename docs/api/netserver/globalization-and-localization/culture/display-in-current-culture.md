---
# Mandatory fields.
title: display_in_current_culture       # (Required) Very important for SEO.
description: How to display values in current culture # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so.topic: howto               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
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
