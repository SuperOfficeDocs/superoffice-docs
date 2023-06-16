---
uid: table-Task
title: Task table
description: Task list table, activity types, like Phone, Meeting
so.generated: true
keywords: database table Task
so.topic: reference
so.envir: onsite, online
---

# Task Table (67)

Task MDO list item table.
Task list table, activity types, like Phone, Meeting

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|Task\_id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|record\_type|1 = app, 2 = doc, 3 = email, 4 = fax, 5 = phone, 6 = todo - see EAppntRecordTypes|Enum [TaskType](enums/tasktype.md)| |
|direction|1 = incoming, 2 = outgoing, see EAppntDirection|Enum [TaskDirection](enums/taskdirection.md)|&#x25CF;|
|color\_index|JAP|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |
|defaultAlldayEvent|Default value for alldayEvent flag|Enum [AllDayEvent](enums/alldayevent.md)|&#x25CF;|
|defaultFreeBusy|Default value for Free/Busy indicator|Enum [FreeBusy](enums/freebusy.md)|&#x25CF;|
|defaultPublishType|Should this field be published by default?|Enum [PublishType](enums/publishtype.md)|&#x25CF;|
|intentId|Link to the intention of this kind of task (used by SAINT)|FK [Intent](intent.md)|&#x25CF;|
|default\_videomeeting\_status|Default video-meeting status for meetings created in SuperOffice CRM.|Enum [VideoMeetingStatus](enums/videomeetingstatus.md)| |


![Task table relationship diagram](./media/Task.png)

[!include[details](./includes/task.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|Task\_id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[appointment](appointment.md)  |Tasks, appointments, followups, phone calls; and documents (document_id != 0). An appointment always has a corresponding record in VisibleFor specifying who may see this.  |
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[ExternalEvent](externalevent.md)  |The definition of projects as events in Audience (or other Collaborative apps) |
|[Intent](intent.md)  |Intent list for SAINT. More information regarding SuperOffice Sales Intelligence on http://techdoc.superoffice.com  |
|[s\_link](s-link.md)  |Links in messages to measure success rate of a campaign. |
|[StatusDef](statusdef.md)  |Status definitions. Name and description are in LocaleText for internationalization |
|[SuggestedAppointment](suggestedappointment.md)  |Defines a suggested appointment for use in a Sale Guide or Project Guide |
|[TaskGroupLink](taskgrouplink.md)  |User group link table for Task, for MDO item hiding |
|[TaskHeadingLink](taskheadinglink.md)  |Heading link table for Task, for MDO headers |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

