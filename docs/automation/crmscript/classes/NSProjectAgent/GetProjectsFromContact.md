---
uid: crmscript_ref_NSProjectAgent_GetProjectsFromContact
title: ProjectArray GetProjectsFromContact(Integer contactId)
intellisense: NSProjectAgent.GetProjectsFromContact
keywords: NSProjectAgent, GetProjectsFromContact
so.topic: reference
---

Returns all projects where the given contact has projectmembers.

**Parameters:**
 - **contactId** The contact id

**Returns:** ProjectListEntity

```crmscript
NSProjectAgent agent;
Integer contactId;
ProjectArray res = agent.GetProjectsFromContact(contactId);
```

