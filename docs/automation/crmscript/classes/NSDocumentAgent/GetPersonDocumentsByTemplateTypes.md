---
title: crmscript_ref_NSDocumentAgent_GetPersonDocumentsByTemplateTypes_Integer_p_0_Bool_p_1_DateTime_p_2_DateTime_p_3_Integer_p_4_Integer__p_5
description: NSDocumentAgent.GetPersonDocumentsByTemplateTypes(Integer p_0, Bool p_1, DateTime p_2, DateTime p_3, Integer p_4, Integer[] p_5)
intellisense: NSDocumentAgent.GetPersonDocumentsByTemplateTypes
sortOrder: 2484
keywords: GetPersonDocumentsByTemplateTypes(Integer,Bool,DateTime,DateTime,Integer,Integer[])
so.topic: reference
---


Method that returns a specified number of document appointments within a time range, filtered by document template types. The document appointments belong to the person specified.



* **personId:** The person id of the SuperOffice user (associate).
* **includeProjectDocuments:** If true, all appointments that belong to projects where the user is a project member are included as well as the appointments belonging to the person.
* **startTime:** The start of the time interval we want appointments from. This will usually be the current time.
* **endTime:** The end of the time interval.
* **count:** The maximum number of appointments that should be returned. -1 means no count restrictions.
* **documentTemplateIds:** Ids of the document template types to filter on.
* **Returns:** Array of Appointments.


