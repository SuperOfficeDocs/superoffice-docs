---
title: interests
uid: contact-interests
description: Contact interests are stored on contacts
author: Eivind Fasting
so.date: 04.15.2022
keywords: interest, contact, person, personinterest, PersInt
so.topic: concept
---

# Interests

Interests can be stored on the contact card

![Interest tab on contact card -screenshot][img1]

These interest are stored in the following table:
> [!NOTE]
> Even though the entity is called Contact in the SuperOffice UI the data is stored in the tables related to person in the database.

![InterestLinkTable diagram][img2]

The link table ([personinterests][10]) allows a single contact to have zero or more interests checked off.

The [PersInt][9] table is an **MDO table**, so interests can be grouped and organized under headings. The position under a heading does not matter to the linkage to a person.

> [!NOTE]
> For headings to show, there must be a minimum number of interests defined in Settings and maintenance. To set or check this number, go to the [Preferences screen][12] > **Grouped lists** > **Contact Interest**. If no value is specified for this setting, the system defaults to 7.

```SQL
SELECT * FROM persint
```

| PersInt_id | name | rank | tooltip | deleted | registered | registered_associate_id |
|---|---|---|---|---|---|---|
| 854 | Hansa | 136 | Hansa | 0 | 28.10.2021 13.14:59 | 94 |
| 855 | IFS | 137 | IFS | 0 | 28.10.2021 13.18:17 | 94 |
| 856 | Agresso | 133 | Agresso | 0 | 28.10.2021 13.19:23 | 94 |
| 857 | AS400 | 134 | AS400 | 0 | 28.10.2021 13.20:22 | 94 |

```SQL
SELECT * FROM personinterest
```

| personinterest_id | person_id | cinterest_idx | startDate | endDate | flags | registered |
|---|---|---|---|---|---|---|
| 53459 | 1 | 594 | | 31.12.2021 02:13:49 | 0 | 28.10.2021 13.14:59 |
| 53640 | 1 | 1569 | | 31.12.2021 02:13:49 | 0 | 28.10.2021 13.14:59 |
| 45770 | 4 | 965 | | 31.12.2021 02:13:49| 0 | 28.10.2021 13.14:59 |
| 45259 | 9 | 965 | | 31.12.2021 02:13:49| 0 | 28.10.2021 13.14:59 |

You can extend the list of interests for a contact by creating and adding a new interest to that list.

## Contact cached value

The `person` table has a counter field that stores the number of active interests. This field is used to cache the count. It is updated whenever the user edits the contact. The field is used to quickly check whether the interests tab needs to indicate the presence of interests or not.

## Howto

* [Set interest on/off - CRMScript][1]

<!-- Referenced links -->
[1]: howto/crmscript/set-interest-on-off-crmscript.md
[9]: ../database/tables/persint.md
[10]: ../database/tables/personinterest.md
[12]: ../admin/preferences/learn/index.md

<!-- Referenced images -->
[img1]: media/contact-interests.png
[img2]: media/contact-interests-table-relation.png
