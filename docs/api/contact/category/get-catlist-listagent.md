---
# Mandatory fields.
title: get_category_list_listagent       # (Required) Very important for SEO.
description: Get a CategoryList through ListAgent  # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 
keywords: category,list agent
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Get a CategoryList using the ListAgent

[!code-csharp[CS](includes/get-catlist-listagent.cs)]

Here we have used the ListAgent to retrieve the category list. `ListAgent` offers specific methods to retrieve the lists that have been exposed by the NetServer. It returns an array of Category objects rather than general MDOListItems. However, the Category objects have no means of grouping the items into headings. It is always just a simple list of items.
