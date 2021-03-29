---
title: crmscript_ref_NSDocumentAgent_GetContactDocumentsByTemplateHeading_Integer_p_0_DateTime_p_1_DateTime_p_2_Integer_p_3_Integer_p_4
description: NSDocumentAgent.GetContactDocumentsByTemplateHeading(Integer p_0, DateTime p_1, DateTime p_2, Integer p_3, Integer p_4)
intellisense: NSDocumentAgent.GetContactDocumentsByTemplateHeading
sortOrder: 2474
keywords: GetContactDocumentsByTemplateHeading(Integer,DateTime,DateTime,Integer,Integer)
so.topic: reference
---


Method that returns a specified number of document appointments within a time range, filtered by the document template heading. The document appointments belong to the contact specified. The heading represents a grouping or filtering of document templates.



* **contactId:** The contact id
* **startTime:** The start of the time interval we want appointments from. This will usually be the current time.
* **endTime:** The end of the time interval.
* **count:** The maximum number of appointments that should be returned. -1 means no count restrictions.
* **templateHeadingId:** The document template heading id. The heading represents a grouping or filtering of document templates.
* **Returns:** Array of Appointments.


