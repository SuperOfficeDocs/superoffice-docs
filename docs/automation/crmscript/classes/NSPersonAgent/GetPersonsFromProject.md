---
title: crmscript_ref_NSPersonAgent_GetPersonsFromProject
description: PersonArray GetPersonsFromProject(Integer projectId)
intellisense: NSPersonAgent.GetPersonsFromProject
keywords: NSPersonAgent,GetPersonsFromProject
so.topic: reference
---

Returns all the persons belonging to a project.

**Parameters:**
 - **projectId** The project id

**Returns:** The persons belonging to a project.

```crmscript
NSPersonAgent agent;
Integer projectId;
PersonArray res = agent.GetPersonsFromProject(projectId);
```

