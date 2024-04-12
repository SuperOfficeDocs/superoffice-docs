---
title: interests
uid: company-interests
description: Interests are stored on contacts and persons
author: Bergfrid Skaara Dias
so.date: 02.21.2022
keywords: interest, contact, company, person, contactinterest, ContInt
so.topic: concept
---

# Interests

![Interest tab on Contact card -screenshot][img1]

Interests are stored on contacts and persons - there are two separate sets of interests and a separate set of link tables.

![InterestLinkTable diagram][img2]

The link table ([contactinterest][10]) allows a single contact to have zero or more interests checked off.

The [ContInt][9] table is an **MDO table**, so interests can be grouped and organized under headings. The position under a heading does not matter to the linkage to a contact.

> [!NOTE]
> For headings to show, there must be a minimum number of interests defined in Settings and maintenance. To set or check this number, go to the [Preferences screen][12] > **Grouped lists** > **Company Interest**. If no value is specified for this setting, the system defaults to 7.

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

## Howto

* [Get interests - raw SQL][1]
* [Add a new contact interest - rows][2]
* [List all selected interests - entities][3]
* [Set interest on/off - entities][4]
* [List interests - services][6]
* [Set interest on/off - services][7]
* [ContInt MDO provider][8]
* [Set interest on/off - CRMScript][11]

<!-- Referenced links -->
[1]: howto/sql/get-interests-sql.md
[2]: howto/row/add-new-contact-interest.md
[3]: howto/entity/get-interests-for-contact-entity.md
[4]: howto/entity/set-interest-on-off-entity.md
[6]: howto/services/get-interests-for-contact-services.md
[7]: howto/services/set-interest-on-off-services.md
[8]: ../api/mdo-providers/reference/ContInt.md
[9]: ../database/tables/contint.md
[10]: ../database/tables/contactinterest.md
[11]: howto/crmscript/set-interest-on-off-crmscript.md
[12]: ../admin/preferences/learn/index.md

<!-- Referenced images -->
[img1]: media/contact-interests.png
[img2]: media/interestlink-table.png
