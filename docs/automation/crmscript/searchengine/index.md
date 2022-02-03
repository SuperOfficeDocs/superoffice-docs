---
uid: crmscript_search_engine
title: SearchEngine
author:
so.date:
keywords:
so.topic:
---

# SearchEngine

## An in-depth guide to the CRMScript SearchEngine

The SearchEngine is a tool for building SQL queries by adding fields, criteria, and data.

It was initially created for searching and fetching data from the database. Thereby its name. Since then, it has been extended with features for inserting and updating rows.

When you [construct a query][1], the SearchEngine automatically joins tables using [dot-syntax][2] - for example `ticket.title`.

All queries are sent to NetServer instead of directly to the database. This ensures that sentry rules are followed. It is possible to circumvent this behavior, but if you do, you need to handle any security implications yourself.

> [!NOTE]
> Udefs and interests are not available through SearchEngine! You need to access these through NetServer entities.<br>If SearchEngine is your only option or you need to be able to profile these fields, they could be synchronized to an extra field with a regular task.

## In this section

1. autolist

<!-- Referenced links -->
[1]: se-select.md
[2]: dot-syntax.md
