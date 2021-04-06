---
uid: crmscript_ref_NSCheckoutInfo_SetState
title: SetState(Integer state)
intellisense: NSCheckoutInfo.SetState
keywords: NSCheckoutInfo, GetState
so.topic: reference
---

Checkout state

**Parameter:** 
 - **state** Integer
     - Enum: 0 = NotCheckedOut 
     - Enum: 1 = CheckedOutOwn 
     - Enum: 2 = CheckedOutOther 
     - Enum: 3 = LockingNotSupported 

```crmscript
NSCheckoutInfo thing;
Integer state;
thing.SetState(state);
```

