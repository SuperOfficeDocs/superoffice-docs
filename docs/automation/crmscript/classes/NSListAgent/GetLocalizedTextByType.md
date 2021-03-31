---
title: crmscript_ref_NSListAgent_GetLocalizedTextByType
description: LocalizedText GetLocalizedTextByType(Integer textType, Integer resourceId, Integer languageId)
intellisense: NSListAgent.GetLocalizedTextByType
keywords: NSListAgent,GetLocalizedTextByType
so.topic: reference
---

Returns a localized text based on the resource id for the selected language.

**Parameters:**
 - **textType** Type of the localized text
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
 - **resourceId** The resource id. This id has different meaning based on the LocalizedTextType.
 - **languageId** The LCID number of the language.

**Returns:** A LocalizedText carrier.

```crmscript
NSListAgent agent;
Integer textType;
Integer resourceId;
Integer languageId;
LocalizedText res = agent.GetLocalizedTextByType(textType, resourceId, languageId);
```

