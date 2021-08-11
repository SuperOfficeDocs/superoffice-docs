---
uid: crmscript_ref_NSAppointmentEntity_GetCentralserviceVideomeetId
title: String GetCentralserviceVideomeetId()
intellisense: NSAppointmentEntity.GetCentralserviceVideomeetId
keywords: NSAppointmentEntity, GetCentralserviceVideomeetId
so.topic: reference
---

# String GetCentralserviceVideomeetId()

GUID for video meeting in central services – this is set when we create meetings from SuperOffice. It is blank for incoming meetings created from inbox.

**Returns:** String

```crmscript
NSAppointmentEntity thing;
String centralserviceVideomeetId  = thing.GetCentralserviceVideomeetId();
```

