---
uid: crmscript_ref_NSAppointmentEntity_SetCentralserviceVideomeetId
title: SetCentralserviceVideomeetId(String centralserviceVideomeetId)
intellisense: NSAppointmentEntity.SetCentralserviceVideomeetId
keywords: NSAppointmentEntity, GetCentralserviceVideomeetId
so.topic: reference
---

GUID for video meeting in central services – this is set when we create meetings from SuperOffice. It is blank for incoming meetings created from inbox.

**Parameter:** 
 - **centralserviceVideomeetId** String

```crmscript
NSAppointmentEntity thing;
String centralserviceVideomeetId;
thing.SetCentralserviceVideomeetId(centralserviceVideomeetId);
```

