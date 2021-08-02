---
uid: crmscript_ref_NSDiagnosticsAgent_CollectDataAdditions
title: Void CollectDataAdditions()
intellisense: NSDiagnosticsAgent.CollectDataAdditions
keywords: NSDiagnosticsAgent, CollectDataAdditions
so.topic: reference
---

Collect and transmit usage statistics: Database Additions. If opted-out then this call does nothing. The call returns immediately (starting a background thread), and updates CS scheduler table to set the next run time.


```crmscript
NSDiagnosticsAgent agent;
agent.CollectDataAdditions();
```

