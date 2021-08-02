---
uid: crmscript_ref_NSAppointmentAgent_GetAppointmentRecords
title: NSAppointment[] GetAppointmentRecords(Integer motherId, Integer recurrenceRuleId)
intellisense: NSAppointmentAgent.GetAppointmentRecords
keywords: NSAppointmentAgent, GetAppointmentRecords
so.topic: reference
---

Get all records involved in a booking and/or recurring appointments. MotherId can be zero for repeating appointments or bookings, and recurrenceRuleId can be zero for bookings that are not repeating.

**Parameters:**
 - **motherId** Appointment id of the owner of a booking
 - **recurrenceRuleId** RecurrenceId of a recuring appointment
