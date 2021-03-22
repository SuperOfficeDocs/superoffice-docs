---
uid: table-udlistheadinglink
title: udlistheadinglink table
description: Heading link table for UDList, for MDO headers. Note - MDO mode for userdefinede lists are either turned on or off, you may not have it on for one userdefined list and off for the others.
so.generated: true
keywords:
  - "database"
  - "UDListHeadingLink"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# udlistheadinglink Table (138)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|udlistheadinglink\_id|Primary key|PK| |
|udlist\_id|Link to UDList list table|FK [udlist](udlist.md)| |
|heading\_id|Link to Heading table|FK [heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![UDListHeadingLink table relationship diagram](./media/UDListHeadingLink.png)

[!include[details](./includes/UDListHeadingLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|udlistheadinglink\_id |PK |Clustered, Unique |
|udlist\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

