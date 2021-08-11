---
uid: crmscript_ref_NSChatWidgetSettings_GetRequiredFields
title: NSWidgetRequiredFields GetRequiredFields()
intellisense: NSChatWidgetSettings.GetRequiredFields
keywords: NSChatWidgetSettings, GetRequiredFields
so.topic: reference
---

# NSWidgetRequiredFields GetRequiredFields()

Fields required to start a chat

**Returns:** NSWidgetRequiredFields

     - Enum: 0 = None 
     - Enum: 1 = Email 
     - Enum: 2 = Name 
     - Enum: 4 = Company 
     - Enum: 8 = Phone 

```crmscript
NSChatWidgetSettings thing;
NSWidgetRequiredFields requiredFields  = thing.GetRequiredFields();
```

