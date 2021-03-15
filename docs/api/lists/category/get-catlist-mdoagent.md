---
# Mandatory fields.
title: get_category_list_mdoagent       # (Required) Very important for SEO.
description: Get a CategoryList through the MDO Agent  # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 
keywords: category, MDO agent
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Get a CategoryList using the MDO Agent

[!code-csharp[CS](includes/get-catlist-mdoagent.cs)]

The example above shows how we can use the `GetSimpleList` method available through the `MDOAgent` to retrieve the category list.
