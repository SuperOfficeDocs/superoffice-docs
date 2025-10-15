---
uid: help-en-ai-categorization
title: Categorization
description: Overview of AI-based request categorization in SuperOffice
keywords: AI, machine learning, request automation
author: digitaldiina
date: 10.15.2025
version: 11.5
content_type: concept
license: aiplatform, categorization
category: automation
topic: ai
deployment: online
platform: web
audience: person
audience_tooltip: SuperOffice CRM
language: en
redirect_from: /en/ai/configuration-ai/index
---

# Categorization

Categorization uses artificial intelligence (AI) to automatically suggest a category for incoming requests based on the message content. This helps support teams reduce manual work and categorize requests faster and more consistently.

If the feature is active, a suggested category appears in the footer of the request. Request handlers can click the suggestion link to update the request with the proposed category. Once applied, the suggestion disappears.

This feature uses machine learning, which means the [system must be trained][1] before it can provide accurate suggestions.

![Suggested category in a request -screenshot][img1]

> [!NOTE]
> Categorization requires the SuperOffice AI Platform and a **Categorization license**. SuperOffice AI is cloud only and available as a separate add-on.

## Related content

* [Set up AI-based categorization][1]
* [Request management][2]
* [Request categories][3]

<!-- Referenced links -->
[1]: ../admin/set-up-categorization.md
[2]: ../../request/learn/index.md
[3]: ../../request/admin/category/index.md

<!-- Referenced image -->
[img1]: ../../../media/loc/en/ai/suggested-category-demo.png
