---
uid: table-UDListHeadingLink
title: UDListHeadingLink table
description: Heading link table for UDList, for MDO headers. Note - MDO mode for userdefinede lists are either turned on or off, you may not have it on for one userdefined list and off for the others.
so.generated: true
keywords: database table UDListHeadingLink
so.topic: reference
so.envir: onsite, online
---

# UDListHeadingLink Table (138)

Heading link table for UDList, for MDO headers. Note - MDO mode for userdefinede lists are either turned on or off, you may not have it on for one userdefined list and off for the others.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|udlistheadinglink\_id|Primary key|PK| |
|udlist\_id|Link to UDList list table|FK [UDList](udlist.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![UDListHeadingLink table relationship diagram](./media/UDListHeadingLink.png)

[!include[details](./includes/udlistheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|udlistheadinglink\_id |PK |Clustered, Unique |
|udlist\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |
|[UDList](udlist.md)  |List table for user-defined lists, contains all user-defined lists. Note - MDO mode for userdefinede lists are either turned on or off, you may not have it on for one userdefined list and off for the others. |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

