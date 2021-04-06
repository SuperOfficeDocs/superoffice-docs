---
uid: crmscript_ref_NSAppointmentEntity_GetProject
title: Project GetProject()
intellisense: NSAppointmentEntity.GetProject
keywords: NSAppointmentEntity, GetProject
so.topic: reference
---

An appointment may also be connected to a project, so you see the appointment both on the company card, and on the project card. This does not mean however that a project is required.

**Returns:** Project


```crmscript
NSAppointmentEntity thing;
Project project  = thing.GetProject();
```


