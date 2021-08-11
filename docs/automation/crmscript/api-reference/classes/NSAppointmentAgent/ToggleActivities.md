---
uid: crmscript_ref_NSAppointmentAgent_ToggleActivities
title: Integer ToggleActivities(String[] activityIdentifier)
intellisense: NSAppointmentAgent.ToggleActivities
keywords: NSAppointmentAgent, ToggleActivities
so.topic: reference
---

# Integer ToggleActivities(String[] activityIdentifier)

Toggle the completed status for an array of activities. 

**Parameters:**
 - **activityIdentifier** Contain of a mix of appointment_id, sale_id, document_id and todo_id.

**Returns:** The resulting ActivityStatus of the first in the array

```crmscript
NSAppointmentAgent agent;
String[] activityIdentifier;
Integer res = agent.ToggleActivities(activityIdentifier);
```

