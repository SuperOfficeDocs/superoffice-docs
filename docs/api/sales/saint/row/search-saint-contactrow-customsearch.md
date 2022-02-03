---
title: Search for contacts with a given SAINT counter
uid: search_saint_contactrow_customsearch
description: Search for contacts with a given SAINT counter ContactRow.CustomSearch
author: Bergfrid Skaara Dias
so.date: 11.05.2021
keywords: sale, SAINT, API, row, customsearch, ContactRow, countervalue, amountclassid
so.topic: howto
# so.envir:
# so.client:
---

# Search for contacts with a given SAINT counter using ContactRow.CustomSearch

Sales are grouped into different statuses, like open, sold, lost or unknown. In the [countervalue][1] table, this is represented under the field `sale_status`. Sales are even grouped under different amount classes like small, medium, large, and extra-large.

We might need to retrieve a list of companies with more than 2 successful sales. In this situation we do not want to restrict the amount-class, so we may specify the `amountclassid =0`.

In the following example, we will explain how this is done.

## Code

[!code-csharp[CS](includes/saint-customsearch.cs)]

## Walk-through

In this example, we have created an instance of the `CustomSearch` class. You can join the `contact` table with the `countervalue` table as done above. The exact SQL statement we run above is:

```SQL
SELECT DISTINCT CRM.contact.contact_id
FROM CRM.contact
INNER JOIN CRM.countervalue ON CRM.countervalue.sale_status = 2
AND CRM.countervalue.amountClassId = 0 AND
CRM.countervalue.totalReg > 2
```

> [!NOTE]
> It is not necessary to set the `IsDistinct` property to True. But the join statement returns a large number of rows with the same `contact_id`, and therefore it would be better to set the `IsDistinct` property to True.

<!-- Referenced links -->
[1]:  ../../../../../database/docs/tables/countervalue.md
