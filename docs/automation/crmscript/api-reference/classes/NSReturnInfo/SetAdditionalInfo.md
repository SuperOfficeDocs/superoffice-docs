---
uid: crmscript_ref_NSReturnInfo_SetAdditionalInfo
title: SetAdditionalInfo(String additionalInfo)
intellisense: NSReturnInfo.SetAdditionalInfo
keywords: NSReturnInfo, GetAdditionalInfo
so.topic: reference
---

# SetAdditionalInfo(String additionalInfo)

Optional, additional information meant for further processing. This member is ignored for return types None, Message and SoProtocol. It can be used to pass execution-dependent information to the code that handles CustomGui and Other.

**Parameter:** 
 - **additionalInfo** String

```crmscript
NSReturnInfo thing;
String additionalInfo;
thing.SetAdditionalInfo(additionalInfo);
```

