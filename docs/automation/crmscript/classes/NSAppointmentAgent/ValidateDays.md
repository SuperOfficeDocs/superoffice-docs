---
title: crmscript_ref_NSAppointmentAgent_ValidateDays
description: RecurrenceDateArray ValidateDays(AppointmentEntity appointmentEntity, DateTimeArray dates)
intellisense: NSAppointmentAgent.ValidateDays
keywords: NSAppointmentAgent,ValidateDays
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
DateTimeArray dates;
RecurrenceDateArray res = agent.ValidateDays(appointmentEntity, dates);
```

