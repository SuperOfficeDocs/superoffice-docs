---
uid: crmscript_ref_NSChatAgent_PickUpChatSession
title: NSChatSessionEntity PickUpChatSession(Integer chatSessionId)
intellisense: NSChatAgent.PickUpChatSession
keywords: NSChatAgent, PickUpChatSession
so.topic: reference
---

'answer' the session: assign the session to the user. The welcome message is sent to the customer. Returns NULL if session was not in queue.

**Parameters:**
 - **chatSessionId** id of the chat session to answer

**Returns:** NSChatSessionEntity

```crmscript
NSChatAgent agent;
Integer chatSessionId;
NSChatSessionEntity res = agent.PickUpChatSession(chatSessionId);
```

