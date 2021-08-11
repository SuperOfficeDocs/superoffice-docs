---
uid: crmscript_ref_NSDocumentAgent_GetContactDocumentsByTemplateHeading
title: NSDocument[] GetContactDocumentsByTemplateHeading(Integer contactId, DateTime startTime, DateTime endTime, Integer count, Integer templateHeadingId)
intellisense: NSDocumentAgent.GetContactDocumentsByTemplateHeading
keywords: NSDocumentAgent, GetContactDocumentsByTemplateHeading
so.topic: reference
---

# NSDocument[] GetContactDocumentsByTemplateHeading(Integer contactId, DateTime startTime, DateTime endTime, Integer count, Integer templateHeadingId)

Method that returns a specified number of document appointments within a time range, filtered by the document template heading. The document appointments belong to the contact specified. The heading represents a grouping or filtering of document templates.

**Parameters:**
 - **contactId** The contact id
 - **startTime** The start of the time interval we want appointments from. This will usually be the current time.
 - **endTime** The end of the time interval.
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.
 - **templateHeadingId** The document template heading id. The heading represents a grouping or filtering of document templates.

**Returns:** NSDocument[]

```crmscript
NSDocumentAgent agent;
Integer contactId;
DateTime startTime;
DateTime endTime;
Integer count;
Integer templateHeadingId;
NSDocument[] res = agent.GetContactDocumentsByTemplateHeading(contactId, startTime, endTime, count, templateHeadingId);
```

