---
uid: crmscript_ref_NSAppointmentEntity_SetSale
title: SetSale(NSSale sale)
intellisense: NSAppointmentEntity.SetSale
keywords: NSAppointmentEntity, GetSale
so.topic: reference
---

# SetSale(NSSale sale)

An appointment may also be connected to a sale, so you see the appointment on the company card, on the project card and on the sale card. This does not mean however that a sale is required.

**Parameter:** 
 - **sale** NSSale

```crmscript
NSAppointmentEntity thing;
NSSale sale;
thing.SetSale(sale);
```

