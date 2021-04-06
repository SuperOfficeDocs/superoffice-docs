---
uid: crmscript_ref_NSExtAppEntity_SetShowState
title: SetShowState(Integer showState)
intellisense: NSExtAppEntity.SetShowState
keywords: NSExtAppEntity, GetShowState
so.topic: reference
---

The application is shown in which state Minimized, Maximized or Restored

**Parameter:** 
 - **showState** Integer
     - Enum: 0 = Minimized 
     - Enum: 1 = Maximized 
     - Enum: 2 = Default 
     - Enum: 256 = ToolBar 
     - Enum: 512 = AddressBar 
     - Enum: 1024 = StatusBar 
     - Enum: 2048 = MenuBar 

```crmscript
NSExtAppEntity thing;
Integer showState;
thing.SetShowState(showState);
```

