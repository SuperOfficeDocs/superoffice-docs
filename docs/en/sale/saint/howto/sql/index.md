---
title: SAINT - raw SQL
uid: saint-howto-sql
description: Working with SAINT in raw SQL.
author: Bergfrid Skaara Dias
so.date: 06.09.2023
keywords: sale, SAINT, counter, API, SQL, statusvalue, countervalue
so.topic: concept
---

# SAINT - raw SQL

[!include[ALT](../../includes/note-req-saint.md)]

When SAINT is enabled, whenever a contact or project is created, a set of rows are added to the `countervalue` table. There is always a row in the `countervalue` table corresponding to follow-up, document, or sale. The respective counter rows in the `countervalue` table will be updated whenever a follow-up, document, or sale is created.

## SAINT counters

When a sale is created, it is saved with sale status = 1 (open). This updates the `CounterValue` for the `contact_id` in the sale with `saleStatus` = 1 and `saleStatus` = 4 (all).

Sales are grouped into amount classes, depending on the value (in the base currency) of the sale. Assume the sale falls into amount-class 2. We would then have to update the four counter values that correspond to this query:

```SQL
SELECT * FROM countervalue WHERE project_id = 56 AND sale_status in (1,4) AND amountclassid in (2,0)
```

| CounterValue_id | contact_id | person_id | project_id | sale_status | amountClassId | ... |
|---|---|---|---|---|---|---|
| 40265 | 0 | 0 | 56 | 1 | 2 | |
| 40268 | 0 | 0 | 56 | 1 | 0 | |
| 40280 | 0 | 0 | 56 | 4 | 2 | |
| 40283 | 0 | 0 | 56 | 4 | 0 | |

 The counter values themselves are stored in:

* totalReg
* totalRegInPeriod
* notCompleted
* notCompletedInPeriod
* ...

Here is a larger extraction for the same project, but now also with `sale_status` 2 (sold) and `amountclass` 1 (small)

```SQL
SELECT * FROM countervalue where project_id =47 and sale_status in (1,2,4) and amountclassid in (2,1,0)
```

## SAINT values

Values are much easier than counters. They are simple binary values - either on or off.

To find all the SAINT values for a particular contact or project, simply search the `StatusValue` table:

```SQL
Select * from statusvalue where contact_id =89
```

| StatusValue_id | StatusDef_id | contact_id | person_id | project_id | isSignalled | needsUpdate | registered |
|---|---|---|---|---|---|---|---|
| 3694 | 1 | 89 | 0 | 0 | 1 | 1 | 2021-11-05 15:54:10 |
| 3693 | 7 | 89 | 0 | 0 | 1 | 1 | 2021-11-05 15:54:10 |

The `isSignalled` field determines whether to display an image in the background of the contact card or not. The image that is shown on the contact card is determined by the status definition - and the blob linked to this record.

According to the `StatusDef_id` in the `statusvalue` table, the [statusdef][2] table is referred and the background image in the contact card varies accordingly.

```SQL
Select * from statusdef where statusdef_id = 7
```

| StatusDef_id | isVisual | needsUpdate | rank | deleted | ownerTable | lastGenerated | ... |
|---|---|---|---|---|---|---|---|
| 7 | 1 | 0 | 1 | 0 | 5 | 2021-11-05 15:54:10 | |

`isVisual` indicates that a picture is used to mark that the status is active. The actual picture is found via the blob link table.

## Available example queries

* [Get contact by saint value][1]
* [Search SAINT values][2]

<!-- Referenced links -->
[1]: get-contact-by-saint-value.md
[2]: search-saint-values.md
