---
uid: crmscript_ref_NSAlarmData_GetAppointmentText
title: String GetAppointmentText()
intellisense: NSAlarmData.GetAppointmentText
keywords: NSAlarmData, GetAppointmentText
so.topic: reference
---

# String GetAppointmentText()

The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases

**Returns:** String

```crmscript
NSAlarmData thing;
String appointmentText  = thing.GetAppointmentText();
```

