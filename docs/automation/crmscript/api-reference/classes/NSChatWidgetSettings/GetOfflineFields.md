---
uid: crmscript_ref_NSChatWidgetSettings_GetOfflineFields
title: NSWidgetRequiredFields GetOfflineFields()
intellisense: NSChatWidgetSettings.GetOfflineFields
keywords: NSChatWidgetSettings, GetOfflineFields
so.topic: reference
---

Required field when creating ticket in offline mode

**Returns:** NSWidgetRequiredFields

     - Enum: 0 = None 
     - Enum: 1 = Email 
     - Enum: 2 = Name 
     - Enum: 4 = Company 
     - Enum: 8 = Phone 

```crmscript
NSChatWidgetSettings thing;
NSWidgetRequiredFields offlineFields  = thing.GetOfflineFields();
```


