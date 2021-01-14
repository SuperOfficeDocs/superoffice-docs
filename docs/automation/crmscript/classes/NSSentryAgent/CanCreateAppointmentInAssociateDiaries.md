---
title: Bool CanCreateAppointmentInAssociateDiaries(Integer[] associateIds)
path: /EJScript/Classes/NSSentryAgent/Member functions/Bool CanCreateAppointmentInAssociateDiaries(Integer[] p_0)
intellisense: 1
classref: 1
keywords: CanCreateAppointmentInAssociateDiaries(Integer[])
---


CanCreateAppointmentInAssociateDiaries will check if the current associate can create appointments in diaries belonging to the associates listed in associateIds. CanCreateAppointmentInAssociateDiaries will only check against associates that are diary owners. If none of the associates listed in the associateIds parameter is a diary owner, the method will return true.



* **associateIds:** Array of associate ids to check.
* **Returns:** Returns true if the current associate can create appointments in the diary of all the other associates, otherwise false.


