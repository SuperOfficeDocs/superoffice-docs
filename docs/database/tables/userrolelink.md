---
uid: table-userrolelink
title: userrolelink table
description: Link between user role and user
so.generated: true
keywords:
  - "database"
  - "UserRoleLink"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# userrolelink Table (192)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|UserRoleLink\_id|Primary key|PK| |
|associate\_id|Link to associate|FK [associate](associate.md)| |
|role\_id|Link to Role|FK [role](role.md)| |
|linkType|Reserved for future extension, not used|UInt| |
|encryptedCheck|Encrypted data, to detect unwanted changes|String(254)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![UserRoleLink table relationship diagram](./media/UserRoleLink.png)

[!include[details](./includes/UserRoleLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|UserRoleLink\_id |PK |Clustered, Unique |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* Sentry controls access to items in this table using user's Role and data rights matrix on the table's parent.

