---
uid: crmscript_ref_NSAppointmentAgent_ValidateAppointmentEntity
title: StringDictionary ValidateAppointmentEntity(NSAppointmentEntity appointmentEntity)
intellisense: NSAppointmentAgent.ValidateAppointmentEntity
keywords: NSAppointmentAgent, ValidateAppointmentEntity
so.topic: reference
---

# StringDictionary ValidateAppointmentEntity(NSAppointmentEntity appointmentEntity)

Check that entity is ready for saving.

**Parameters:**
 - **appointmentEntity** Entity to be checked.

**Returns:** Error messages tagged by field.

```crmscript
NSAppointmentAgent agent;
NSAppointmentEntity appointmentEntity;
StringDictionary res = agent.ValidateAppointmentEntity(appointmentEntity);
```

