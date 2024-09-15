---
uid: table-s_washing_list
title: s_washing_list table
description: Unused table that is ment to be used for active washing in spm v2
so.generated: true
keywords: database table s_washing_list
so.topic: reference
so.envir: onsite, online
---

# s\_washing\_list Table (343)

Unused table that is ment to be used for active washing in spm v2

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|list\_id|Reference to a list to wash|FK [s_list](s-list.md)| |
|address|Not known, probably usefull in the future :)|String(255)| |


![s_washing_list table relationship diagram](./media/s_washing_list.png)

[!include[details](./includes/s-washing-list.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|list\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[s\_list](s-list.md)  |A list, dynamic or static |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

