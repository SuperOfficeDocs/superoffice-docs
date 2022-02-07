---
title: Working with persons
description: Person
author: Bergfrid Skaara Dias
so.date: 11.02.2021
so.topic: concept
keywords: person, contact, API
---

# Person

For a better understanding of this section, we recommend that you read [SuperOffice view of the world][1].

It is important to keep in mind that there's not a 1:1 mapping of labels and that you have to take context into account.

* Real-life terms
* UI labels
* Database tables
* CRMScript classes

![Edit person dialog -screenshot][img1]

## Person picture and blobs

Pictures are stored in the BLOB table.

The Blobs are linked to other records in the system using the `BinaryLink` table.

Blobs are currently used for four things:

* Pictures on person records
* Pictures on project records
* Flags on country records
* Status monitor pictures

If you add a picture to a person, you must write the picture to the `BinaryObject` table, and then write the corresponding `BinaryObjectLink` to link the BLOB with the person record.

Without the link record, the picture will not appear.

<!-- Referenced links -->
[1]: ../overview/domain.md

<!-- Referenced images -->
[img1]: media/edit-person.png
