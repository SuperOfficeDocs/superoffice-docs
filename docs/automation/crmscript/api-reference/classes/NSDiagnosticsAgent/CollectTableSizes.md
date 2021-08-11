---
uid: crmscript_ref_NSDiagnosticsAgent_CollectTableSizes
title: Void CollectTableSizes()
intellisense: NSDiagnosticsAgent.CollectTableSizes
keywords: NSDiagnosticsAgent, CollectTableSizes
so.topic: reference
---

# Void CollectTableSizes()

Collect and transmit usage statistics: Table Sizes. If opted-out then this call does nothing. The call returns immediately (starting a background thread), and updates CS scheduler table to set the next run time.

```crmscript
NSDiagnosticsAgent agent;
agent.CollectTableSizes();
```

