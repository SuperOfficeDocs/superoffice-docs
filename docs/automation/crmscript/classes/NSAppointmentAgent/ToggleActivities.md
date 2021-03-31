---
title: crmscript_ref_NSAppointmentAgent_ToggleActivities
description: Integer ToggleActivities(StringArray activityIdentifier)
intellisense: NSAppointmentAgent.ToggleActivities
keywords: NSAppointmentAgent,ToggleActivities
so.topic: reference
---

Toggle the completed status for an array of activities. 

**Parameters:**
 - **activityIdentifier** Contain of a mix of appointment_id, sale_id, document_id and todo_id.

**Returns:** The resulting ActivityStatus of the first in the array

```crmscript
NSAppointmentAgent agent;
StringArray activityIdentifier;
Integer res = agent.ToggleActivities(activityIdentifier);
```

