---
uid: crmscript_ref_NSProjectAgent_GetPublishedProjectsOnPersonId
title: Project[] GetPublishedProjectsOnPersonId(Integer personId)
intellisense: NSProjectAgent.GetPublishedProjectsOnPersonId
keywords: NSProjectAgent, GetPublishedProjectsOnPersonId
so.topic: reference
---

Get published projects where person  is a member

**Parameters:**
 - **personId** The person id

**Returns:** Array of project

```crmscript
NSProjectAgent agent;
Integer personId;
Project[] res = agent.GetPublishedProjectsOnPersonId(personId);
```

