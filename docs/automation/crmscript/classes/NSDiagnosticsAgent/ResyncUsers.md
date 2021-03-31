---
title: crmscript_ref_NSDiagnosticsAgent_ResyncUsers
description: Void ResyncUsers()
intellisense: NSDiagnosticsAgent.ResyncUsers
keywords: NSDiagnosticsAgent,ResyncUsers
so.topic: reference
---

Resynchronize user information with SuperOffice Community, if opted-out then this call does nothing. The call returns immediately (starting a background thread), and updates CS scheduler table to set the next run time.


**Returns:** This method has no return value

```crmscript
NSDiagnosticsAgent agent;
Void res = agent.ResyncUsers();
```

