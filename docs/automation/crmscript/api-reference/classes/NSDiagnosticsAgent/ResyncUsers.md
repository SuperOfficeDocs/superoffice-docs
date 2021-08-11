---
uid: crmscript_ref_NSDiagnosticsAgent_ResyncUsers
title: Void ResyncUsers()
intellisense: NSDiagnosticsAgent.ResyncUsers
keywords: NSDiagnosticsAgent, ResyncUsers
so.topic: reference
---

# Void ResyncUsers()

Resynchronize user information with SuperOffice Community, if opted-out then this call does nothing. The call returns immediately (starting a background thread), and updates CS scheduler table to set the next run time.

```crmscript
NSDiagnosticsAgent agent;
agent.ResyncUsers();
```

