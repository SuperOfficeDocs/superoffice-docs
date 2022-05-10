---
uid: table-ticket_relation
title: ticket_relation table
description: Contains ticket relations, used to drive processing logic
so.generated: true
keywords:
  - "database"
  - "ticket_relation"
so.date: 04.12.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ticket\_relation Table (454)

Contains ticket relations, used to drive processing logic

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|source|Source ticket|FK [ticket](ticket.md)|&#x25CF;|
|target|Target ticket|FK [ticket](ticket.md)|&#x25CF;|
|relation\_type|Relation type|FK [ticket_relation_type](ticket-relation-type.md)|&#x25CF;|
|registered|Registered when|UtcDateTime|&#x25CF;|
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)|&#x25CF;|
|updated|Last updated when|UtcDateTime|&#x25CF;|
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)|&#x25CF;|
|updatedCount|Number of updates made to this record|UShort|&#x25CF;|


![ticket_relation table relationship diagram](./media/ticket_relation.png)

[!include[details](./includes/ticket-relation.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|source |FK |Index |
|target |FK |Index |

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

