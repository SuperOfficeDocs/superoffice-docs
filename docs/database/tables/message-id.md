---
uid: table-message_id
title: message_id table
description: This table links an email message id to an eJournal item
so.generated: true
keywords:
  - "database"
  - "message_id"
so.date: 11.02.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# message\_id Table (386)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|message\_id|The message id|String(255)| |
|domain|The domain to which this message id links|Int| |
|item\_id|The id of the element this item links to|Int| |


![message_id table relationship diagram](./media/message_id.png)

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|message\_id |String(255) |Index |
|domain |Int |Index |
|item\_id |Int |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

