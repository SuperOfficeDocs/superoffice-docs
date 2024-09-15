---
uid: table-target_group
title: target_group table
description: Info about a set of (sales, project, selection...) targets
so.generated: true
keywords: database table target_group
so.topic: reference
so.envir: onsite, online
---

# target\_group Table (500)

Info about a set of (sales, project, selection...) targets

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|target\_group\_id|Primary key|PK| |
|year|The year this set of targets are associated with (2020, 2021...)|Int|&#x25CF;|
|entity\_type|Entity type for this set of targets (Sale, Project, Selection, Appointment...)|Enum [TargetEntityType](enums/targetentitytype.md)|&#x25CF;|
|period\_type|Period type for editing this set of targets (Year, Quarter...)|Enum [TargetPeriodType](enums/targetperiodtype.md)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |
|target\_dimension\_id|Dimension this target is in|FK [target_dimension](target-dimension.md)|&#x25CF;|


![target_group table relationship diagram](./media/target_group.png)

[!include[details](./includes/target-group.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|target\_group\_id |PK |Clustered, Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[target\_dimension](target-dimension.md)  |Defining target dimension |
|[target\_period](target-period.md)  |A set of periods linked with target amounts for users/usergroups and the target groups/years. |
|[target\_revision\_history](target-revision-history.md)  |Revision history info in case the original target group or assignment info was deleted |


## Replication Flags

* None

## Security Flags

* Sentry controls access to items in this table using user's Role and data rights matrix.

