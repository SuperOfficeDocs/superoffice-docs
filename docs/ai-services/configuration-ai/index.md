---
title: SuperOffice AI Services - categorization
description: SuperOffice AI Services - categorization
author: AnthonyYates             # Your GitHub alias.
keywords: AI
so.topic: concept

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
so.client: online                # online, web, win, pocket, or mobile
---

# Categorization

Categorization uses Machine learning for learning **which category a request in SuperOffice Service should have**, to automate more of the manual processing our users spend time on today.

For the system to form an opinion on/learn how to automatically categorize between the selected categories the system needs to be trained. This trains the system into understanding how to categorize the selected request.

When the machine has learned how to categorize and the user navigates to a request, there will be a link in the request footer with the text: Suggested category: "category/name". When the user clicks the link, the request will be updated with the suggested category, and the suggestion link disappears.

![x][img1]

If you meet the [pre-requisites for SuperOffice AI Service][1] you can [configure SuperOffice and start training the system][2].

<!-- Referenced links -->
[1]: ../index.md
[2]: getting-started.md

<!-- Referenced image -->
[img1]: media/suggested-category-demo.png
