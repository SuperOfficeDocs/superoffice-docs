---
uid: crmscript_ref_NSPocketDeviceInfo_GetPlatform
title: Integer GetPlatform()
intellisense: NSPocketDeviceInfo.GetPlatform
keywords: NSPocketDeviceInfo, GetPlatform
so.topic: reference
---

What platform does this device belong to

**Returns:** Integer

     - Enum: 0 = Apple 
     - Enum: 1 = Google 
     - Enum: 2 = Microsoft 
     - Enum: 3 = AppleDeveloper 
     - Enum: 4 = AppleAdHoc 
     - Enum: 5 = GoogleDeveloper 

```crmscript
NSPocketDeviceInfo thing;
Integer platform  = thing.GetPlatform();
```


