---
uid: crmscript_ref_NSAlarmData_SetAppointmentText
title: SetAppointmentText(String appointmentText)
intellisense: NSAlarmData.SetAppointmentText
keywords: NSAlarmData, GetAppointmentText
so.topic: reference
---

# SetAppointmentText(String appointmentText)

The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases

**Parameter:** 
 - **appointmentText** String

```crmscript
NSAlarmData thing;
String appointmentText;
thing.SetAppointmentText(appointmentText);
```

