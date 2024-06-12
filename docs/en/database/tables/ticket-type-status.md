---
uid: table-ticket_type_status
title: ticket_type_status table
description: Link table defining what Statuses are relevant to a particular Ticket type
so.generated: true
keywords: database table ticket_type_status
so.topic: reference
so.envir: onsite, online
---

# ticket\_type\_status Table (534)

Link table defining what Statuses are relevant to a particular Ticket type

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|ticket\_type\_status\_id|Primary key|PK| |
|ticket\_type\_id|Ticket type |FK [ticket_type](ticket-type.md)| |
|ticket\_status\_id|Ticket status|FK [ticket_status](ticket-status.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ticket_type_status table relationship diagram](./media/ticket_type_status.png)

[!include[details](./includes/ticket-type-status.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|ticket\_type\_status\_id |PK |Clustered, Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[ticket\_status](ticket-status.md)  |This table user defined ticket status values. |
|[ticket\_type](ticket-type.md)  |A ticket (request) type |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

