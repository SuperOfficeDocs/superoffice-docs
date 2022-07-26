---
title: How to add a person picture
uid: add_person_picture_blob_sql
description: How to add a person picture with raw SQL.
author: Bergfrid Skaara Dias
so.date: 11.02.2021
keywords: blob, person, contact, image, picture, API, BinaryObject, BinaryObjectLink
so.topic: howto
---

# How to add a person picture

To add a picture to a person, you must write the picture to the [BinaryObject table][1], and then write the corresponding [BinaryObjectLink][2] to link the BLOB with the person record.

## Update BinaryObject table

First, the BLOB data is inserted into the `BinaryObject` table:

<!-- markdownlint-disable MD013 -->
```SQL
INSERT INTO CRM."binaryobject" ("BinaryObject_id", "conceptualType", "mimeType", "description", "originalSize", "blobSize", "isZipped", "isEncrypted", "extraInfo", "binaryData", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount") VALUES (624, 'PersonImage', 'image/jpeg', 'Njål Narvestad', 1333, 1333, 0, 0, '', (blobdata), 1164194209, 13, 0, 0, 0)
```
<!-- markdownlint-restore -->

The `conceptualType` is useful for classifying the image. The same image can be used in several different contexts, thanks to the Link table. The `conceptualType` is primarily intended to provide a filter when generating lists for browsing.

> [!NOTE]
> The `mimeType` is used to determine how to display the image, so it should be set appropriately. The description is useful when browsing the BLOB table - so try to set it to something meaningful.

The zip and encrypt values are not supported at the moment, so they should be 0.

`OriginalSize` and `BlobSize` are used when allocating read buffers, so they must be set to the size of the BLOB.

When we add support for ZIP compression, the `BlobSize` may be smaller than the `originalSize`.

## Link blob to person

Then the link from the BLOB (`binaryObjectId=624`) to the person record (`ownerTable=6`, `ownerRecord=74`)

<!-- markdownlint-disable MD013 -->
```SQL
INSERT INTO CRM."binaryobjectlink" ("BinaryObjectLink_id", "binaryObjectId", "ownerTable", "ownerRecord", "linkComment", "linkType", "rank", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount") VALUES (267, 624, 6, 74, '', 1, 1, 1164194209, 13, 0, 0, 0)
```
<!-- markdownlint-restore -->

Of course, we must not forget to make a note of our inserts in the **transaction log**:

<!-- markdownlint-disable MD013 -->
```SQL
INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110415, 1164197809, 0, 4352, 13, 205, 624)

INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110416, 1164197809, 0, 4352, 13, 206, 267)
```
<!-- markdownlint-restore -->

<!-- Referenced links -->
[1]: ../../../database/tables/binaryobject.md
[2]: ../../../database/tables/binaryobjectlink.md
