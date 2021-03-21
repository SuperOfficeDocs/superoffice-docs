---
uid: enum-appointmentcautionwarning
title: Enum values for AppointmentCautionWarning
description: Lists the enum values for AppointmentCautionWarning.
so.generated: true
keywords:
  - "database"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# AppointmentCautionWarning Enum

Status field to indicate appointments that have some sort of problem

* OK = 0
* NotInSync = 1
* NotNotifiedByEmail = 2
* RecurrencePatternNotSupported = 3
* IncomingRecurrenceChangeNotSupported = 4
* ExternalParticipantsDateTimeMismatch = 5

## Usage

* [appointment](../appointment.md).cautionWarning - Tasks, appointments, followups, phone calls; and documents (document_id != 0). An appointment always has a corresponding record in VisibleFor specifying who may see this. 
