---
title: crmscript_ref_NSDocumentAgent_GetPublishedDocumentsByDate_Integer_p_0_Bool_p_1_DateTime_p_2_DateTime_p_3_Integer_p_4
description: NSDocumentAgent.GetPublishedDocumentsByDate(Integer p_0, Bool p_1, DateTime p_2, DateTime p_3, Integer p_4)
intellisense: NSDocumentAgent.GetPublishedDocumentsByDate
sortOrder: 2494
keywords: GetPublishedDocumentsByDate(Integer,Bool,DateTime,DateTime,Integer)
so.topic: reference
---


Method that returns a specified number of published document appointments within a time range. The document appointments is visible to the person specified or the document is in a project the person belongs to.



* **personId:** The personId
* **includeProjectDocuments:** Include projectDocuments to select documents in projects person is a member of.
* **startTime:** The start of the time interval we want appointments from. This will usually be the current time.
* **endTime:** The end of the time interval.
* **count:** The maximum number of appointments that should be returned. -1 means no count restrictions.
* **Returns:** Array of Appointments.


