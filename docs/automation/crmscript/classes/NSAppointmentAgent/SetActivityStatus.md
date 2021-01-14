---
title: Void SetActivityStatus(String[] activityIdentifier, Integer activityStatus)
path: /EJScript/Classes/NSAppointmentAgent/Member functions/Void SetActivityStatus(String[] p_0, Integer p_1)
intellisense: 1
classref: 1
sortOrder: 919
keywords: SetActivityStatus(String[],Integer)
---


Sets the completed status for an array of activities. The string activityIdentifier param may contain of a mix of appointment\_id, sale\_id, document\_id and todo\_id. The changes are saved immediately. If an invalid id is passed in (nonexistent record), no changes will be made. If there is no write access to the record being changed, a Sentry exception will be thrown in the usual manner.



* **activityIdentifier:** Array of activity ids. ex. appointment\_id=666
* **activityStatus:** The status to set the activities


