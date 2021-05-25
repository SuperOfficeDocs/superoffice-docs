---
title: person
description: Person
author: {github-id}
so.topic: generic
keywords:
---

# Person

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
