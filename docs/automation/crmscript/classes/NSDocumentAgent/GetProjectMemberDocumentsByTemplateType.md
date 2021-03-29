---
title: crmscript_ref_NSDocumentAgent_GetProjectMemberDocumentsByTemplateType_Integer_p_0_DateTime_p_1_DateTime_p_2_Integer_p_3_Integer_p_4
description: NSDocumentAgent.GetProjectMemberDocumentsByTemplateType(Integer p_0, DateTime p_1, DateTime p_2, Integer p_3, Integer p_4)
intellisense: NSDocumentAgent.GetProjectMemberDocumentsByTemplateType
sortOrder: 2491
keywords: GetProjectMemberDocumentsByTemplateType(Integer,DateTime,DateTime,Integer,Integer)
so.topic: reference
---


Method that returns a specified number of document appointments within a time range, filtered by document template type. The document appointments belong to the project member specified.



* **personId:** The project member's person id
* **startTime:** The start of the time interval we want appointments from. This will usually be the current time.
* **endTime:** The end of the time interval.
* **count:** The maximum number of appointments that should be returned. -1 means no count restrictions.
* **documentTemplateId:** Id of the document template type to filter on.
* **Returns:** Array of Appointments.


