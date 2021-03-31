---
uid: crmscript_ref_NSDocumentAgent_GetContactDocumentsByTemplateTypes
title: DocumentArray GetContactDocumentsByTemplateTypes(Integer contactId, DateTime startTime, DateTime endTime, Integer count, IntegerArray documentTemplateIds)
intellisense: NSDocumentAgent.GetContactDocumentsByTemplateTypes
keywords: NSDocumentAgent, GetContactDocumentsByTemplateTypes
so.topic: reference
---

Method that returns a specified number of document appointments within a time range, filtered by document template types. The document appointments belong to the contact specified. 

**Parameters:**
 - **contactId** The contact id
 - **startTime** The start of the time interval we want appointments from. This will usually be the current time.
 - **endTime** The end of the time interval.
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.
 - **documentTemplateIds** Ids of the document template types to filter on.

**Returns:** Array of Appointments.

```crmscript
NSDocumentAgent agent;
Integer contactId;
DateTime startTime;
DateTime endTime;
Integer count;
IntegerArray documentTemplateIds;
DocumentArray res = agent.GetContactDocumentsByTemplateTypes(contactId, startTime, endTime, count, documentTemplateIds);
```

