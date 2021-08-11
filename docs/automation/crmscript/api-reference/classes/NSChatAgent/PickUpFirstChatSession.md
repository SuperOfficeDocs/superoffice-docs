---
uid: crmscript_ref_NSChatAgent_PickUpFirstChatSession
title: NSChatSessionEntity PickUpFirstChatSession()
intellisense: NSChatAgent.PickUpFirstChatSession
keywords: NSChatAgent, PickUpFirstChatSession
so.topic: reference
---

# NSChatSessionEntity PickUpFirstChatSession()

'answer' the first available session from the queue: assign the session to the user. The welcome message is sent to the customer.

**Returns:** NSChatSessionEntity

```crmscript
NSChatAgent agent;
NSChatSessionEntity res = agent.PickUpFirstChatSession();
```

