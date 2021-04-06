---
uid: crmscript_ref_NSAppointmentAgent_ToggleActivity
title: Integer ToggleActivity(String activityIdentifier)
intellisense: NSAppointmentAgent.ToggleActivity
keywords: NSAppointmentAgent, ToggleActivity
so.topic: reference
---

Toggle the completed status for an activity. Activity may be sale, document or appointment. The changes are saved immediately. 

**Parameters:**
 - **activityIdentifier** May contain of a mix of appointment_id, sale_id, document_id and todo_id

**Returns:** What the result after toggling was.

```crmscript
NSAppointmentAgent agent;
String activityIdentifier;
Integer res = agent.ToggleActivity(activityIdentifier);
```

