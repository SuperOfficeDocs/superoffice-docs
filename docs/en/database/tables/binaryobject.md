---
uid: table-BinaryObject
title: BinaryObject table
description: Binary objects, i.e., blobs. Used for images, documents, SuperOffice inbox mail  and other large binary items
so.generated: true
keywords: database table BinaryObject
so.topic: reference
so.envir: onsite, online
---

# BinaryObject Table (205)

Binary objects, i.e., blobs. Used for images, documents, SuperOffice inbox mail  and other large binary items

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|BinaryObject\_id|Primary key|PK| |
|conceptualType|The type, for instance PHOTO, PERSONPHOTO, or whatever, that is descriptive of what kind of image or data this is|String(254)| |
|mimeType|Mime type, describing the technical type (image/jpeg) of the data|String(254)|&#x25CF;|
|description|A description that is entered by the user, and visible to the user|String(254)|&#x25CF;|
|originalSize|Original size of the binary data, before encryption and/or zipping. This is what the ultimate client will get|UInt| |
|blobSize|The length, in bytes, of the binary data AS STORED after any encryption and/or zipping. Important to get right, since some databases will not tell us just based on the blob itself!|UInt| |
|isZipped|Has the data been zipped (support for this will come in HDB)|Bool| |
|isEncrypted|Has the data been encrypted (support for this will come in HDB)|Bool| |
|extraInfo|Extra information, spare field, can be used for anything that makes sense. Should not refer to any particular context, that is something for the BinaryObjectLInk|String(254)|&#x25CF;|
|binaryData|The binary data itself. Length is limited by the database, generally 1GB seems to be reliably available. Beyond that is database dependent.|Blob|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![BinaryObject table relationship diagram](./media/BinaryObject.png)

[!include[details](./includes/binaryobject.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|BinaryObject\_id |PK |Clustered, Unique |
|conceptualType |String(254) |Index |
|mimeType |String(254) |Index |
|extraInfo |String(254) |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[BinaryObjectLink](binaryobjectlink.md)  |Link table, connects a BinaryObject with one or more owners |
|[extra\_tables](extra-tables.md)  |This table contains entries for the extra tables in the system. |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* Sentry controls access to items in this table using user's Role and data rights matrix.

