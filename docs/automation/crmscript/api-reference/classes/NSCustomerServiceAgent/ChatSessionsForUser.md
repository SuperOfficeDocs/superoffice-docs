---
uid: crmscript_ref_NSCustomerServiceAgent_ChatSessionsForUser
title: NSChatSession[] ChatSessionsForUser()
intellisense: NSCustomerServiceAgent.ChatSessionsForUser
keywords: NSCustomerServiceAgent, ChatSessionsForUser
so.topic: reference
---

# NSChatSession[] ChatSessionsForUser()

Get all chat TOPICS which this user is a member of. Members means that you have at least one of: Can Respond, Notifications, Listen or Manager

**Returns:** NSChatSession[]

```crmscript
NSCustomerServiceAgent agent;
NSChatSession[] res = agent.ChatSessionsForUser();
```

