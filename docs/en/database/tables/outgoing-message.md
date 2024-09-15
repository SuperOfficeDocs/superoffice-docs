---
uid: table-outgoing_message
title: outgoing_message table
description: Delivery of outgoing messages to messageplugins, updated with status asynchroneously
so.generated: true
keywords: database table outgoing_message
so.topic: reference
so.envir: onsite, online
---

# outgoing\_message Table (407)

Delivery of outgoing messages to messageplugins, updated with status asynchroneously

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|session\_key|Session key used for threading.|String(255)| |
|external\_message\_id|Session key used for threading.|String(255)| |
|status|Current status of outgoing message|Int| |
|status\_description|Description of current status|String(255)| |
|plugin|Name of plugin|String(255)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |


![outgoing_message table relationship diagram](./media/outgoing_message.png)

[!include[details](./includes/outgoing-message.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|session\_key |String(255) |Index |
|external\_message\_id |String(255) |Index |
|registered\_associate\_id |FK |Index |
|updated\_associate\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[sms](sms.md)  |This table will hold outgoing sms messages when transmitted with WebServices |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

