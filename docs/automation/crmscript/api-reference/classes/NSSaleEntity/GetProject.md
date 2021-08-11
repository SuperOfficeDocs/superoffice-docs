---
uid: crmscript_ref_NSSaleEntity_GetProject
title: NSProject GetProject()
intellisense: NSSaleEntity.GetProject
keywords: NSSaleEntity, GetProject
so.topic: reference
---

# NSProject GetProject()

A sale may also be connected to a project, so you see the sale both on the company card, and on the project card. This does not mean that a project is required.

**Returns:** NSProject

```crmscript
NSSaleEntity thing;
NSProject project  = thing.GetProject();
```

