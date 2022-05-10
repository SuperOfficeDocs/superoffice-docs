---
uid: table-ticket_type
title: ticket_type table
description: Contains ticket types, used to drive processing logic together with ticket relations
so.generated: true
keywords:
  - "database"
  - "ticket_type"
so.date: 04.12.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ticket\_type Table (451)

Contains ticket types, used to drive processing logic together with ticket relations

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|name|Multi-language singular name|String(2047)|&#x25CF;|
|name\_plural|Multi-language plural name|String(2047)|&#x25CF;|
|description|Multi-language description|String(3999)|&#x25CF;|
|show\_in\_navigator|If true, then this type should be shown directly in the Navigator for quick access|Bool|&#x25CF;|
|flags|Extra information bits|Int|&#x25CF;|
|icon\_url|URL to icon file|String(2047)|&#x25CF;|
|rank|Display sort sequence for default sort order|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime|&#x25CF;|
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)|&#x25CF;|
|updated|Last updated when|UtcDateTime|&#x25CF;|
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)|&#x25CF;|
|updatedCount|Number of updates made to this record|UShort|&#x25CF;|


![ticket_type table relationship diagram](./media/ticket_type.png)

[!include[details](./includes/ticket-type.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[ticket](ticket.md)  |This table contains the tickets (requests) of the system. Its purpose should be evident. |
|[ticket\_relation\_type](ticket-relation-type.md)  |Contains ticket relation types, used to drive processing logic together with ticket relations |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

