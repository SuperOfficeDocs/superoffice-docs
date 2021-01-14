---
title: String[] ToggleAndSetActivities(String[] activityIdentifiers)
path: /EJScript/Classes/NSAppointmentAgent/Member functions/String[] ToggleAndSetActivities(String[] p_0)
intellisense: 1
classref: 1
sortOrder: 908
keywords: ToggleAndSetActivities(String[])
---


Toggles the first activity and sets the rest of the activities to the result of the first toggle. However, there are some special rules for appointments that trigger a suggested appointment when they are completed. If more than one appointment in the set of identifiers triggers a suggestion, we will not toggle those appointments. This rule is only active when changing the status of an appointment to complete. There must be more than one appointment that triggers such an event for this rule to take effect.



* **activityIdentifiers:** Array of activity ids. ex. appointment\_id=666
* **Returns:** The identifiers that were not toggled.


