---
uid: crmscript_ref_NSChatAgent_SaveChatPresence
title: Void SaveChatPresence(NSChatPresence[] chatPresence)
intellisense: NSChatAgent.SaveChatPresence
keywords: NSChatAgent, SaveChatPresence
so.topic: reference
---

Save the chat presence for specified users

**Parameters:**
 - **chatPresence** An array with NSChatPresence objects. Only the UserId and Present information is used while saving

**Returns:** 

```crmscript
NSChatAgent agent;
NSChatPresence[] chatPresence;
agent.SaveChatPresence(chatPresence);
```

