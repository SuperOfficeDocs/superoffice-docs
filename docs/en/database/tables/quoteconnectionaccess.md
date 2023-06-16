---
uid: table-QuoteConnectionAccess
title: QuoteConnectionAccess table
description: Access control for Quote Connections
so.generated: true
keywords: database table QuoteConnectionAccess
so.topic: reference
so.envir: onsite, online
---

# QuoteConnectionAccess Table (27)

Access control for Quote Connections

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|quoteconnectionaccess\_id|Primary key|PK| |
|QuoteConnectionId|Link to quote connection we&apos;re granting access for|FK [QuoteConnection](quoteconnection.md)| |
|AssociateId|If set, then this row grants access for a particular associate|FK [associate](associate.md)|&#x25CF;|
|UserGroupId|If set, then this row grants access for a particular group of users|FK [UserGroup](usergroup.md)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![QuoteConnectionAccess table relationship diagram](./media/QuoteConnectionAccess.png)

[!include[details](./includes/quoteconnectionaccess.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|quoteconnectionaccess\_id |PK |Clustered, Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[QuoteConnection](quoteconnection.md)  |Primary key in the CRM database. Definition of a connection to an external system, for the Quote system. |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

