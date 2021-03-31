---
title: crmscript_ref_NSChatAgent_AcceptChatSessionTransfer
description: ChatSessionEntity AcceptChatSessionTransfer(Integer chatSessionId)
intellisense: NSChatAgent.AcceptChatSessionTransfer
keywords: NSChatAgent,AcceptChatSessionTransfer
so.topic: reference
---

Accept the transfer: assign the session to the user. If the session is not being transferred, nothing happens.

**Parameters:**
 - **chatSessionId** id of the chat session to send

**Returns:** The updated chat session

```crmscript
NSChatAgent agent;
Integer chatSessionId;
ChatSessionEntity res = agent.AcceptChatSessionTransfer(chatSessionId);
```

