---
uid: contact-picture
title: Person picture and BLOBs
description: Person pictures are stored in the BLOB table and linked to the person record.
author: Bergfrid Skaara Dias
date: 15.02.2021
topic: concept
keywords: person, contact, BinaryObject, BLOB, picture
---

# Person picture and BLOBs

Pictures are stored in the BLOB table. The BLOBs are linked to other records in the system using the [BinaryObjectLink table][2].

BLOBs are currently used for four things:

* Pictures on person records
* Pictures on project records
* Flags on country records
* Status monitor pictures

If you add a picture to a person, you must write the picture to the [BinaryObject table][1], and then write the corresponding `BinaryObjectLink` to link the BLOB with the person record.

Without the link record, the picture will not appear.

## Howto

* [Add person picture BLOBs (raw SQL)][3]
* [Display image from BLOB table (entities)][4]
* [Get person image (REST)][5]
* [Update person image (REST)][6]
* [Display person image (ImageUtility)][7]
* [Display image from BLOB table (web services)][8]

<!-- Referenced links -->
[1]: ../database/tables/binaryobject.md
[2]: ../database/tables/binaryobjectlink.md
[3]: howto/sql/add-person-picture-blobs-sql.md
[4]: howto/entity/display-image-from-blob-table-entity.md
[5]: howto/services/get-person-image-rest.md
[6]: howto/services/update-person-image-rest.md
[7]: howto/services/display-person-image-ws.md
[8]: howto/services/display-image-from-blob-table-services.md
