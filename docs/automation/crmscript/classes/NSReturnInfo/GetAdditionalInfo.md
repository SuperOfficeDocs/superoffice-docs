---
uid: crmscript_ref_NSReturnInfo_GetAdditionalInfo
title: String GetAdditionalInfo()
intellisense: NSReturnInfo.GetAdditionalInfo
keywords: NSReturnInfo, GetAdditionalInfo
so.topic: reference
---

Optional, additional information meant for further processing. This member is ignored for return types None, Message and SoProtocol. It can be used to pass execution-dependent information to the code that handles CustomGui and Other.

**Returns:** String


```crmscript
NSReturnInfo thing;
String additionalInfo  = thing.GetAdditionalInfo();
```


