---
title: crmscript_ref_NSDiagnosticsAgent_CollectWebUsage
description: Void CollectWebUsage()
intellisense: NSDiagnosticsAgent.CollectWebUsage
keywords: NSDiagnosticsAgent,CollectWebUsage
so.topic: reference
---

Collect and transmit usage statistics: Web-based clients Usage. If opted-out then this call does nothing. The call returns immediately (starting a background thread), and updates CS scheduler table to set the next run time.


**Returns:** This method has no return value

```crmscript
NSDiagnosticsAgent agent;
Void res = agent.CollectWebUsage();
```

