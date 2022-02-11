---
title: Get a CategoryList through typed list providers
uid: get_category_list_typed_provider
description: Get a CategoryList through typed list providers
author: {github-id}
so.date: 05.11.2016
keywords: category,list provider
so.topic: howto
# so.envir:
# so.client:
---

# Get a CategoryList through typed list providers

In the `SoList` class, there are specific methods to create different types of list providers. Hence there is a method specialized in creating `CategoryList` providers too.

The following example shows how to get a category list using [typed list providers][1].

[!code-csharp[CS](includes/get-catlist-typed.cs)]

By using the `CategoryList` method defined in the `SoList` class you can obtain a `CategoryList` provider.

There are 3 different items present in the `CategoryList` provider: HeadingItems, HistoryItems, and RootItems. Each of these items contains its own properties and in this example, we have used only the `Id` and the `Name` properties.

The `HistoryItems` are defined in the `history` table with its `table_Id` field referring to the conceptual table ID of the `category` table. Unless the MDO mode of the `Contact` list is turned on, no record will be added to the `history` table.

The `RootItems` are defined by the records in the `category` table only if the MDO mode is set to false. If the MDO mode is set to true then the `RootItems` contain only the items that have not been assigned to any Heading. Normally all the HeadingItems are taken directly from the `heading` table.

**Output of the example:**

![01 -screenshot][img1]

<!-- Referenced links -->
[1]: typed-list.md

<!-- Referenced images -->
[img1]: media/image002.jpg
