---
title: NSDocument[] GetContactDocumentsByTemplateType(Integer contactId, DateTime startTime, DateTime endTime, Integer count, Integer documentTemplateId)
path: /EJScript/Classes/NSDocumentAgent/Member functions/NSDocument[] GetContactDocumentsByTemplateType(Integer p_0, DateTime p_1, DateTime p_2, Integer p_3, Integer p_4)
intellisense: 1
classref: 1
sortOrder: 2475
keywords: GetContactDocumentsByTemplateType(Integer,DateTime,DateTime,Integer,Integer)
---


Method that returns a specified number of document appointments within a time range, filtered by document template type. The document appointments belong to the contact specified.



* **contactId:** The contact id
* **startTime:** The start of the time interval we want appointments from. This will usually be the current time.
* **endTime:** The end of the time interval.
* **count:** The maximum number of appointments that should be returned. -1 means no count restrictions.
* **documentTemplateId:** Id of the document template type to filter on.
* **Returns:** Array of Appointments.


