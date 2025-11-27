---
uid: table-ticket_rel_def_ticket_type
title: ticket_rel_def_ticket_type table
description: Link table defining what Ticket types are involved in this relation. Will have M;N rows for a single relation definition
generated: true
keywords: database table ticket_rel_def_ticket_type
content_type: reference
envir: onsite, online
---

# ticket\_rel\_def\_ticket\_type Table (546)

Link table defining what Ticket types are involved in this relation. Will have M;N rows for a single relation definition

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|ticket\_rel\_def\_ticket\_type\_id|Primary key|PK| |
|ticket\_relation\_def\_id|Ticket relation definition|FK [ticket_relation_def](ticket-relation-def.md)| |
|source\_ticket\_type\_id|Ticket type|FK [ticket_type](ticket-type.md)| |
|destination\_ticket\_type\_id|Ticket type|FK [ticket_type](ticket-type.md)| |


![ticket_rel_def_ticket_type table relationship diagram](./media/ticket_rel_def_ticket_type.png)

[!include[details](./includes/ticket-rel-def-ticket-type.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|ticket\_rel\_def\_ticket\_type\_id |PK |Clustered, Unique |
|ticket\_relation\_def\_id, source\_ticket\_type\_id, destination\_ticket\_type\_id |FK, FK, FK |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[ticket\_relation\_def](ticket-relation-def.md)  |Ticket relation definition |
|[ticket\_type](ticket-type.md)  |A ticket (request) type |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

