---
title: crmscript_ref_NSChatAgent_GetUserAgentList
description: MDOListItemArray GetUserAgentList(Bool flat, Bool onlyPresent)
intellisense: NSChatAgent.GetUserAgentList
keywords: NSChatAgent,GetUserAgentList
so.topic: reference
---

Get list of users that can be assigned to chat topics. Users with Chat-CALs from the MDO list 'chatuser'

**Parameters:**
 - **flat** Return flat list instead of grouping by usergroup.
 - **onlyPresent** Only show users who are present

**Returns:** List of user agents that can be assigned to chat topics, possibly grouped by usergroup.

```crmscript
NSChatAgent agent;
Bool flat;
Bool onlyPresent;
MDOListItemArray res = agent.GetUserAgentList(flat, onlyPresent);
```

