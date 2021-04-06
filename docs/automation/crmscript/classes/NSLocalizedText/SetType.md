---
uid: crmscript_ref_NSLocalizedText_SetType
title: SetType(Integer type)
intellisense: NSLocalizedText.SetType
keywords: NSLocalizedText, GetType
so.topic: reference
---

The type of the text string, e.g. Field label, Udef label, etc.

**Parameter:** 
 - **type** Integer
     - Enum: 0 = Unknown 
     - Enum: 1 = Label 
     - Enum: 2 = Table 
     - Enum: 3 = Column 
     - Enum: 4 = ImportField 
     - Enum: 5 = ImportObject 
     - Enum: 6 = ImportGUICategory 
     - Enum: 7 = StartupHints 
     - Enum: 11 = FunctionRightLabel 
     - Enum: 12 = FunctionRightDesc 
     - Enum: 16 = StatusMonitorName 
     - Enum: 19 = UdefContactLabel 
     - Enum: 20 = UdefPersonLabel 
     - Enum: 21 = UdefProjectLabel 
     - Enum: 22 = UdefSaleLabel 
     - Enum: 23 = UdefAppointmentLabel 
     - Enum: 24 = UdefDocumentLabel 
     - Enum: 41 = PushNotificationText 

```crmscript
NSLocalizedText thing;
Integer type;
thing.SetType(type);
```

