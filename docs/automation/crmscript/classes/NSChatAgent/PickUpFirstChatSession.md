---
uid: crmscript_ref_NSChatAgent_PickUpFirstChatSession
title: ChatSessionEntity PickUpFirstChatSession()
intellisense: NSChatAgent.PickUpFirstChatSession
keywords: NSChatAgent, PickUpFirstChatSession
so.topic: reference
---

'answer' the first available session from the queue: assign the session to the user. The welcome message is sent to the customer.


**Returns:** The picked-up chat session

```crmscript
NSChatAgent agent;
ChatSessionEntity res = agent.PickUpFirstChatSession();
```

