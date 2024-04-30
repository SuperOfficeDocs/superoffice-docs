---
title: How to create a new appointment with SoProtocol
uid: sop_create_appointment
description: How to create a new appointment with SoProtocol
author: Tony Yates
so.date: 06.24.2016
keywords: soprotocol, deeplinking, appointment
so.topic: howto
so.client: web
so.envir: onsite
---

# How to create a new appointment with SoProtocol

To create a new appointment in SuperOffice the user may either click**File – New - Appointment** or use the appointment button. The user can directly open it on the same browser by using the following SoProtocol.

> [!NOTE]
> `http://localhost/SuperOfficeWeb/` is just an example. Your local SuperOffice installation may be in a different location.

`http://localhost/SuperOfficeWeb/default.aspx?appointment[new=true]?appointment_id=0`

![11][img1]

We can select the start, end times, and the description regarding an appointment. We can also enter the details if needed and there is a special feature to invite others to the same appointment.

Here is a more complete SO Protocol string for creating an appointment with a start and end date, and a company (contact_id) with a contact (person_id), and attendees (pids):

```html
appointment[new=true]?appointment_id=0 
&appointment_type=1&doby=2024.08.14
&enddate=2024.08.14&calendarassociate_id=5&contact_id=10&person_id=15&pids=5,10,15
```

Open an appointment. The soprotocol should be on the format: appointment.main[new=true]?appointment_id=0&...other args...

The following table list all supported parameters.

| Parameter | Description |
| --- | --- |
| appointment_id | ID of the appointment to open. If set, the appointment will be opened. For new appointments this should be set to 0. |
| appointment_type | Type of the appointment. 5 = Todo, 6 = Phone. Anything else is considered a meeting. This will be used to select the task type. |
| appointmenttask_name | ID of the task to create when creating a new appointment. This lets you set an actual task instead of the default meeting, default phone and so on from appointment_type, i.e. appointmenttask_name=&lt;ID of task type&gt;.|
| appointmenttitle_name | Title of the new appointment. |
| appointmentagenda_name | Agenda of the new appointment (HTML). |
| appointmentdescription_name | Description of the new appointment (plain text). |
| doby | Start date when creating new appointment. Format: YYYY.MM.DD HH:mm. Can be without time information. |
| enddate | End date when creating new appointment. Format: YYYY.MM.DD HH:mm. |
| length | Duration when creating new appointment – set instead of enddate. If both are set, length wins. |
| usedefaulttime | This is used when creating a new appointment to indicate that the doby / enddate parameters above is missing the time component and the default time should be used. |
| calendarassociate_id | This is the owner when creating new appointment. |
| useprojectcurrent | If “true”, sets “current” project on the new appointment. For example, this is set when creating an appointment from the project activity archive. |
| usesalecurrent | If “true”, sets “current” sale on the new appointment. For example, this is set when creating an appointment from the sale activity archive. |
| reopen | If “true”, uses the current sale and CreateDefaultReopenAppointment() to create the new appointment. Set when stalling a sale. If set, we use the start and end date in the appointment returned by NetServer. |
| groupview | If in the query (any text will do) the appointment is created from the group view (Diary -> View). Any text means that groupview=true, groupview=false or groupview=something are all considered present. |
| addparticipants | If in the query (similar to groupview) and groupview is set, add participant from current group view automatically. If not set, check preference Functions -> ShowInviteDlgFromView if we should add anyway. |
| basedon | Set to an appointment ID that will be used as base of the new appointment. Conflicts with “reopen”. If both are set, then reopen wins. |
| suggestedappointment_id | Set to an appointment ID that will be used as base of the new appointment. Conflicts with similar parameters. The other parameters will win. |
| entity | Set to the entity to use with suggestedappointment_id. “project” or “sale”. If unset, but we have suggestedappointment_id, it defaults to “sale”. |
| assignto | If set to any string value, the appointment will be assigned to the requested owner. |
| create | Parameter passed to CreateDefaultAppointmentEntityFromSaleSuggestion(). Should be “true” or “false”. |

Examples:

Create a new appointment based on another appointment:

`appointment.main[new=true]?appointment_id=0&basedon=1000`

Create a follow-up on 2020-12-15 using default time (next 15-minute slot):

`appointment.main[new=true]?appointment_id=0&doby=2020.12.15 10:30&usedefaulttime=true`

## Opening an appointment

For opening an existing appointment, we don’t have to specify so much in the URL:

```html
appointment?appointment_id=2659419
```

Just the appointment ID, which tells us where to get the rest of the information in the database.

<!--**See Also:** AppointmentEntity -->

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/appointment-default.png
