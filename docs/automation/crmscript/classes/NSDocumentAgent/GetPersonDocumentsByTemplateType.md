---
title: NSDocument[] GetPersonDocumentsByTemplateType(Integer personId, Bool includeProjectDocuments, DateTime startTime, DateTime endTime, Integer count, Integer documentTemplateId)
path: /EJScript/Classes/NSDocumentAgent/Member functions/NSDocument[] GetPersonDocumentsByTemplateType(Integer p_0, Bool p_1, DateTime p_2, DateTime p_3, Integer p_4, Integer p_5)
intellisense: 1
classref: 1
sortOrder: 2483
keywords: GetPersonDocumentsByTemplateType(Integer,Bool,DateTime,DateTime,Integer,Integer)
---


Method that returns a specified number of document appointments within a time range, filtered by document template type. The document appointments belong to the person specified.



* **personId:** The person id of the SuperOffice user (associate).
* **includeProjectDocuments:** If true, all appointments that belong to projects where the user is a project member are included as well as the appointments belonging to the person.
* **startTime:** The start of the time interval we want appointments from. This will usually be the current time.
* **endTime:** The end of the time interval.
* **count:** The maximum number of appointments that should be returned. -1 means no count restrictions.
* **documentTemplateId:** Id of the document template type to filter on.
* **Returns:** Array of Appointments.


