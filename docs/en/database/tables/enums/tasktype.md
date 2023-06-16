---
uid: enum-tasktype
title: Enum values for TaskType
description: Lists the enum values for TaskType.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# TaskType Enum

1 = app, 2 = doc, 3 = email, 4 = fax, 5 = phone, 6 = todo - see EAppntRecordTypes

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|This task is of an unknown/undecided type|
|Appointment|1|The task is an appointment|
|Document|2|The task is a document|
|Email|3|The task is an email|
|Fax|4|The task is a fax|
|Phone|5|The task is a phone call|
|ToDo|6|The task is a To-do|
|MailMergeDraft|7|Mail merge draft document|
|MailMergeFinal|8|Merged result of mail merge|
|Report|9|Saved report run|
|SaintAll|10|All' choice for Saint, every activity is recorded under this type as well as the specific type. This is NOT an acceptable value for an individual activity|

## Usage

* [Task](../task.md).record_type - Task list table, activity types, like Phone, Meeting
