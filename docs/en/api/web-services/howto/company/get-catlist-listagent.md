---
uid: get-category-list-listagent
title: Get a CategoryList using the ListAgent
description: Get a CategoryList through ListAgent
keywords: category, list agent
author: Tony Yates
date: 02.21.2022
content_type: howto
---

# Get a CategoryList using the ListAgent

[!code-csharp[CS](includes/get-catlist-listagent.cs)]

Here we have used the ListAgent to retrieve the category list. `ListAgent` offers specific methods to retrieve the lists that have been exposed by the NetServer. It returns an array of Category objects rather than general MDOListItems. However, the Category objects have no means of grouping the items into headings. It is always just a simple list of items.
