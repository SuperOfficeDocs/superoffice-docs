---
uid: crmscript_ref_NSPocketNotificationMessage_SetType
title: SetType(Integer type)
intellisense: NSPocketNotificationMessage.SetType
keywords: NSPocketNotificationMessage, GetType
so.topic: reference
---

# SetType(Integer type)

The type of notification this is

**Parameter:** 
 - **type** Integer
     - Enum: 0 = Message 
     - Enum: 1 = ImportantMessage 
     - Enum: 2 = RemoteAction 
     - Enum: 3 = YesNoQuestion 
     - Enum: 4 = ShowWebPage 

```crmscript
NSPocketNotificationMessage thing;
Integer type;
thing.SetType(type);
```

