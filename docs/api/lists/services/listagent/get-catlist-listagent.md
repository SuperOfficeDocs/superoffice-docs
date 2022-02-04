---
title: Get a CategoryList using the ListAgent
uid: get_category_list_listagent
description: Get a CategoryList through ListAgent
author: {github-id}
so.date: 
keywords: category,list agent
so.topic: howto
# so.envir:
# so.client:
---

# Get a CategoryList using the ListAgent

[!code-csharp[CS](includes/get-catlist-listagent.cs)]

Here we have used the ListAgent to retrieve the category list. `ListAgent` offers specific methods to retrieve the lists that have been exposed by the NetServer. It returns an array of Category objects rather than general MDOListItems. However, the Category objects have no means of grouping the items into headings. It is always just a simple list of items.
