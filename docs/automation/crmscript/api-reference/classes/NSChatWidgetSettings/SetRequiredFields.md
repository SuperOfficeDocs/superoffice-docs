---
uid: crmscript_ref_NSChatWidgetSettings_SetRequiredFields
title: SetRequiredFields(NSWidgetRequiredFields requiredFields)
intellisense: NSChatWidgetSettings.SetRequiredFields
keywords: NSChatWidgetSettings, GetRequiredFields
so.topic: reference
---

# SetRequiredFields(NSWidgetRequiredFields requiredFields)

Fields required to start a chat

**Parameter:** 
 - **requiredFields** NSWidgetRequiredFields
     - Enum: 0 = None 
     - Enum: 1 = Email 
     - Enum: 2 = Name 
     - Enum: 4 = Company 
     - Enum: 8 = Phone 

```crmscript
NSChatWidgetSettings thing;
NSWidgetRequiredFields requiredFields;
thing.SetRequiredFields(requiredFields);
```

