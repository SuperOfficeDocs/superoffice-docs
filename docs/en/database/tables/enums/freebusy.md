---
uid: enum-freebusy
title: Enum values for FreeBusy
description: Lists the enum values for FreeBusy.
generated: true
keywords: database enum
content_type: reference
envir: onsite, online
---

# FreeBusy Enum

Default value for Free/Busy indicator

| Name | Value | Description |
|------|-------|-------------|
|Busy|0||
|Free|1||

## Usage

* [appointment](../appointment.md).freeBusy - Tasks, appointments, followups, phone calls; and documents (document_id != 0). An appointment always has a corresponding record in VisibleFor specifying who may see this. 
* [Task](../task.md).defaultFreeBusy - Task list table, activity types, like Phone, Meeting
