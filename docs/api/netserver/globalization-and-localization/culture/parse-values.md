---
# Mandatory fields.
title: parse_input_to_ns_format       # (Required) Very important for SEO.
description: How to parse values to NetServer format # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so.topic: howto               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Parse values to NetServer format

When a user enters a value, it needs to be converted into a formatted value before being sent back to the web service for processing. This conversion needs to happen on the client, where we know the localization settings (the current culture).

If the user types in *1234,5* (a Norwegian floating-point value), we need to turn this into a floating-point value.

```csharp
using SuperOffice.CRM.Globalization;

string encoded = "1234,5";
double theNumber;
Double.TryParse(out encoded);
string formatted = CultureDataFormatter.EncodeDouble( theNumber );
// formatted = "[D:1234.5]" 
```
