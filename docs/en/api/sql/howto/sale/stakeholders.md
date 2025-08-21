---
uid: sale-stakeholders-sql
title: Stakeholders
description: How to look up sale stakeholders with raw SQL in SuperOffice.
keywords: sale, stakeholder, hasStakeholders, API, saletype, salestakeholder
author: Bergfrid Dias
date: 11.05.2021
version: 7.1
content_type: concept
redirect_from:
  - /en/sale/howto/sql/stakeholders
  - /en/api/netserver/sql/howto/sale/stakeholders
---

# Sale stakeholders

[!include[License requirement](../../../../../../common/includes/req-sales-prem.md)]

Use your favorite query tool and try this query:

```SQL
SELECT * FROM saletype where hasStakeholders = 1
```

If there are sales defined with stakeholders, you may search the database for these sales:

```SQL
SELECT * FROM sale where saletype_id in (select saletype_id from saletype where hasStakeholders = 1)
```

For these sales we may look up the stakeholders, this will present the stakeholders for sale_id = 4

```SQL
SELECT * FROM salestakeholder where sale_id = 4
```

| salestakeholder_id | sale_id | contact_id | person_id | rank | stakeholderrole_id | registered | ... |
|---|---|---|---|---|---|---|---|
| 1 | 4 | 2 | 25 | 0 | 1 | 2021-11-05 10:57:03 | |
| 2 | 4 | 2 | 31 | 0 | 1 | 2021-11-05 10:57:03 | |
| 3 | 4 | 2 | 22 | 0 | 1 | 2021-11-05 10:57:03 | |
| 21 | 4 | 34 | 191 | 0 | 1 | 2021-10-01 08:00:00 | |
