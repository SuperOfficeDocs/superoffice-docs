---
title: interests
description: Interests are stored on contacts and persons
author: Bergfrid Skaara Dias
so.date: 11.04.2021
keywords: interest, contact, company, person, contactinterest, ContInt
so.topic: concept
# so.envir:
# so.client:
---

# Interests

![Interest tab on Contact card -screenshot][img1]

Interests are stored on contacts and persons - there are 2 separate sets of interests and a separate set of link tables.

![InterestLinkTable diagram][img2]

The link table (`contactinterest`) allows a single contact to have zero or more interests checked off.

The `ContInt` table is an MDO table, so interests can be grouped and organized under headings. The position under a heading does not matter to the linkage to a contact.

```SQL
SELECT * FROM contint
```

| ContInt_id | name | rank | tooltip | deleted | registered | registered_associate_id |
|---|---|---|---|---|---|---|
| 854 | Hansa | 136 | Hansa | 0 | 28.10.2021 13.14:59 | 94 |
| 855 | IFS | 137 | IFS | 0 | 28.10.2021 13.18:17 | 94 |
| 856 | Agresso | 133 | Agresso | 0 | 28.10.2021 13.19:23 | 94 |
| 857 | AS400 | 134 | AS400 | 0 | 28.10.2021 13.20:22 | 94 |

```SQL
SELECT * FROM contactinterest
```

| contactinterest_id | contact_id | cinterest_idx | startDate | endDate | flags | registered |
|---|---|---|---|---|---|---|
| 53459 | 1 | 594 | | 31.12.2021 02:13:49 | 0 | 28.10.2021 13.14:59 |
| 53640 | 1 | 1569 | | 31.12.2021 02:13:49 | 0 | 28.10.2021 13.14:59 |
| 45770 | 4 | 965 | | 31.12.2021 02:13:49| 0 | 28.10.2021 13.14:59 |
| 45259 | 9 | 965 | | 31.12.2021 02:13:49| 0 | 28.10.2021 13.14:59 |

You can extend the list of interests for a contact by creating and adding a new interest to that list.

## Contact cached value

The `contact` table has a counter field that stores the number of active interests. This field is used to cache the count. It is updated whenever the user edits the company. The field is used to quickly check whether the interests tab needs to indicate the presence of interests or not.

<!-- Referenced images -->
[img1]: media/contact-interests.png
[img2]: media/interestlink-table.png
