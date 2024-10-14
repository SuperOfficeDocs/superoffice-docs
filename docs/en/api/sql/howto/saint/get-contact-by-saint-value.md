---
uid: saint-sql-get-contact-by-value
title: Get contact by value
description: How to search for a contact with a given saint value with raw SQL.
keywords: sale, SAINT, API, SQL, countervalue
author: Bergfrid Skaara Dias
date: 06.09.2023
version: 10
topic: howto
---

# Search for a contact with a given saint value

The following example shows how we can retrieve a contact by using a SAINT value. Each `counterValue` row points to the `contact_id` or `project_id` it is linked to.

[!include[ALT](../../../../../../common/includes/note-req-saint.md)]

Some of the counter values for a contact:

```SQL
SELECT * FROM countervalue WHERE sale_status = 2 AND amountClassId = 0 AND totalReg > 2
```

If we want to find all contacts with no sales registered in the particular period, we could write the SQL statements as follows.

```SQL
SELECT * FROM countervalue WHERE contact_id > 0 AND sale_Status = 4 AND amountClassId = 0 AND totalRegInPeriod = 0
```

* `Sale_Status`= 4 includes all statuses
* `Amount_Class` = 0 includes all sizes

If we want to find contacts who have more than 5 sales register the following code can be used.

```SQL
SELECT * FROM CounterValue WHERE contact_id > 0 AND sale_Status = 4 AND amountClassId = 0 AND totalReg > 5
```

If we want to find contacts with more than 4 follow-up calls (`record_type` = 5 ) registered in this period.

```SQL
SELECT * FROM CounterValue WHERE contact_id > 0 AND record_type = 5 AND direction > 0 AND intent_id = 0 AND totalReg > 4
```

> [!NOTE]
> We are required to specify the `intent_id` for follow-ups/documents to avoid duplicates IDs in the result. `intent_id` = 0 includes all intents.

If we want to find all contacts with more than 4 follow-up call (`record_type=5` on task) registered in this period:

```SQL
SELECT * FROM CounterValue WHERE contact_id > 0 AND record_type = 5 AND direction > 0 AND intent_id = 0 AND totalReg > 4
```

We must specify `intent_id` for follow-ups/documents to avoid duplicate IDs in the result. `intent_id` = 0 implies all intents.
