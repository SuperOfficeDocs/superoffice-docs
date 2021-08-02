---
uid: crmscript_ref_NSProjectAgent_DeleteProjectEventEntityFromProjectId
title: Void DeleteProjectEventEntityFromProjectId(Integer projectId)
intellisense: NSProjectAgent.DeleteProjectEventEntityFromProjectId
keywords: NSProjectAgent, DeleteProjectEventEntityFromProjectId
so.topic: reference
---

Delete a project event based on a project id. Does not delete the project, but does delete the published and ExternalEvent and AudienceVisibility records.

**Parameters:**
 - **projectId** The project id of the external event to delete.

```crmscript
NSProjectAgent agent;
Integer projectId;
agent.DeleteProjectEventEntityFromProjectId(projectId);
```

