---
uid: crmscript_ref_NSListAgent_GetLocalizedTextsByType
title: LocalizedTextArray GetLocalizedTextsByType(LocalizedTextTypeArray textTypes)
intellisense: NSListAgent.GetLocalizedTextsByType
keywords: NSListAgent, GetLocalizedTextsByType
so.topic: reference
---

Gets localized text by their type

**Parameters:**
 - **textTypes** Array of LocalizedTextTypes. If null all texts are returned.
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

**Returns:** Array of LocalizedText objects

```crmscript
NSListAgent agent;
LocalizedTextTypeArray textTypes;
LocalizedTextArray res = agent.GetLocalizedTextsByType(textTypes);
```

