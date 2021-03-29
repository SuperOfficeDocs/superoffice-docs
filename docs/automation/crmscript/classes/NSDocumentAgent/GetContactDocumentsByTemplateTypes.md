---
title: crmscript_ref_NSDocumentAgent_GetContactDocumentsByTemplateTypes_Integer_p_0_DateTime_p_1_DateTime_p_2_Integer_p_3_Integer__p_4
description: NSDocumentAgent.GetContactDocumentsByTemplateTypes(Integer p_0, DateTime p_1, DateTime p_2, Integer p_3, Integer[] p_4)
intellisense: NSDocumentAgent.GetContactDocumentsByTemplateTypes
sortOrder: 2476
keywords: GetContactDocumentsByTemplateTypes(Integer,DateTime,DateTime,Integer,Integer[])
so.topic: reference
---


Method that returns a specified number of document appointments within a time range, filtered by document template types. The document appointments belong to the contact specified.



* **contactId:** The contact id
* **startTime:** The start of the time interval we want appointments from. This will usually be the current time.
* **endTime:** The end of the time interval.
* **count:** The maximum number of appointments that should be returned. -1 means no count restrictions.
* **documentTemplateIds:** Ids of the document template types to filter on.
* **Returns:** Array of Appointments.


