---
uid: crmscript_ref_NSAppointmentEntity_GetSale
title: NSSale GetSale()
intellisense: NSAppointmentEntity.GetSale
keywords: NSAppointmentEntity, GetSale
so.topic: reference
---

An appointment may also be connected to a sale, so you see the appointment on the company card, on the project card and on the sale card. This does not mean however that a sale is required.

**Returns:** NSSale


```crmscript
NSAppointmentEntity thing;
NSSale sale  = thing.GetSale();
```


