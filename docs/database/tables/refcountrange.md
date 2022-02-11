---
uid: table-RefCountRange
title: RefCountRange table
description: Number allocation system, for keeping track of ranges of numbers loaned out to travel and satellite databases
so.generated: true
keywords:
  - "database"
  - "RefCountRange"
so.date: 11.04.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# RefCountRange Table (172)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|RefCountRange\_id|Primary key|PK| |
|rangeStart|Start of range that is in use|UInt| |
|rangeSize|Size of in-use range|UInt| |
|RefCounts\_id|ID of counter this range is reserved for|FK [RefCounts](refcounts.md)| |
|traveller\_id|ID of traveller (associate) who owns this range|UShort| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |
|highestInUse|The highest number (within the range) that is currently in use. This used to be the infamous preference!|UInt| |


![RefCountRange table relationship diagram](./media/RefCountRange.png)

[!include[details](./includes/refcountrange.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|RefCountRange\_id |PK |Clustered, Unique |
|RefCounts\_id |FK |Index |
|traveller\_id |UShort |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

