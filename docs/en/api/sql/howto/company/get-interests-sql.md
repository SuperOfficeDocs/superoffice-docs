---
uid: get-interests-sql
title: Get interests for contact
description: How to get interests for a contact from the SuperOffice database using raw SQL.
keywords: contact, company, interest, SQL, API
author: Bergfrid Skaara Dias
date: 11.04.2021
content_type: howto
redirect_from: /en/company/howto/sql/get-interests-sql
---

# Get interests for contact

**To get a list of interests checked off for a contact:**

```SQL
SELECT * FROM contactinterest WHERE contact_id = 123
```

**To get the names of the checked-off interests for a contact:**

```SQL
SELECT * FROM contactinterest, contint
WHERE contactinterest.contact_id = 123
AND contactinterest.cinterest_idx = contint.contint_id
```

| contactinterest_id | contact_id | cinterest_idx | &gt; | ContInt_id | name | rank | tooltip | deleted |
|---|---|---|---|---|---|---|---|---|
| 53459 | 123 | 594 | | 594 | SAP | 142 | | 0 |
| 53640 | 123 | 1569 | | 1569 | Developers | 195 | This company has... | 0 |
