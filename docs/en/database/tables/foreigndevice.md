---
uid: table-foreigndevice
title: foreigndevice table
description: Middle level of Foreign Key system
so.generated: true
keywords: database table foreigndevice
so.topic: reference
so.envir: onsite, online
---

# foreigndevice Table (182)

Middle level of Foreign Key system

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|foreigndevice\_id|Primary key|PK| |
|name|Name of device|String(31)| |
|device\_id|Optional unique id of device (Palm pilot device ID, etc)|String(239)|&#x25CF;|
|foreignapp\_id|Reference to foregin application (device type)|FK [foreignapp](foreignapp.md)| |
|owner\_id|Reference to SO user owning this device|FK [associate](associate.md)| |
|lastsynced|Last sync date|DateTime|&#x25CF;|
|lastsynced\_trans|Last sync traveltransactionlog id number|DateTime|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![foreigndevice table relationship diagram](./media/foreigndevice.png)

[!include[details](./includes/foreigndevice.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|foreigndevice\_id |PK |Clustered, Unique |
|name |String(31) |Index |
|device\_id |String(239) |Index |
|foreignapp\_id |FK |Index |
|owner\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[foreignapp](foreignapp.md)  |Top level of Foreign Key system |
|[foreignkey](foreignkey.md)  |Foreign Key - enables storage of arbitrary extra key information for every table/row in SuperOffice. You may use this table to store your extra information instead of using the dictionary SDK to create your own tables. |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

