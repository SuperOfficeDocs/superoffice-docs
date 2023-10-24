---
title: SAINT
uid: saint
description: Sales intelligence SAINT
author: Bergfrid Dias
so.date: 06.09.2023
keywords: sale, saint, counter, statusvalue, countervalue
so.topic: concept
# so.envir:
# so.client:
---

# SAINT

SAINT **counters** are used to keep track of certain actions. For example who owns a company, when were they last contacted, when is the next time we are supposed to contact them, what is the last sale date, and when was did the last activity occur.

SAINT counters are stored in the [countervalue][3] table and updated automatically as you do things:

* When SAINT is enabled, whenever a contact or a project is created, a bunch of counter rows are created.
* Whenever an follow-up, document, or sale is created, then the corresponding counter rows are updated.

SAINT **values** are simple binary values (on or off) that determine the look and feel of the company and project cards. These values are stored in the [statusvalue][1] table.

[!include[ALT](includes/note-req-saint.md)]

<!-- Referenced links -->
[1]: ../../database/tables/statusvalue.md
[3]: ../../database/tables/countervalue.md

<!-- Referenced images -->