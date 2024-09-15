---
uid: table-WebAppUsage
title: WebAppUsage table
description: Usage statistics for web applications
so.generated: true
keywords: database table WebAppUsage
so.topic: reference
so.envir: onsite, online
---

# WebAppUsage Table (249)

Usage statistics for web applications

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|WebAppUsage\_id|Primary key|PK| |
|version|Version number of usage stats|UInt| |
|assocId|ID of associate|FK [associate](associate.md)| |
|timestamp|Time stamp of operation|DateTime| |
|viewState|Current view state, excluding data|String(254)| |
|aggregateBin|Bin no. If this is aggregated data|UInt|&#x25CF;|
|aggregateCount|Bin count, if this is aggregated data|UInt|&#x25CF;|


![WebAppUsage table relationship diagram](./media/WebAppUsage.png)

[!include[details](./includes/webappusage.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|WebAppUsage\_id |PK |Clustered, Unique |
|viewState, timestamp, assocId |String(254), DateTime, FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

