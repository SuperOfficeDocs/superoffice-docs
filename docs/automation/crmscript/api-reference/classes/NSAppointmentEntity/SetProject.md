---
uid: crmscript_ref_NSAppointmentEntity_SetProject
title: SetProject(NSProject project)
intellisense: NSAppointmentEntity.SetProject
keywords: NSAppointmentEntity, GetProject
so.topic: reference
---

# SetProject(NSProject project)

An appointment may also be connected to a project, so you see the appointment both on the company card, and on the project card. This does not mean however that a project is required.

**Parameter:** 
 - **project** NSProject

```crmscript
NSAppointmentEntity thing;
NSProject project;
thing.SetProject(project);
```

