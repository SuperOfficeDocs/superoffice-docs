---
uid: enum-appointmentcautionwarning
title: Enum values for AppointmentCautionWarning
description: Lists the enum values for AppointmentCautionWarning.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# AppointmentCautionWarning Enum

Status field to indicate appointments that have some sort of problem

| Name | Value | Description |
|------|-------|-------------|
|OK|0|OK - no special warnings|
|NotInSync|1|Possibly not in sync with external systems|
|NotNotifiedByEmail|2|Updated without sending email notifications|
|RecurrencePatternNotSupported|3|This recurrence pattern might not be supported in the external participants calendars|
|IncomingRecurrenceChangeNotSupported|4|A requested change to a recurrence appointment was not supported|
|ExternalParticipantsDateTimeMismatch|5|Time and date may be wrong for external participants due to unsupported changes|

## Usage

* [appointment](../appointment.md).cautionWarning - Tasks, appointments, followups, phone calls; and documents (document_id != 0). An appointment always has a corresponding record in VisibleFor specifying who may see this. 
