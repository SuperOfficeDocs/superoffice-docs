---
# Mandatory fields.
title: globalization_addresshelper       # (Required) Very important for SEO.
description: AddressHelper class # (Required) Important for SEO. 
author: Tony Yates
so-date: 05.15.2017
keywords: globalization
so.topic: reference # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# AddressHelper class

Each of the extension methods to [set LocalizedAddress][1] depends on a helper class called `AddressHelper`. The sole purpose of this class is to make it easy to get an Address as a Dictionary and transform a Dictionary into an Address.

[!code-csharp[CS](includes/addresshelper.cs)]

<!-- Referenced links -->
[1]: set-localized-address.md
