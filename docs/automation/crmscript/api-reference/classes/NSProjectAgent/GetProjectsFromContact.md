---
uid: crmscript_ref_NSProjectAgent_GetProjectsFromContact
title: NSProject[] GetProjectsFromContact(Integer contactId)
intellisense: NSProjectAgent.GetProjectsFromContact
keywords: NSProjectAgent, GetProjectsFromContact
so.topic: reference
---

# NSProject[] GetProjectsFromContact(Integer contactId)

Returns all projects where the given contact has projectmembers.

**Parameters:**
 - **contactId** The contact id

**Returns:** NSProject[]

```crmscript
NSProjectAgent agent;
Integer contactId;
NSProject[] res = agent.GetProjectsFromContact(contactId);
```

