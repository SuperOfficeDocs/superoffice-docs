---
uid: crmscript_ref_NSPersonAgent_GetPersonsFromProject
title: NSPerson[] GetPersonsFromProject(Integer projectId)
intellisense: NSPersonAgent.GetPersonsFromProject
keywords: NSPersonAgent, GetPersonsFromProject
so.topic: reference
---

Returns all the persons belonging to a project.

**Parameters:**
 - **projectId** The project id

**Returns:** NSPerson[]

```crmscript
NSPersonAgent agent;
Integer projectId;
NSPerson[] res = agent.GetPersonsFromProject(projectId);
```

