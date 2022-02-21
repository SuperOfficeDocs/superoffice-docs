---
title: CategoryList
uid: category_list
description: Category list
author: {github-id}
so.date: 02.21.2022
keywords: category
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
> All list objects in the NetServer services API have a common interface. They can be accessed or modified using a ListAgent or an MDOAgent. The MDO agent provides a generic mechanism for reading lists. The List agent provides a strongly types API that is simpler to program with.

Explore the options and select the most appropriate method for your application.

<!-- Referenced links -->
[1]: howto/entity/get-catlist-typed-provider.md
[2]: howto/entity/get-catlist-generic-provider.md
[3]: howto/osql/get-catlist-sodatareader.md
[4]: howto/row/get-catlist-categoryrows.md
[5]: howto/services/get-catlist-listagent.md
[6]: howto/services/get-catlist-mdoagent.md
[7]: howto/sql/get-catlist-sql.md
