---
uid: crmscript-search-engine
title: SearchEngine
description: An in-depth guide to the SuperOffice CRMScript SearchEngine - a tool for building SQL queries by adding fields, criteria, and data.
keywords: CRMScript, SearchENgine, search, query
author: Bergfrid Dias
date: 04.15.2024
topic: concept
---

# SearchEngine

## An in-depth guide to the CRMScript SearchEngine

The SearchEngine is a tool for building SQL queries by adding fields, criteria, and data.

It was initially created for searching and fetching data from the database. Thereby its name. Since then, it has been extended with features for inserting and updating rows.

When you [construct a query][1], the SearchEngine automatically joins tables using [dot-syntax][2] - for example `ticket.title`.

All queries are sent to NetServer instead of directly to the database. This ensures that sentry rules are followed. It is possible to circumvent this behavior, but if you do, you need to handle any security implications yourself.

> [!NOTE]
> Udefs and interests are not available through SearchEngine! You need to access these through NetServer entities.
>
> If SearchEngine is your only option or you need to be able to profile these fields, they could be synchronized to an extra field with a regular task.

## Related content

* [Database basics][11]
* [Dot-syntax][12]
* [Building a query][13]
* [Running a query][14]
* [Exploring search results][15]
* [Insert, update, and delete][16]
* [Using the SearchEngine class (blog post)][17]

<!-- Referenced links -->
[1]: se-select.md
[2]: dot-syntax.md
[11]: db-basics.md
[12]: dot-syntax.md
[13]: se-select.md
[14]: se-run.md
[15]: se-results.md
[16]: se-insert-update-delete.md
[17]: using-the-searchengine-class-blog-post.md
