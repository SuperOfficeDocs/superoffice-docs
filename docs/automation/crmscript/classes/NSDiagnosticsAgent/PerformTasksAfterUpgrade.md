---
uid: crmscript_ref_NSDiagnosticsAgent_PerformTasksAfterUpgrade
title: String PerformTasksAfterUpgrade()
intellisense: NSDiagnosticsAgent.PerformTasksAfterUpgrade
keywords: NSDiagnosticsAgent, PerformTasksAfterUpgrade
so.topic: reference
---

After upgrading to a new fileset, there may be tasks that need to be done. Examples - import new TypicalSearches, if present. Tasks performed here need to be idempotent and independent of the actual upgrade jump (what was the previous version). They should complete in a reasonable time, not more than a few minutes maximum.


**Returns:** Message that can be shown to the user, summarizing what has been done, if anything.

```crmscript
NSDiagnosticsAgent agent;
String res = agent.PerformTasksAfterUpgrade();
```

