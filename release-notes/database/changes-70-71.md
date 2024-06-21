---
title: Table changes from 7.0 to 7.1
uid: changes_70_to_71
description: Changes in SuperOffice from 7.0 to 7.1
author: {github-id}
keywords: database
topic: reference
envir: onsite
version: 7.1
# client:
---

# Table changes from 7.0 to 7.1

## New tables

### [outgoing_message][1] (407)

Delivery of outgoing messages to message plugins, updated with status asynchronously

| Field | Type | Description |
|---|---|---|
| `id` | int | The primary key (auto-incremented) |
| `session_key` | varchar(256) | Session key used for threading. |
| `external_message_id` | varchar(256) | Session key used for threading. |
| `status` | int | Current status of outgoing message |
| `status_description` | varchar(256) | Description of current status |
| `plugin` | varchar(256) | Name of plugin |
| `reg` | DateTime | Registered when |
| `reg_id` | int | Registered by whom |
| `updated` | DateTime | Last updated when |
| `update_id` | int | Last updated by whom |

## New fields on existing tables

### [Appointment][2]

| Field | Type | Description |
|---|---|---|
| `isMilestone` | ushort | Is this appointment a project milestone? In 7.1 this can only be set via the Project Guide, and not changed later |

### [Project][3]

| Field | Type | Description |
|---|---|---|
| `endDate` | DateTime | Planned end date for project, inherited from project type, and editable later |
| `nextMilestoneDate` | DateTime | Calculated date, reflects date of closest non-complete future milestone activity |
| `nmdAppointmentId` | int | ID of appointment that "caused" the `nextMilestoneDate`, can be 0 |

### [ProjType][4]

| Field | Type | Description |
|---|---|---|
| `projectDuration` | int | Is this appointment a project milestone? In 7.1 this can only be set via the Project Guide, and not changed later |
| `durationUnit` | short | Units for the duration |
| `hasGuide` | short | Does this project type have a guide attached |
| `isAutoAdvance` | short | Does the project status advance automatically, when the last guided activity in a status is completed? |

### [SuggestedAppointment][5]

| Field | Type | Description |
|---|---|---|
| `isMilestone` | ushort | Is this kind of appointment a milestone in a project |
| `assignToMember` | short | Should generated appointment be assigned to a project member? |

### [SaleType][6]

| Field | Type | Description |
|---|---|---|
| `hasStakeholders` | short | this sale type have stakeholders? |

### [ticket][7]

| Field | Type | Description |
|---|---|---|
| `origin` | short | What is the origin of this ticket |

### [extra\_menus][8]

| Field | Type | Description |
|---|---|---|
| `base_program` | short | Base program used in URL (ticket, rms, ...) |
| `extra_table` | int | ExtraTable that the menu is connected to |

### [s\_link][9]

| Field | Type | Description |
|---|---|---|
| `action_flags` | short | Bitmask defining what action should be taken |
| `add_contact_interest` | int | Contact interest to add to recipient person |
| `remove_contact_interest` | int | Person interest to remove from recipient person |
| `add_person_interest` | int | Person interest to add to recipient person |
| `remove_person_interest` | int | Person interest to remove from recipient person |
| `add_contact_selection` | int | Static contact selection to add person to |
| `remove_contact_selection` | int | Static contact selection to remove person from |
| `add_project` | int | Project to add person to, as member |
| `remove_project` | int | Project to remove person from, as member |
| `task_text` | varchar(2048) | Text of task to be created |
| `task_idx` | int | Task type of new task |
| `task_flags` | short | Flags that control how the task is created |
| `task_associate_id` | int | Associate whose diary should receive the task or assignment (unless AssignToOurContact is specified) |
| `task_creating_associate_id` | int | Associate who should stand as creator of task; also works as fallback if an assigned task is rejected. Usually, the associate who ordered the shipment |
| `task_project` | int | Project to connect task to, can be 0 |
| `task_start` | DateTime | Start time of task, unless UseNextAvailableTime is specified |
| `task_duration` | int | Task duration in minutes |

### [s\_shipment\_addr][10]

| Field | Type | Description |
|---|---|---|
| `ticket_id` | int | Id of the ticket if this entry is created by a `ticketSelection` list |
| `status` | short | Status for sending to this particular recipient |
| `contact_id` | int | Id of contact bound to shipment address |
| `sending_time` | DateTime | Estimated or actual sent time (depends on status) |

### [s\_list\_shipment][11]

| Field | Type | Description |
|---|---|---|
| `status` | short | Status of shipment list |

### [inbox][12]

| Field | Type | Description |
|---|---|---|
| `plugin` | varchar(256) | Name of plugin that created this inbox |
| `format` | varchar(256) | Format of the inbox entry |

### [sms][13]

| Field | Type | Description |
|---|---|---|
| `session_key` | varchar(256) | The reference used for identifying a session, like in-reply-to and message ID |
| `outgoing_message_id` | int | Reference to the outgoing message entry created by NetServer for sending and status update |

<!-- Referenced links -->
[1]: ../../docs/en/database/tables/outgoing-message.md
[2]: ../../docs/en/database/tables/appointment.md
[3]: ../../docs/en/database/tables/project.md
[4]: ../../docs/en/database/tables/projtype.md
[5]: ../../docs/en/database/tables/suggestedappointment.md
[6]: ../../docs/en/database/tables/saletype.md
[7]: ../../docs/en/database/tables/ticket.md
[8]: ../../docs/en/database/tables/extra-menus.md
[9]: ../../docs/en/database/tables/s-link.md
[10]: ../../docs/en/database/tables/s-shipment-addr.md
[11]: ../../docs/en/database/tables/s-list-shipment.md
[12]: ../../docs/en/database/tables/inbox.md
[13]: ../../docs/en/database/tables/sms.md
