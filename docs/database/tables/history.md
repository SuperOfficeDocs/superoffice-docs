---
uid: table-history
title: history table
description: History lists for lists and searchable controls. Maintains history for Navigator or other search (find dialogs). A single table may have more than one record here, as indicated by the extra_id field. The HistorySize (preference may be set in maintenance client) defines how many records you can have in a history list.
so.generated: true
keywords:
  - "database"
  - "History"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# history Table (53)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|history\_id|Primary key|PK| |
|associate\_id|Owner of history list|FK [associate](associate.md)| |
|table\_id|Table this is a history of|TableNumber| |
|record\_id|Record within the table|RecordId| |
|extra\_id|Extra ID, used to manage multiple histories per table|Id| |
|rank|Sort order, indexed so it can used for sorting in the query|UShort| |
|updatedCount|Number of updates made to this record|UShort| |


![History table relationship diagram](./media/History.png)

[!include[details](./includes/History.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|history\_id |PK |Clustered, Unique |
|rank |UShort |Index |
|associate\_id, table\_id, extra\_id |FK, TableNumber, Id |Index |

## Replication Flags

* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

