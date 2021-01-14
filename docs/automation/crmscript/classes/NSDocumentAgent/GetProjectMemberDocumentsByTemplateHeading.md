---
title: NSDocument[] GetProjectMemberDocumentsByTemplateHeading(Integer personId, DateTime startTime, DateTime endTime, Integer count, Integer templateHeadingId)
path: /EJScript/Classes/NSDocumentAgent/Member functions/NSDocument[] GetProjectMemberDocumentsByTemplateHeading(Integer p_0, DateTime p_1, DateTime p_2, Integer p_3, Integer p_4)
intellisense: 1
classref: 1
sortOrder: 2490
keywords: GetProjectMemberDocumentsByTemplateHeading(Integer,DateTime,DateTime,Integer,Integer)
---


Method that returns a specified number of document appointments within a time range, filtered by document template heading. The document appointments belong to the project member specified. The heading represents a grouping or filtering of document templates.



* **personId:** The project member's person id
* **startTime:** The start of the time interval we want appointments from. This will usually be the current time.
* **endTime:** The end of the time interval.
* **count:** The maximum number of appointments that should be returned. -1 means no count restrictions.
* **templateHeadingId:** The document template heading id. The heading represents a grouping or filtering of document templates.
* **Returns:** Array of Appointments.


