---
uid: crmscript-interest
title: Interests
description: Working with interests on SuperOffice contacts and companies in CRMScript.
keywords: interest, company, contact, person, contactinterest, personinterest, companyinterest, ContInt, PersInt
author: Eivind Fasting
date: 04.18.2022
version: 10
topic: concept
---

# Interests

Interests can be stored on the company or contact card in SuperOffice. They are conceptually the same, but are backed by different tables in the database.

## Overview

Some things to be aware of:

* A company in the SuperOffice UI has its information stored in the `contact` table, with its relations.
* A contact in the SuperOffice UI has its information stored in the `person` table, with its relations.

### Company

![Interest tab on company card -screenshot][img1]

The database reference for company interests are found here:

![CompanyInterestLinkTable diagram][img3]

### Contact

![Interest tab on contact card -screenshot][img2]

The database reference for contact interests are found here:

![ContactInterestLinkTable diagram][img4]

## Detailed

This section delves deeper into **company interests**, omitting details of contact interests, as their functionality mirrors that of company interests.

The link table ([contactinterest][1]) allows a single contact to have zero or more interests checked off.

The [ContInt][2] table is an **MDO table**, so interests can be grouped and organized under headings. The position under a heading doesn't affect the linkage to a contact.

> [!NOTE]
> For headings to show, there must be a minimum number of interests defined in Settings and maintenance. To set or check this number, go to the [Preferences screen][3] > **Grouped lists** > **Company Interest**. If no value is specified for this setting, the system defaults to 7.
>
> The same preference can be found for contact interests at [Preferences screen][3] > **Grouped lists** > **Contact Interest**.

```SQL
SELECT * FROM contint
```

| ContInt_id | name | rank | tooltip | deleted | registered | registered_associate_id |
|:-:|---|:-:|---|:-:|---|:-:|
| 854 | Hansa | 136 | Hansa | 0 | 28.10.2021 13.14:59 | 94 |
| 855 | IFS | 137 | IFS | 0 | 28.10.2021 13.18:17 | 94 |
| 856 | Agresso | 133 | Agresso | 0 | 28.10.2021 13.19:23 | 94 |
| 857 | AS400 | 134 | AS400 | 0 | 28.10.2021 13.20:22 | 94 |

```SQL
SELECT * FROM contactinterest
```

| contactinterest_id | contact_id | cinterest_idx | startDate | endDate | flags | registered |
|:-:|:-:|:-:|---|---|:-:|---|
| 53459 | 1 | 594 | | 31.12.2021 02:13:49 | 0 | 28.10.2021 13.14:59 |
| 53640 | 1 | 1569 | | 31.12.2021 02:13:49 | 0 | 28.10.2021 13.14:59 |
| 45770 | 4 | 965 | | 31.12.2021 02:13:49| 0 | 28.10.2021 13.14:59 |
| 45259 | 9 | 965 | | 31.12.2021 02:13:49| 0 | 28.10.2021 13.14:59 |

You can extend the list of interests for a company by creating and adding a new interest to that list.

## Contact cached value

The `contact` table has a counter field that stores the number of active interests. This field is used to cache the count. It is updated whenever the user edits the company. The field is used to check whether the **Interests** tab needs to indicate the presence of interests or not.

## How to

* [Get and set company interests][4]
* [Get and set contact interests][5]

<!-- Referenced links -->
[1]: ../../../../database/tables/contactinterest.md
[2]: ../../../../database/tables/contint.md
[3]: ../../../../admin/preferences/learn/index.md
[4]: company-interests.md
[5]: contact-interests.md

<!-- Referenced images -->
[img1]: media/company-interests.png
[img2]: media/contact-interests.png
[img3]: media/company-interests-table-relation.png
[img4]: media/contact-interests-table-relation.png
