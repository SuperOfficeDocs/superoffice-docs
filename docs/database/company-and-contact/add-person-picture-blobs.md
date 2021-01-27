---
title: blobs
description: Person picture and blobs
author:
so.date:
keywords:
so.topic: howto
---

# Person picture and blobs

Pictures are stored in the BLOB table.

The Blobs are linked to other records in the system using the `BinaryLink` table.

Blobs are currently used for four things:

* Pictures on person records
* Pictures on project records
* Flags on country records
* Status monitor pictures

If you add a picture to a person, you must write the picture to the `BinaryObject` table, and then write the corresponding `BinaryObjectLink` to link the BLOB with the person record.

Without the link record, the picture will not appear.

## Example

First, the BLOB data is inserted into the `binaryobject` table:

```SQL
INSERT INTO CRM."binaryobject" ("BinaryObject_id", "conceptualType", "mimeType", "description", "originalSize", "blobSize", "isZipped", "isEncrypted", "extraInfo", "binaryData", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount") VALUES (624, 'PersonImage', 'image/jpeg', 'Njål Narvestad', 1333, 1333, 0, 0, '', (blobdata), 1164194209, 13, 0, 0, 0)
```

The `conceptualType` is useful for classifying the image. The same image can be used in several different contexts, thanks to the Link table. The `conceptualType` is primarily intended to provide a filter when generating lists for browsing.

> [!NOTE]
> The `mimeType` is used to determine how to display the image, so it should be set appropriately. The description is useful when browsing the BLOB table - so try to set it to something meaningful.

The zip and encrypt values are not supported at the moment, so they should be 0.

`OriginalSize` and `BlobSize` are used when allocating read buffers, so they must be set to the size of the BLOB.

When we add support for ZIP compression, the `BlobSize` may be smaller than the `originalSize`.

Then the link from the BLOB (`binaryObjectId=624`) to the person record (`ownerTable=6`, `ownerRecord=74`)

```SQL
INSERT INTO CRM."binaryobjectlink" ("BinaryObjectLink_id", "binaryObjectId", "ownerTable", "ownerRecord", "linkComment", "linkType", "rank", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount") VALUES (267, 624, 6, 74, '', 1, 1, 1164194209, 13, 0, 0, 0)
```

Of course, we must not forget to make a note of our inserts in the **transaction log**:

```SQL
INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110415, 1164197809, 0, 4352, 13, 205, 624)

INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110416, 1164197809, 0, 4352, 13, 206, 267)
```

## See also

* [binaryobject table][1]
* [binaryobjectlink table][2]

<!-- Referenced links -->
[1]: ../tables/binaryobject.md
[2]: ../tables/binaryobjectlink.md
