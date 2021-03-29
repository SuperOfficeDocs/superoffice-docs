---
title: crmscript_ref_NSContactAgent_GetMyActiveContacts_DateTime_p_0_Integer__p_1_Integer_p_2
description: NSContactAgent.GetMyActiveContacts(DateTime p_0, Integer[] p_1, Integer p_2)
intellisense: NSContactAgent.GetMyActiveContacts
sortOrder: 1807
keywords: GetMyActiveContacts(DateTime,Integer[],Integer)
so.topic: reference
---


Returns the contacts where there has been activity since activityStartTime. If activityStartTime is larger than the current date, all contacts with activity since last log-out are returned. The result set can be filtered by category and action type.



* **activityStartTime:** The start time of the activities. If the start time is set to a future date; activites since the user last logged out are returned.
* **contactCategories:** Integer array of categories to filter on. If the array is empty contacts from all categories will be selected.
* **actionType:** The type of action that has occured. E.g. updates, deletes, new appointments, etc.
* **Returns:** Array of contacts where there have been activity in the period.


