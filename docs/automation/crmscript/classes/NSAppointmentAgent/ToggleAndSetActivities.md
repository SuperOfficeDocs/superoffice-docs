---
title: crmscript_ref_NSAppointmentAgent_ToggleAndSetActivities_String__p_0
description: NSAppointmentAgent.ToggleAndSetActivities(String[] p_0)
intellisense: NSAppointmentAgent.ToggleAndSetActivities
sortOrder: 908
keywords: ToggleAndSetActivities(String[])
so.topic: reference
---


Toggles the first activity and sets the rest of the activities to the result of the first toggle. However, there are some special rules for appointments that trigger a suggested appointment when they are completed. If more than one appointment in the set of identifiers triggers a suggestion, we will not toggle those appointments. This rule is only active when changing the status of an appointment to complete. There must be more than one appointment that triggers such an event for this rule to take effect.



* **activityIdentifiers:** Array of activity ids. ex. appointment\_id=666
* **Returns:** The identifiers that were not toggled.


