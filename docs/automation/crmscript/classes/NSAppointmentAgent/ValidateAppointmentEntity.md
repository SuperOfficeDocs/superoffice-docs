---
title: crmscript_ref_NSAppointmentAgent_ValidateAppointmentEntity
description: StringDictionary ValidateAppointmentEntity(AppointmentEntity appointmentEntity)
intellisense: NSAppointmentAgent.ValidateAppointmentEntity
keywords: NSAppointmentAgent,ValidateAppointmentEntity
so.topic: reference
---

Check that entity is ready for saving.

**Parameters:**
 - **appointmentEntity** Entity to be checked.

**Returns:** Error messages tagged by field.

```crmscript
NSAppointmentAgent agent;
AppointmentEntity appointmentEntity;
StringDictionary res = agent.ValidateAppointmentEntity(appointmentEntity);
```

