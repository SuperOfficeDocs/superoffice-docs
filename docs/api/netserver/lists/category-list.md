---
title: CategoryList
uid: category_list
description: Category list
author: {github-id}
keywords:
so.topic: concept
---

# CategoryList

The category list is used to classify a contact. The `Contact.Category_id` refers to an item on this list.

There are several methods of getting a category list:

* [Raw SQL][7]
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
[1]: entity/get-catlist-typed-provider.md
[2]: entity/get-catlist-generic-provider.md
[3]: osql/get-catlist-sodatareader.md
[4]: row/get-catlist-categoryrows.md
[5]: services/listagent/get-catlist-listagent.md
[6]: services/mdoagent/get-catlist-mdoagent.md
[7]: sql/get-catlist-sql.md
