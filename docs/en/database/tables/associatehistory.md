---
uid: table-AssociateHistory
title: AssociateHistory table
description: Historical information about associates that have been deleted. Most references are NOT declared as foreign keys; this is a historical table that should not be updated when further changes occur in the database
so.generated: true
keywords: database table AssociateHistory
so.topic: reference
so.envir: onsite, online
---

# AssociateHistory Table (523)

Historical information about associates that have been deleted. Most references are NOT declared as foreign keys; this is a historical table that should not be updated when further changes occur in the database

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|associatehistory\_id|Primary key|PK| |
|associateId|The original primary key of the deleted associate|Int|&#x25CF;|
|groupId|The group id|Int|&#x25CF;|
|personId|The person id|Int|&#x25CF;|
|type|Associate type|Enum [AssociateType](enums/associatetype.md)|&#x25CF;|
|originalRegistered|Registered when|UtcDateTime|&#x25CF;|
|locationAddress|Address of location, if this is a resource that is a location|String(239)|&#x25CF;|
|ejUserId|The ejuser reference, if any|Int|&#x25CF;|
|name|The associate name/initials|String(255)|&#x25CF;|
|firstname|First name|String(99)|&#x25CF;|
|middleName|Middle name or &apos;van&apos; etc.|String(99)|&#x25CF;|
|lastname|Last name|String(99)|&#x25CF;|
|contactId|The original contact_id|Int|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |


![AssociateHistory table relationship diagram](./media/AssociateHistory.png)

[!include[details](./includes/associatehistory.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|associatehistory\_id |PK |Clustered, Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

