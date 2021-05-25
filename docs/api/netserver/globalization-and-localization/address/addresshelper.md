---
title: AddressHelper class
uid: globalization_addresshelper
description: AddressHelper class 
author: Tony Yates
so-date: 05.15.2017
keywords: globalization
so.topic: reference
# so.envir:
# so.client:
---

# AddressHelper class

Each of the extension methods to [set LocalizedAddress][1] depends on a helper class called `AddressHelper`. The sole purpose of this class is to make it easy to get an Address as a Dictionary and transform a Dictionary into an Address.

[!code-csharp[CS](includes/addresshelper.cs)]

<!-- Referenced links -->
[1]: set-localized-address.md
