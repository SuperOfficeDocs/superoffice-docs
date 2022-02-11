---
title: Working with companies
description: The company card uses the contact table and its related tables. There are multiple person records for any contact.
author: Bergfrid Skaara Dias
so.date: 02.04.2022
so.topic: concept
keywords: company, person, contact
---

# Contact

![Company card -screenshot][img2]

The company card uses the `contact` table and its related tables:

![Company tables diagram][img1]

> [!NOTE]
> There are multiple person records for any contact. A classic many-to-one relationship.

* A person can only belong to one contact.
* A contact can have zero or more persons.

It is this relationship that drives the first to fields in the appointment, sale, and document dialogs. Every time you select a new company, the person list below it has to be re-populated.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/so-contact.gif
[img2]: media/company-card.png
