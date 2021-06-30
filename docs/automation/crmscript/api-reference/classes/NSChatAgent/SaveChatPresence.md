---
uid: crmscript_ref_NSChatAgent_SaveChatPresence
title: Void SaveChatPresence(ChatPresence[] chatPresence)
intellisense: NSChatAgent.SaveChatPresence
keywords: NSChatAgent, SaveChatPresence
so.topic: reference
---

Save the chat presence for specified users

**Parameters:**
 - **chatPresence** An array with ChatPresence objects. Only the UserId and Present information is used while saving

**Returns:** void

```crmscript
NSChatAgent agent;
ChatPresence[] chatPresence;
Void res = agent.SaveChatPresence(chatPresence);
```

