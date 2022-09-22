---
uid: help-en-reply-template-category
title: Create custom layout for replies using categories
description: Create custom layout for replies using categories
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# Create custom layout for replies using categories

To give each department in your company a custom layout for their correspondence, you can create reply templates with different layouts. Each reply template can be linked to a [category][1] representing a department. All outgoing replies from the categories (departments) will be merged with the department specific design.

Apart from the layout/formatting of the reply template, it must contain the following template variables to be able to merge with the reply:

```text
[[IF:message.bodyHtml!=""]]
[[message.bodyHtml]]
[[ELSE]]
[[message.body]]
[[ENDIF]]
```

<!-- Referenced links -->
[1]: ../category/index.md
