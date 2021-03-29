---
title: crmscript_ref_NSDocumentAgent_GetProjectDocuments_Integer_p_0_DateTime_p_1_DateTime_p_2_Integer_p_3
description: NSDocumentAgent.GetProjectDocuments(Integer p_0, DateTime p_1, DateTime p_2, Integer p_3)
intellisense: NSDocumentAgent.GetProjectDocuments
sortOrder: 2485
keywords: GetProjectDocuments(Integer,DateTime,DateTime,Integer)
so.topic: reference
---


Method that returns a specified number of document appointments within a time range. The document appointments belong to the project specified.



* **projectId:** The project id
* **startTime:** The start of the time interval we want appointments from. This will usually be the current time.
* **endTime:** The end of the time interval.
* **count:** The maximum number of appointments that should be returned. -1 means no count restrictions.
* **Returns:** Array of Appointments.


