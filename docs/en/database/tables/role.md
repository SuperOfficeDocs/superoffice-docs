---
uid: table-Role
title: Role table
description: User roles for role-based security, names and tooltips are in LocaleText. For more information regarding role based security, see http;//techdoc.superoffice.com
so.generated: true
keywords: database table Role
so.topic: reference
so.envir: onsite, online
---

# Role Table (191)

User roles for role-based security, names and tooltips are in LocaleText. For more information regarding role based security, see http;//techdoc.superoffice.com

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|Role\_id|Primary key|PK| |
|name|Visible role name|String(239)|&#x25CF;|
|rank|Sorting rank of this role in lists|UShort| |
|tooltip|Visible tooltip|String(254)|&#x25CF;|
|deleted|1 if role has been deleted (we do not actually delete)|UShort| |
|roleType|0 = employee, 1 = external user, 2 = anonymous|Enum [RoleType](enums/roletype.md)| |
|encryptedCheck|Encrypted data, to detect unwanted changes|String(254)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |
|use\_categories|Override user categories with role categories|Bool|&#x25CF;|


![Role table relationship diagram](./media/Role.png)

[!include[details](./includes/role.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|Role\_id |PK |Clustered, Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[DataRight](dataright.md)  |Data right definition |
|[FunctionRightRoleLink](functionrightrolelink.md)  |Functional right definition |
|[role\_category](role-category.md)  |Category membership associated with a role |
|[role\_element](role-element.md)  |Profiles associated with a role |
|[role\_workflow](role-workflow.md)  |Knowledge base workflow access rights associated with a role |
|[text](text.md)  |Long text fields from all over the system |
|[UserRoleLink](userrolelink.md)  |Link between user role and user |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

