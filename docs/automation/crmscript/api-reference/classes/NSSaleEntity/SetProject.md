---
uid: crmscript_ref_NSSaleEntity_SetProject
title: SetProject(NSProject project)
intellisense: NSSaleEntity.SetProject
keywords: NSSaleEntity, GetProject
so.topic: reference
---

A sale may also be connected to a project, so you see the sale both on the company card, and on the project card. This does not mean that a project is required.

**Parameter:** 
 - **project** NSProject

```crmscript
NSSaleEntity thing;
NSProject project;
thing.SetProject(project);
```

