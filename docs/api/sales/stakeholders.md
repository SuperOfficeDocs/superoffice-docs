---
title: Stakeholders
uid: sale_stakeholders
description: Sale stakeholders
author: {github-id}
keywords: database
so.topic: concept
# so.envir:
# so.client:
---

# Sale stakeholders

New from 7.1: A sale may now have one or more stakeholders, a contact or person with an extra interest or role in the sale. This may be turned off using the preference in **SOAdmin - Preferences - Sale - Enable Stakeholders (default yes)**

With this preference turned on a new archive is presented for sales of type.

![Stakeholders][img1]

This will also make the sale visible on more than one company salesarchive if **Include Stakeholders** is ticked.

![Include Stakeholders][img2]

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

![SaleStakeholder table][img3]

<!-- Referenced images -->
[img1]: media/stakeholders.png
[img2]: media/include-stakeholders.png
[img3]: media/salestakeholder-table.png
