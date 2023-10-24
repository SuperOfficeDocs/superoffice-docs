---
uid: company-overview
title: Working with companies
description: The company card uses the contact table and its related tables. There are multiple person records for any contact.
author: Bergfrid Skaara Dias
so.date: 02.21.2022
so.topic: concept
keywords: company, person, contact
---

# Company

![Company card -screenshot][img2]

[!include[company vs. contact](../includes/terminology-company.md)]

## Company vs. other entities

The company card uses the [contact][2] table and its related tables:

![Company tables diagram][img1]

There are multiple `person` records for any `contact`. A classic many-to-one relationship.

* A **person** can only belong to one **contact**.
* A **contact** can have zero or more **persons**.

It is this relationship that drives the first to fields in the follow-up, sale, and document dialogs. Every time you select a new company, the person list below it has to be re-populated.

* [contact][10] (person table)
* [documents][11]
* [follow-ups][12] (appointment table)
* [projects][13]
* [sales][14]

## API how-tos

* [CRMScript][4]
* [Web services][5]
* [Entities][6]
* [Rows][7]
* [Objectified SQL][8]
* [Raw SQL][9]

## More

* [Interests][1]
* [Categories][15]
* [Addresses][3]
* [Associates][16]

<!-- Referenced links -->
[1]: interests.md
[2]: ../database/tables/contact.md
[3]: ../globalization-and-localization/address/index.md
[4]: howto/crmscript/index.md
[5]: howto/services/index.md
[6]: howto/entity/index.md
[7]: howto/row/index.md
[8]: howto/osql/index.md
[9]: howto/sql/index.md
[10]: ../contact/index.yml
[11]: ../document/index.yml
[12]: ../diary/index.yml
[13]: ../project/index.yml
[14]: ../sale/index.yml
[15]: category-list.md
[16]: ../contact/associate.md

<!-- Referenced images -->
[img1]: media/so-contact.gif
[img2]: media/company-card.png
