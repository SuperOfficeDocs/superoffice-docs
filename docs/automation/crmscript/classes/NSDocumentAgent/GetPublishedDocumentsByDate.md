---
title: NSDocument[] GetPublishedDocumentsByDate(Integer personId, Bool includeProjectDocuments, DateTime startTime, DateTime endTime, Integer count)
path: /EJScript/Classes/NSDocumentAgent/Member functions/NSDocument[] GetPublishedDocumentsByDate(Integer p_0, Bool p_1, DateTime p_2, DateTime p_3, Integer p_4)
intellisense: 1
classref: 1
sortOrder: 2494
keywords: GetPublishedDocumentsByDate(Integer,Bool,DateTime,DateTime,Integer)
---


Method that returns a specified number of published document appointments within a time range. The document appointments is visible to the person specified or the document is in a project the person belongs to.



* **personId:** The personId
* **includeProjectDocuments:** Include projectDocuments to select documents in projects person is a member of.
* **startTime:** The start of the time interval we want appointments from. This will usually be the current time.
* **endTime:** The end of the time interval.
* **count:** The maximum number of appointments that should be returned. -1 means no count restrictions.
* **Returns:** Array of Appointments.


