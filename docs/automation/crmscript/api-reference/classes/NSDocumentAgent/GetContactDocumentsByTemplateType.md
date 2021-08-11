---
uid: crmscript_ref_NSDocumentAgent_GetContactDocumentsByTemplateType
title: NSDocument[] GetContactDocumentsByTemplateType(Integer contactId, DateTime startTime, DateTime endTime, Integer count, Integer documentTemplateId)
intellisense: NSDocumentAgent.GetContactDocumentsByTemplateType
keywords: NSDocumentAgent, GetContactDocumentsByTemplateType
so.topic: reference
---

# NSDocument[] GetContactDocumentsByTemplateType(Integer contactId, DateTime startTime, DateTime endTime, Integer count, Integer documentTemplateId)

Method that returns a specified number of document appointments within a time range, filtered by document template type. The document appointments belong to the contact specified. 

**Parameters:**
 - **contactId** The contact id
 - **startTime** The start of the time interval we want appointments from. This will usually be the current time.
 - **endTime** The end of the time interval.
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.
 - **documentTemplateId** Id of the document template type to filter on.

**Returns:** NSDocument[]

```crmscript
NSDocumentAgent agent;
Integer contactId;
DateTime startTime;
DateTime endTime;
Integer count;
Integer documentTemplateId;
NSDocument[] res = agent.GetContactDocumentsByTemplateType(contactId, startTime, endTime, count, documentTemplateId);
```

