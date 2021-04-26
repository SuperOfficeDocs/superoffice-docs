---
title: Get contact by vale 
uid: get_contact_by_saint_value
description: Search for a contact with a given saint value
author: {github-id}
keywords:
so.topic: howto
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Search for a contact with a given saint value

The following example shows how we can retrieve a Contact by using a SAINT value.

> [!NOTE]
> When SAINT is enabled, whenever a Contact or a Project is created, a bunch of counter rows are created and whenever an Appointment, Document, or a Sale is created, the corresponding counter rows are updated. Each `counterValue` row points to the `contact_id` or `project_id` it is linked to. SAINT also requires a separate license.

Following are some of the Counter values for a Contact

```SQL
SELECT * FROM CRM.countervalue WHERE sale_status = 2 AND amountClassId = 0 AND totalReg > 2
```

If we want to find all Contacts with no Sales registered in the particular period, we could write the SQL statements as follows.

```SQL
SELECT * FROM CRM.countervalue WHERE contact_id > 0 AND sale_Status = 4 AND amountClassId = 0 AND totalRegInPeriod = 0
```

* `Sale_Status`= 4 includes all statuses
* `Amount_Class` = 0 includes all sizes

If we want to find Contacts who have more than 5 sales register the following code can be used.

```SQL
SELECT * FROM CRM.CounterValue WHERE contact_id > 0 AND sale_Status = 4 AND amountClassId = 0 AND totalReg > 5
```

If we want to find Contacts with more than 4 phone-call appointments (`record_type` = 5 )registered in this period.

```SQL
SELECT * FROM CRM.CounterValue WHERE contact_id > 0 AND record_type = 5 AND direction > 0 AND intent_id = 0 AND totalReg > 4
```

> [!NOTE]
> We are required to specify the `intent_id` for Appointments/Documents to avoid duplicates IDs in the result. `intent_id` = 0 includes all intents.

If we want to find all contacts with more than 4 phone-call appointments (`record_type=5` on task) registered in this period:

```SQL
SELECT * FROM CounterValue WHERE contact_id > 0 AND record_type = 5 AND direction > 0 AND intent_id = 0 AND totalReg > 4
```

We must specify `intent_id` for appointments/documents to avoid duplicate IDs in the result. `intent_id` = 0 implies all intents.
