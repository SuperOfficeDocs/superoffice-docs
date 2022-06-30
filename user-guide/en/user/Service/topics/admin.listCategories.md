---
uid: help-en-admin-listcategories
title: admin listCategories
description: admin listCategories
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# Categories

> [!TIP]
> Looking for a more flexible way of organizing your request? Try [using tags in requests](ticket.tags.md).

All requests belong to a category, and each category has its own rules that define how requests are processed in the system. Typically, the higher-level categories will correspond to the organisation's departments, while subcategories will correspond to areas of responsibility and/or logical structures within a department. Subcategories could also be the products that the company sells. An example might be to have the main categories of User Support, Development, Sales and Invoicing - and subcategories in these for each of the products that are sold.

**Disambiguation:** The term "category" is also used for company categories, which are created and maintained in SuperOffice Settings and maintenance.

[!include[Restricted access](../../../includes/note-insufficient-rights.md)]

Users can be added as members in the categories individually or via the user group(s) they belong to (see [User groups](admin.listUsers.listUsergroups.md)).

Selecting ![icon](../media/globalmenu-settings-small.png)**System settings** &gt; **Categories** takes you to a list of all the categories defined in the system. The categories are arranged in a tree structure.

<!-- Fix reuse ID=a2 -->

To give each department in your company a custom layout for their correspondence, you can create reply templates with different layouts. Each reply template can be linked to a category representing a department. All outgoing replies from the categories (departments) will be merged with the department specific design.

Apart from the layout/formatting of the reply template, it must contain the following template variables to be able to merge with the reply:

\[\[IF:message.bodyHtml!=""\]\]

\[\[message.bodyHtml\]\]

\[\[ELSE\]\]

\[\[message.body\]\]

\[\[ENDIF\]\]

See also [Reply templates on Categories in Service... what is that?][1]

## What would you like to do now?

[Create categories](admin.listCategories.newCategory.md)

[Delete categories](admin.listCategories.deleteCategory.md)

[Search for requests in categories](admin.listCategories.searchTickets.md)

[How to set up Get next request in queue](Get-next-request-in-the-queue.md)

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/Technical/Blog/reply-templates-on-categories-in-service-what-is-that/

<!-- Referenced images -->
