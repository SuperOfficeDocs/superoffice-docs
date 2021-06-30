---
uid: crmscript_ref_NSAppointmentAgent_ValidateDays
title: RecurrenceDate[] ValidateDays(AppointmentEntity appointmentEntity, DateTime[] dates)
intellisense: NSAppointmentAgent.ValidateDays
keywords: NSAppointmentAgent, ValidateDays
so.topic: reference
---

Validates the set of dates to calculate any conflicts.

**Parameters:**
 - **appointmentEntity** 
 - **dates** The dates to validate.

**Returns:** Array of RecurrenceDate object for each validated date.

```crmscript
NSAppointmentAgent agent;
AppointmentEntity appointmentEntity;
DateTime[] dates;
RecurrenceDate[] res = agent.ValidateDays(appointmentEntity, dates);
```

