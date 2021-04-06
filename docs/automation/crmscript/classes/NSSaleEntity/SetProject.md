---
uid: crmscript_ref_NSSaleEntity_SetProject
title: SetProject(Project project)
intellisense: NSSaleEntity.SetProject
keywords: NSSaleEntity, GetProject
so.topic: reference
---

A sale may also be connected to a project, so you see the sale both on the company card, and on the project card. This does not mean that a project is required.

**Parameter:** 
 - **project** Project

```crmscript
NSSaleEntity thing;
Project project;
thing.SetProject(project);
```

