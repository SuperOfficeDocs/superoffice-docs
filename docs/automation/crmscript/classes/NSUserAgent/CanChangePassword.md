---
title: crmscript_ref_NSUserAgent_CanChangePassword
description: Bool CanChangePassword(Integer associateId)
intellisense: NSUserAgent.CanChangePassword
keywords: NSUserAgent,CanChangePassword
so.topic: reference
---

Check if the current assoicate can change the password for an associate

**Parameters:**
 - **associateId** AssociateId of the user to check if password can be changed

**Returns:** True if the associate can change the password

```crmscript
NSUserAgent agent;
Integer associateId;
Bool res = agent.CanChangePassword(associateId);
```

