---
uid: crmscript_ref_NSDiagnosticsAgent_CollectWinUsage
title: Void CollectWinUsage()
intellisense: NSDiagnosticsAgent.CollectWinUsage
keywords: NSDiagnosticsAgent, CollectWinUsage
so.topic: reference
---

Collect and transmit usage statistics: Windows CRM Client Usage. If opted-out then this call does nothing. The call returns immediately (starting a background thread), and updates CS scheduler table to set the next run time.


**Returns:** This method has no return value

```crmscript
NSDiagnosticsAgent agent;
Void res = agent.CollectWinUsage();
```

