---
uid: crmscript_ref_NSProjectEntity_SetProjectStatus
title: SetProjectStatus(ProjectStatus projectStatus)
intellisense: NSProjectEntity.SetProjectStatus
keywords: NSProjectEntity, GetProjectStatus
so.topic: reference
---

Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on

**Parameter:** 
 - **projectStatus** ProjectStatus

```crmscript
NSProjectEntity thing;
ProjectStatus projectStatus;
thing.SetProjectStatus(projectStatus);
```

