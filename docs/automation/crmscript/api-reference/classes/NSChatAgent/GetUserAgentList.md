---
uid: crmscript_ref_NSChatAgent_GetUserAgentList
title: NSMDOListItem[] GetUserAgentList(Bool flat, Bool onlyPresent)
intellisense: NSChatAgent.GetUserAgentList
keywords: NSChatAgent, GetUserAgentList
so.topic: reference
---

# NSMDOListItem[] GetUserAgentList(Bool flat, Bool onlyPresent)

Get list of users that can be assigned to chat topics. Users with Chat-CALs from the MDO list 'chatuser'

**Parameters:**
 - **flat** Return flat list instead of grouping by usergroup.
 - **onlyPresent** Only show users who are present

**Returns:** NSMDOListItem[]

```crmscript
NSChatAgent agent;
Bool flat;
Bool onlyPresent;
NSMDOListItem[] res = agent.GetUserAgentList(flat, onlyPresent);
```

