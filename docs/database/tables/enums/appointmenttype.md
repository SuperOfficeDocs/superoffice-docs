---
uid: enum-appointmenttype
title: Enum values for AppointmentType
description: Lists the enum values for AppointmentType.
so.generated: true
keywords:
  - "database"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# AppointmentType Enum

where=no start time,note,docin, docout 

* Unknown = 0
* inDiary = 1
* inChecklist = 2
* Note = 3
* Document = 4
* SavedReport = 5
* BookingForDiary = 6
* BookingForChecklist = 7
* MergeDraft = 8
* MergeFinal = 9

## Usage

* [appointment](../appointment.md).type - Tasks, appointments, followups, phone calls; and documents (document_id != 0). An appointment always has a corresponding record in VisibleFor specifying who may see this. 
