---
uid: table-diaryviewrow
title: diaryviewrow table
description: Configuration of a multi-user diary view
so.generated: true
keywords:
  - "database"
  - "DiaryViewRow"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# diaryviewrow Table (215)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|DiaryViewRow\_id|Primary key|PK| |
|diaryViewId|Owning view|FK [diaryview](diaryview.md)| |
|assoc\_id|Associate to be displayed|FK [associate](associate.md)| |
|rank|Sorting rank|UShort| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![DiaryViewRow table relationship diagram](./media/DiaryViewRow.png)

[!include[details](./includes/DiaryViewRow.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|DiaryViewRow\_id |PK |Clustered, Unique |
|diaryViewId |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

