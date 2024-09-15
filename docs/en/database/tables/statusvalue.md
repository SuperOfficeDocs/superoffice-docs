---
uid: table-StatusValue
title: StatusValue table
description: Values for statuses
so.generated: true
keywords: database table StatusValue
so.topic: reference
so.envir: onsite, online
---

# StatusValue Table (199)

Values for statuses

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|StatusValue\_id|Primary key|PK| |
|StatusDef\_id|Link to statusdefinition|FK [StatusDef](statusdef.md)| |
|contact\_id|Link to contact, 0 if this status is not for contacts|FK [contact](contact.md)| |
|person\_id|Link to person, 0 if this status is not for person (always 0 in 6.0)|FK [person](person.md)| |
|project\_id|Link to project, 0 if this status is not for project|FK [project](project.md)| |
|extra1\_id|Spare ID for future links|Id| |
|extra2\_id|Spare ID for future links|Id| |
|isSignalled|1 = this status is &apos;true&apos;, and the GUI should display it|Bool| |
|needsUpdate|1 = the value is dirty and needs updating; set when the target (contact, project) is changed (or its activities and sales are changed)|Bool| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![StatusValue table relationship diagram](./media/StatusValue.png)

[!include[details](./includes/statusvalue.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|StatusValue\_id |PK |Clustered, Unique |
|StatusDef\_id |FK |Index |
|contact\_id |FK |Index |
|person\_id |FK |Index |
|project\_id |FK |Index |
|extra1\_id |Id |Index |
|extra2\_id |Id |Index |
|isSignalled |Bool |Index |
|contact\_id, isSignalled, StatusDef\_id |FK, Bool, FK |Index |
|person\_id, isSignalled, StatusDef\_id |FK, Bool, FK |Index |
|project\_id, isSignalled, StatusDef\_id |FK, Bool, FK |Index |
|extra1\_id, isSignalled, StatusDef\_id |Id, Bool, FK |Index |
|extra2\_id, isSignalled, StatusDef\_id |Id, Bool, FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[contact](contact.md)  |Companies and Organizations.   This table features a special record containing information about the contact that owns the database.   |
|[person](person.md)  |Persons in a company or an organizations. All associates have a corresponding person record |
|[project](project.md)  |Projects |
|[StatusDef](statusdef.md)  |Status definitions. Name and description are in LocaleText for internationalization |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

