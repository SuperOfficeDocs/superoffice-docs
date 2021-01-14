---
title: NSContactActivity[] GetMyActiveContacts(DateTime activityStartTime, Integer[] contactCategories, Integer actionType)
path: /EJScript/Classes/NSContactAgent/Member functions/NSContactActivity[] GetMyActiveContacts(DateTime p_0, Integer[] p_1, Integer p_2)
intellisense: 1
classref: 1
sortOrder: 1807
keywords: GetMyActiveContacts(DateTime,Integer[],Integer)
---


Returns the contacts where there has been activity since activityStartTime. If activityStartTime is larger than the current date, all contacts with activity since last log-out are returned. The result set can be filtered by category and action type.



* **activityStartTime:** The start time of the activities. If the start time is set to a future date; activites since the user last logged out are returned.
* **contactCategories:** Integer array of categories to filter on. If the array is empty contacts from all categories will be selected.
* **actionType:** The type of action that has occured. E.g. updates, deletes, new appointments, etc.
* **Returns:** Array of contacts where there have been activity in the period.


