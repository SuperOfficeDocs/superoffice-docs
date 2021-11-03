---
uid: table-ms_trashbin
title: ms_trashbin table
description: This table contains entries for emails which have been trashed by a filter, waiting for confirmation of deletion or import.
so.generated: true
keywords:
  - "database"
  - "ms_trashbin"
so.date: 11.02.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ms\_trashbin Table (312)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|mail\_sorter\_id|The id of the filter which sent this email to the trashbin.|FK [ms_filter](ms-filter.md)| |
|mail\_in\_filter\_id|The id of the mailbox from which this email came.|FK [mail_in_filter](mail-in-filter.md)| |
|when\_trashed|When the email was trashed by the filter.|DateTime|&#x25CF;|
|subject|The subject field of the trashed email|String(255)|&#x25CF;|


![ms_trashbin table relationship diagram](./media/ms_trashbin.png)

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|mail\_sorter\_id |FK |Index |
|mail\_in\_filter\_id |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

