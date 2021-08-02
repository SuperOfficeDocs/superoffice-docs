---
uid: crmscript_ref_NSAssociateAgent_LogOffWindowsUsers
title: Void LogOffWindowsUsers(Integer[] associateIds)
intellisense: NSAssociateAgent.LogOffWindowsUsers
keywords: NSAssociateAgent, LogOffWindowsUsers
so.topic: reference
---

Method that logs off associates that are logged on to the win client

**Parameters:**
 - **associateIds** The ids of the associates that shall be logged off

**Returns:** A void return

```crmscript
NSAssociateAgent agent;
Integer[] associateIds;
agent.LogOffWindowsUsers(associateIds);
```

