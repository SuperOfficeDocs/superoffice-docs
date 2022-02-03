---
title: lists      
description: Lists (SoListProviders)
author: {github-id}
so.date: 05.11.2016
keywords:
so.topic: concept
---

# Lists

This section will focus on the many lists that the NetServer provides to make our lives easy. Here we will discuss: what these lists are, how we can use them, the most important list interfaces, and finally some examples of how we can use these lists.

## Why use a list

When developing applications, it is necessary to provide lists so that the users can be allowed to select items with ease.

In NetServer a list is a set of data presented as an object that can be directly bound to any control which supports lists. The advantage is that we do not have to construct the list, all we have to do is call a NetServer method, and then we can get the list made exactly the way it is wanted. This saves us a lot of time and we don’t have to do the complex things that involve building up a list like this all by ourselves.

## Options

* Data layer: [SoListProviders][1]
* Services layer: [IListAgent][2] and [IMDOAgent][3]

<!-- Referenced links -->
[1]: entity/index.md
[2]: services/listagent/ilistagent.md
[3]: services/mdoagent/imdoagent.md
