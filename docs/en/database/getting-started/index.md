---
title: Getting started
uid: db_getting_started
description: Getting started with SuperOffice database
author: {github-id}
keywords:
topic: overview
---

# Getting started

This section will give you an overview of the SuperOffice Database and explain the basic elements that you need to get started.

We are now going to look at how the database is put together, and how the different tables in the database relate to the user interface. This should make it easier to understand what the components are doing for you.

## General principle

As a general principle, the SuperOffice database is very lax. There are no declared constraints on tables. Referential integrity is not enforced strictly, and the structure would make a computer science professor or system administrator shudder.

However, there is a reason for this lax design.

People are not strict or formal. A CRM system is mainly about people, what they do, and when. It is not an accounting system. It is not subject to the rigors of accounts auditing. People delete things and then want them back. People change things around and merge in partial data from external sources.

The SuperOffice database schema is intended to be flexible while being understandable and efficient.

## Reading order

* [SuperOffice view of the world][1]
* [The main tables][2]
* [Overview of tables][3]
* [Naming conventions][4]
* [Special tables][5]

<!-- Referenced links -->
[1]: so-view-of-the-world.md
[2]: main-tables.md
[3]: overview.md
[4]: naming-conventions.md
[5]: special-tables.md
