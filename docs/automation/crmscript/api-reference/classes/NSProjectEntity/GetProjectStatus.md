---
uid: crmscript_ref_NSProjectEntity_GetProjectStatus
title: NSProjectStatus GetProjectStatus()
intellisense: NSProjectEntity.GetProjectStatus
keywords: NSProjectEntity, GetProjectStatus
so.topic: reference
---

# NSProjectStatus GetProjectStatus()

Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on

**Returns:** NSProjectStatus

```crmscript
NSProjectEntity thing;
NSProjectStatus projectStatus  = thing.GetProjectStatus();
```

