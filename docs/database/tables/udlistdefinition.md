---
uid: table-UDListDefinition
title: UDListDefinition table
description: List table that contains the list of user-defined lists, as well as system-defined lists. The list items are stored in the UDList table. 
so.generated: true
keywords:
  - "database"
  - "UDListDefinition"
so.date: 11.04.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# UDListDefinition Table (139)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|UDListDefinition\_id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|listTableId|The table ID of the list table that this record contains the name of|TableNumber| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |
|requiredLicense|Licenses the user/installation must have if this reference is to be shown. Comma-separated list of owner.module pairs|String(254)|&#x25CF;|


![UDListDefinition table relationship diagram](./media/UDListDefinition.png)

[!include[details](./includes/udlistdefinition.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|UDListDefinition\_id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

