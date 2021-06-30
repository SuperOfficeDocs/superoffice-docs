---
uid: crmscript_ref_NSCustomerServiceAgent_ChatSessionsForUser
title: ChatSession[] ChatSessionsForUser()
intellisense: NSCustomerServiceAgent.ChatSessionsForUser
keywords: NSCustomerServiceAgent, ChatSessionsForUser
so.topic: reference
---

Get all chat TOPICS which this user is a member of. Members means that you have at least one of: Can Respond, Notifications, Listen or Manager


**Returns:** Array of chat TOPIC ids the current user can access. NOT chat sessions.

```crmscript
NSCustomerServiceAgent agent;
ChatSession[] res = agent.ChatSessionsForUser();
```

