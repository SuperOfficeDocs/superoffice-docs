---
title: Stakeholders
uid: sale_stakeholders
description: Sale stakeholders
author: Bergfrid Dias
so.date: 11.05.2021
keywords: sale, stakeholder, hasStakeholders, API, saletype, salestakeholder
so.topic: concept
so.version: 7.1
# so.envir:
# so.client:
---

# Sale stakeholders

[!include[License requirement](../includes/req-sales-prem.md)]

A sale may have one or more stakeholders: a contact or person with an extra interest or role in the sale. This can be turned off using the preference in **SOAdmin - Preferences - Sale - Enable Stakeholders (default yes)**.

With this preference turned on a new archive is presented for sales of type.

![Stakeholders -screenshot][img1]

This will also make the sale visible on more than one company salesarchive if **Enable Stakeholders** is set.

![Enable stakeholders setting -screenshot][img2]

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

<!-- Referenced images -->
[img1]: media/stakeholders.png
[img2]: media/include-stakeholders.png
