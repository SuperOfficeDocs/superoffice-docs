---
uid: crmscript_ref_NSProjectAgent_GetPublishedProjectsOnPersonId
title: NSProject[] GetPublishedProjectsOnPersonId(Integer personId)
intellisense: NSProjectAgent.GetPublishedProjectsOnPersonId
keywords: NSProjectAgent, GetPublishedProjectsOnPersonId
so.topic: reference
---

Get published projects where person  is a member

**Parameters:**
 - **personId** The person id

**Returns:** NSProject[]

```crmscript
NSProjectAgent agent;
Integer personId;
NSProject[] res = agent.GetPublishedProjectsOnPersonId(personId);
```

