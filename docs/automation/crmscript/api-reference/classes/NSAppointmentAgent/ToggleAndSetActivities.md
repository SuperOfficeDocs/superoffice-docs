---
uid: crmscript_ref_NSAppointmentAgent_ToggleAndSetActivities
title: String[] ToggleAndSetActivities(String[] activityIdentifiers)
intellisense: NSAppointmentAgent.ToggleAndSetActivities
keywords: NSAppointmentAgent, ToggleAndSetActivities
so.topic: reference
---

Toggles the first activity and sets the rest of the activities to the result of the first toggle. However, there are some special rules for appointments that trigger a suggested appointment when they are completed. If more than one appointment in the set of identifiers triggers a suggestion, we will not toggle those appointments. This rule is only active when changing the status of an appointment to complete. There must be more than one appointment that triggers such an event for this rule to take effect.

**Parameters:**
 - **activityIdentifiers** Array of activity ids. ex. appointment_id=666

**Returns:** The identifiers that were not toggled.

```crmscript
NSAppointmentAgent agent;
String[] activityIdentifiers;
String[] res = agent.ToggleAndSetActivities(activityIdentifiers);
```

