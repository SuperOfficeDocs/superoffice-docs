---
title: crmscript_ref_NSAppointmentEntity_GetMotherId
description: NSAppointmentEntity.GetMotherId()
intellisense: NSAppointmentEntity.GetMotherId
sortOrder: 946
keywords: GetMotherId()
so.topic: reference
---


ID of mother appointment; self if booking master, master ID if booking slave, 0 if normal appointment. However, if 0 and assoc\_id != reg\_id then this is an assigned appointment, indicated vt type = kBooking



* **Returns:** Integer


