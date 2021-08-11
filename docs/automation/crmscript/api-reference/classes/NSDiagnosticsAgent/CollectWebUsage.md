---
uid: crmscript_ref_NSDiagnosticsAgent_CollectWebUsage
title: Void CollectWebUsage()
intellisense: NSDiagnosticsAgent.CollectWebUsage
keywords: NSDiagnosticsAgent, CollectWebUsage
so.topic: reference
---

# Void CollectWebUsage()

Collect and transmit usage statistics: Web-based clients Usage. If opted-out then this call does nothing. The call returns immediately (starting a background thread), and updates CS scheduler table to set the next run time.

```crmscript
NSDiagnosticsAgent agent;
agent.CollectWebUsage();
```

