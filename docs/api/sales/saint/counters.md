---
title: Counters
uid: saint_counters
description: SAINT counters
author: {github-id}
keywords:
so.topic: concept
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# SAINT counters

SAINT counters are updated automatically as you do things.

* When SAINT is enabled, whenever a contact or a project is created, a bunch of counter rows are created.
* Whenever an appointment, document, or sale is created, then the corresponding counter rows are updated.

## Example

When a sale is created, it is saved with sale status = 1 (open)

This updates the `CounterValue` for the `contact_id` in the sale with `saleStatus` = 1 and `saleStatus` = 4 (all).

Sales are grouped into amount-classes, depending on the value (in the base currency) of the sale.

Assume the sale falls into amount-class 2.

We would then have to update the four counter values that correspond to this query:

```SQL
SELECT * FROM countervalue WHERE project_id = 56 AND sale_status in (1,4) AND amountclassid in (2,0)
```

![x][img1]

 The counter values themselves are stored in:

* totalReg
* totalRegInPeriod
* notCompleted
* notCompletedInPeriod
* ...

![x][img2]

The `lastRegistered` and `lastDoBy` values are all equal because these match the sale we just registered on this contact.

Here is a larger extraction for the same project, but now also with `sale_status` 2 (sold) and `amountclass` 1 (small)

```SQL
SELECT * FROM countervalue where project_id =47 and sale_status in (1,2,4) and amountclassid in (2,1,0)
```

![x][img3]

## See also

* [countervalue table][1]
* [statusvalue table][2]
* [statusdef table][3]

<!-- Referenced links -->
[1]: ../../../../database/docs/tables/countervalue.md
[2]: ../../../../database/docs/tables/statusvalue.md
[3]: ../../../../database/docs/tables/statusdef.md

<!-- Referenced images -->
[img1]: media/countervalue-table.png
[img2]: media/countervalue-values.png
[img3]: media/countervalues-more.png
