---
uid: crmscript_ref_NSDocumentAgent_GetContactDocuments
title: NSDocument[] GetContactDocuments(Integer contactId, DateTime startTime, DateTime endTime, Integer count)
intellisense: NSDocumentAgent.GetContactDocuments
keywords: NSDocumentAgent, GetContactDocuments
so.topic: reference
---

# NSDocument[] GetContactDocuments(Integer contactId, DateTime startTime, DateTime endTime, Integer count)

Method that returns a specified number of document appointments within a time range. The document appointments belong to the contact specified. 

**Parameters:**
 - **contactId** The contact id
 - **startTime** The start of the time interval we want appointments from. This will usually be the current time.
 - **endTime** The end of the time interval.
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.

**Returns:** NSDocument[]

```crmscript
NSDocumentAgent agent;
Integer contactId;
DateTime startTime;
DateTime endTime;
Integer count;
NSDocument[] res = agent.GetContactDocuments(contactId, startTime, endTime, count);
```

