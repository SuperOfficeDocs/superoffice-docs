---
title: Get a CategoryList through generic list providers
uid: get_category_list_generic_provider
description: Get a CategoryList through generic list providers
author: {github-id}
so.date: 05.11.2016
keywords: category,list provider
so.topic: howto
# so.envir:
# so.client:
---

# Get a CategoryList through generic list providers

[!code-csharp[CS](includes/get-catlist-generic.cs)]

By passing the correct parameters to the `Create` method of the `SoListProviderFactory`, you can create a `CategoryList`. `Create()` has 7 overloads providing a typed, customized interface for each list.

In the example above, we have passed the name of the list needed (category). The way how `RootItems`, `HeadingItems`, and `HistoryItems` are defined is consistent for all the [generic lists][1].

All `RootItems` are taken for the corresponding table, in this case, the category table. If the MDO mode of the `CategoryList` is turned on, then some records may be present in the history table corresponding to the category list so that the history list may be nonempty. Similarly, if the heading table contains records corresponding to the category list, then the `HeadingItems` of the category list will also be nonempty.

<!-- Referenced links -->
[1]: generic-list.md
