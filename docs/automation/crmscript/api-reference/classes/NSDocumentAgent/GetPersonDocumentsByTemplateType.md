---
uid: crmscript_ref_NSDocumentAgent_GetPersonDocumentsByTemplateType
title: NSDocument[] GetPersonDocumentsByTemplateType(Integer personId, Bool includeProjectDocuments, DateTime startTime, DateTime endTime, Integer count, Integer documentTemplateId)
intellisense: NSDocumentAgent.GetPersonDocumentsByTemplateType
keywords: NSDocumentAgent, GetPersonDocumentsByTemplateType
so.topic: reference
---

Method that returns a specified number of document appointments within a time range, filtered by document template type. The document appointments belong to the person specified. 

**Parameters:**
 - **personId** The person id of the SuperOffice user (associate).
 - **includeProjectDocuments** If true, all appointments that belong to projects where the user is a project member are included as well as the appointments belonging to the person.
 - **startTime** The start of the time interval we want appointments from. This will usually be the current time.
 - **endTime** The end of the time interval.
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.
 - **documentTemplateId** Id of the document template type to filter on.

**Returns:** NSDocument[]

```crmscript
NSDocumentAgent agent;
Integer personId;
Bool includeProjectDocuments;
DateTime startTime;
DateTime endTime;
Integer count;
Integer documentTemplateId;
NSDocument[] res = agent.GetPersonDocumentsByTemplateType(personId, includeProjectDocuments, startTime, endTime, count, documentTemplateId);
```

