---
title: crmscript_ref_NSAssociateAgent_LogOffWindowsUsers
description: Void LogOffWindowsUsers(IntegerArray associateIds)
intellisense: NSAssociateAgent.LogOffWindowsUsers
keywords: NSAssociateAgent,LogOffWindowsUsers
so.topic: reference
---

Method that logs off associates that are logged on to the win client

**Parameters:**
 - **associateIds** The ids of the associates that shall be logged off

**Returns:** A void return

```crmscript
NSAssociateAgent agent;
IntegerArray associateIds;
Void res = agent.LogOffWindowsUsers(associateIds);
```

