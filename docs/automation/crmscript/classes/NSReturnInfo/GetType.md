---
uid: crmscript_ref_NSReturnInfo_GetType
title: Integer GetType()
intellisense: NSReturnInfo.GetType
keywords: NSReturnInfo, GetType
so.topic: reference
---

How is the return value to be understood by the caller

**Returns:** Integer

     - Enum: 0 = None 
     - Enum: 1 = Message 
     - Enum: 2 = SoProtocol 
     - Enum: 3 = CustomGui 
     - Enum: 4 = Other 
     - Enum: 5 = URL 

```crmscript
NSReturnInfo thing;
Integer type  = thing.GetType();
```


