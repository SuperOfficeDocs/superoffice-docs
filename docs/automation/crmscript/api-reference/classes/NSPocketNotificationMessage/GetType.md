---
uid: crmscript_ref_NSPocketNotificationMessage_GetType
title: Integer GetType()
intellisense: NSPocketNotificationMessage.GetType
keywords: NSPocketNotificationMessage, GetType
so.topic: reference
---

The type of notification this is

**Returns:** Integer

     - Enum: 0 = Message 
     - Enum: 1 = ImportantMessage 
     - Enum: 2 = RemoteAction 
     - Enum: 3 = YesNoQuestion 
     - Enum: 4 = ShowWebPage 

```crmscript
NSPocketNotificationMessage thing;
Integer type  = thing.GetType();
```


