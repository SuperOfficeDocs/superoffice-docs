---
# Mandatory fields.
title: globalization_addresshelper       # (Required) Very important for SEO.
description: AddressHelper class # (Required) Important for SEO. 
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so.topic: reference # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# AddressHelper class

Each of the extension methods depends on a helper class called `AddressHelper`. The sole purpose of this class is to make it easy to get an Address as a Dictionary and transform a Dictionary into an Address.

[!code-csharp[CS](includes/addresshelper.cs)]
