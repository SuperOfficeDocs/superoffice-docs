---
uid: erpconnectionaccess
title: erpconnectionaccess table
description: Access control for Erp Connections
so.generated: true
keywords:
  - "database"
  - "erpconnectionaccess"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ErpConnectionAccess Table (420)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|erpconnectionaccess\_id|Primary key|PK| |
|ErpConnectionId|Link to Erp connection we&apos;re granting access for|FK [ErpConnection](ErpConnection.md)| |
|AssociateId|If set, then this row grants access for a particular associate|FK [associate](associate.md)|&#x25CF;|
|UserGroupId|If set, then this row grants access for a particular group of users|FK [UserGroup](UserGroup.md)|&#x25CF;|
|CanConnect|If set, then this user/group is allowed to create and break connections between EXISTING actors in ERP and CRM|Bool|&#x25CF;|
|CanCreateERP|If set, then this user/group is allowed to create NEW actors in ERP and connect them to CRM|Bool|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ErpConnectionAccess table relationship diagram](media\ErpConnectionAccess.png)

[!include[details](./includes/ErpConnectionAccess.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|erpconnectionaccess\_id |PK |Clustered, Unique |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

