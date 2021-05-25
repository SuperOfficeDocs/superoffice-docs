---
title: Search values
uid: search_saint_values
description: Searches on Saint values
author: {github-id}
keywords:
so.topic: howto
# so.envir:
# so.client:
---

# Searches on Saint values

When SAINT is enabled, whenever a contact or a project is created, a bunch of counter rows are created.

Whenever an appointment, document, or sale is created, then the corresponding counter rows are updated.

Each `counterValue` row points to the `contact_id` or `project_id` it is linked to.  The counter values themselves are stored in the `totalReg`, `totalRegInPeriod`, `notCompleted`, `notCompletedInPeriod`, and so on fields.

Here are some of the counter values for a project:

```SQL
SELECT * FROM countervalue where project_id =47 and sale_status in (1,2,4) and amountclassid in (2,1,0)
```

![x][img1]

If we want to search on the SAINT counters, we would use the counter-value fields as criteria, and read out the `project_id` or `contact_id`.

If we wanted to find all projects where there is an open sale, in any size, and no sale has been registered in the past year:

```SQL
SELECT project_id FROM CounterValue WHERE project_id > 0 AND sale_Status = 1  AND amountClassId=0 AND lastRegistered < '2005.10.1'
```

If we only wanted to search for small sales, we would use the amount-class "small" (`amountclass_id=1`)

```SQL
SELECT project_id FROM CounterValue WHERE project_id > 0 AND sale_Status = 1  AND amountClassId=1 AND lastRegistered < '2005.10.1'
```

If we want to find all contacts with no sales registered in the period, we would search like this:

```SQL
SELECT contact_id, project_id FROM CounterValue WHERE contact_id > 0 AND sale_Status = 4  AND amountClassId=0 AND totalRegInPeriod =0
```

* Sale-status = 4  (All sales)
* amount-class = 0 (all sizes)

If we want to find all contacts with more than 5 sales registered (since the beginning of time):

```SQL
SELECT contact_id, project_id FROM CounterValue WHERE contact_id > 0 AND sale_Status = 4  AND amountClassId = 0 AND totalReg > 5
```

If we want to find all contacts with more than 4 phone-call appointments (`record_type=5` on task) registered in this period:

```SQL
SELECT * FROM CounterValue WHERE contact_id > 0 AND record_type = 5  AND direction > 0  AND intent_id = 0 AND totalReg > 4
```

> [!NOTE]
> We must specify `intent_id` for appointments/documents to avoid duplicate IDs in the result. intent = 0 implies all intents.

## See also

* [countervalue table][1]

<!-- Referenced links -->
[1]:  ../../../../../database/docs/tables/countervalue.md

<!-- Referenced images -->
[img1]: ../media/countervalues-more.png
