---
uid: crmscript_ref_NSProjectAgent_GetProjectsFromPerson
title: ProjectArray GetProjectsFromPerson(Integer personId)
intellisense: NSProjectAgent.GetProjectsFromPerson
keywords: NSProjectAgent, GetProjectsFromPerson
so.topic: reference
---

Return all projects where the person is project member.

**Parameters:**
 - **personId** The person id

**Returns:** ProjectListEntity

```crmscript
NSProjectAgent agent;
Integer personId;
ProjectArray res = agent.GetProjectsFromPerson(personId);
```

