---
title: SAINT
uid: saint
description: Sales intelligence SAINT
author: Bergfrid Dias
so.date: 11.05.2021
keywords: sale, saint, statusvalue, countervalue
so.topic: concept
# so.envir:
# so.client:
---

# SAINT

SAINT **values** are stored in the [statusvalue][1] table. They are simple binary values in either on or off state. These values determine the look and feel of the company and project cards.

The `isSignalled` field determines whether to display an image in the background of the contact card or not. The image displayed in the contact card is defined in the [statusdef][2] table. According to the `StatusDef_id` in the `statusvalue` table, the `statusdef` table is referred and the background image in the contact card varies accordingly. The actual image is found via the blob link table.

SAINT **counters** are used to keep track of certain actions. For example who owns a company, when were they last contacted, when is the next time we are supposed to contact them, what is the last sale date, and when was did the last activity occur.

The [countervalue][3] table maintains SAINT counters. When SAINT is enabled, whenever a contact or project is created, a set of rows are added to the `countervalue` table.

There is always a row in the `countervalue` table corresponding to appointment, document, or sale. The respective counter rows in the `countervalue` table will be updated whenever an appointment, document, or sale is created.

> [!NOTE]
> To use SAINT, a separate license should be obtained. It also requires that the administrator has defined one or more SAINT statuses and generated SAINT status values on the database.

## More information

* [SAINT values][4]
* [SAINT counters][5]

<!-- Referenced links -->
[1]: ../../../../database/docs/tables/statusvalue.md
[2]: ../../../../database/docs/tables/statusdef.md
[3]: ../../../../database/docs/tables/countervalue.md
[4]: values.md
[5]: counters.md

<!-- Referenced images -->