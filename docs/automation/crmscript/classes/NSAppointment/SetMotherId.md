---
title: crmscript_ref_NSAppointment_SetMotherId
description: NSAppointment.SetMotherId(Integer motherId)
intellisense: NSAppointment.SetMotherId
keywords: NSAppointment, GetMotherId
so.topic: reference
---

ID of mother appointment; self if booking master, master ID if booking slave, 0 if normal appointment. However, if 0 and assoc_id != reg_id then this is an assigned appointment, indicated vt type = kBooking

**Parameter:** 
 - **motherId** Integer

