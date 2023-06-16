---
uid: enum-alldayevent
title: Enum values for AllDayEvent
description: Lists the enum values for AllDayEvent.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# AllDayEvent Enum

Default value for alldayEvent flag

| Name | Value | Description |
|------|-------|-------------|
|No|0||
|Yes|1||

## Usage

* [appointment](../appointment.md).alldayEvent - Tasks, appointments, followups, phone calls; and documents (document_id != 0). An appointment always has a corresponding record in VisibleFor specifying who may see this. 
* [Task](../task.md).defaultAlldayEvent - Task list table, activity types, like Phone, Meeting
