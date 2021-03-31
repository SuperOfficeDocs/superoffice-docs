---
title: crmscript_ref_NSChatAgent_PickUpChatSession
description: ChatSessionEntity PickUpChatSession(Integer chatSessionId)
intellisense: NSChatAgent.PickUpChatSession
keywords: NSChatAgent,PickUpChatSession
so.topic: reference
---

'answer' the session: assign the session to the user. The welcome message is sent to the customer. Returns NULL if session was not in queue.

**Parameters:**
 - **chatSessionId** id of the chat session to answer

**Returns:** The chat session

```crmscript
NSChatAgent agent;
Integer chatSessionId;
ChatSessionEntity res = agent.PickUpChatSession(chatSessionId);
```

