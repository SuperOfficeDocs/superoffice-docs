---
uid: enum-appointmenttype
title: Enum values for AppointmentType
description: Lists the enum values for AppointmentType.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# AppointmentType Enum

where=no start time,note,docin, docout 

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|Unknown - used when initializing |
|inDiary|1|Show in diary. If overdue or done today, show in checklist also|
|inChecklist|2|Appointment is a followup with no specific starttime|
|Note|3|Paper clip on diary, expands to “post-it” note when clicked|
|Document|4|Document of any kind, including outgoing, incoming and email|
|SavedReport|5|Saved Report (i.e., not a Report Definition but the result of an actual report run)|
|BookingForDiary|6|Booking, made for diary. When accepted this will change type to inDiary|
|BookingForChecklist|7|Booking, made for check list. When accepted this will change type to inChecklist|
|MergeDraft|8|Document is a template for mailmerge operations|
|MergeFinal|9|Document is a result of a mailmerge operations (there are probably many documents like this!)|

## Usage

* [appointment](../appointment.md).type - Tasks, appointments, followups, phone calls; and documents (document_id != 0). An appointment always has a corresponding record in VisibleFor specifying who may see this. 
