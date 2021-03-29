---
title: crmscript_ref_NSDocumentAgent_GetProjectMemberDocumentsByTemplateTypes_Integer_p_0_DateTime_p_1_DateTime_p_2_Integer_p_3_Integer__p_4
description: NSDocumentAgent.GetProjectMemberDocumentsByTemplateTypes(Integer p_0, DateTime p_1, DateTime p_2, Integer p_3, Integer[] p_4)
intellisense: NSDocumentAgent.GetProjectMemberDocumentsByTemplateTypes
sortOrder: 2492
keywords: GetProjectMemberDocumentsByTemplateTypes(Integer,DateTime,DateTime,Integer,Integer[])
so.topic: reference
---


Method that returns a specified number of document appointments within a time range, filtered by document template types. The document appointments belong to the project member specified.



* **personId:** The project member's person id
* **startTime:** The start of the time interval we want appointments from. This will usually be the current time.
* **endTime:** The end of the time interval.
* **count:** The maximum number of appointments that should be returned. -1 means no count restrictions.
* **documentTemplateIds:** Ids of the document template types to filter on.
* **Returns:** Array of Appointments.


