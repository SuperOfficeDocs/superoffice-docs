---
uid: crmscript_ref_NSExtAppEntity_GetShowState
title: Integer GetShowState()
intellisense: NSExtAppEntity.GetShowState
keywords: NSExtAppEntity, GetShowState
so.topic: reference
---

# Integer GetShowState()

The application is shown in which state Minimized, Maximized or Restored

**Returns:** Integer

     - Enum: 0 = Minimized 
     - Enum: 1 = Maximized 
     - Enum: 2 = Default 
     - Enum: 256 = ToolBar 
     - Enum: 512 = AddressBar 
     - Enum: 1024 = StatusBar 
     - Enum: 2048 = MenuBar 

```crmscript
NSExtAppEntity thing;
Integer showState  = thing.GetShowState();
```

