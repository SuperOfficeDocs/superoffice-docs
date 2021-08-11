---
uid: crmscript_ref_NSAppointmentAgent_ValidateDays
title: NSRecurrenceDate[] ValidateDays(NSAppointmentEntity appointmentEntity, DateTime[] dates)
intellisense: NSAppointmentAgent.ValidateDays
keywords: NSAppointmentAgent, ValidateDays
so.topic: reference
---

# NSRecurrenceDate[] ValidateDays(NSAppointmentEntity appointmentEntity, DateTime[] dates)

Validates the set of dates to calculate any conflicts.

**Parameters:**
 - **appointmentEntity** 
 - **dates** The dates to validate.

**Returns:** NSRecurrenceDate[]

```crmscript
NSAppointmentAgent agent;
NSAppointmentEntity appointmentEntity;
DateTime[] dates;
NSRecurrenceDate[] res = agent.ValidateDays(appointmentEntity, dates);
```

