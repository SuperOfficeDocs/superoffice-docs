---
title: category       
description: Category
author: {github-id}             # Your GitHub alias.
keywords:
---

# Category

The category list is used to classify a contact. The `Contact.Category_id` refers to an item on this list.

## CategoryList

There are several methods of getting a category list:

* [Typed list providers][1]
* [Generic list providers][2]
* [SoDataReader][3]
* [CategoryRows object][4]
* [ListAgent][5]
* [MDOAgent][6]

> [!NOTE]
> All lists objects in the NetServer services API have a common interface. They can be accessed or modified using a list agent or a MDO agent. The MDO agent provides a generic mechanism for reading lists. The List agent provides a strongly types API that is simpler to program with.

Explore the options and select the most appropriate method for your application.

<!-- Referenced links -->
[1]: get-catlist-typed-provider.md
[2]: get-catlist-generic-provider.md
[3]: get-catlist-sodatareader.md
[4]: get-catlist-categoryrows.md
[5]: get-catlist-listagent.md
[6]: get-catlist-mdoagent.md
