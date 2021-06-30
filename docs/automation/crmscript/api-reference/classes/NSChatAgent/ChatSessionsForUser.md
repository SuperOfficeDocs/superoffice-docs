---
uid: crmscript_ref_NSChatAgent_ChatSessionsForUser
title: ChatSessionEntity[] ChatSessionsForUser()
intellisense: NSChatAgent.ChatSessionsForUser
keywords: NSChatAgent, ChatSessionsForUser
so.topic: reference
---

Get all chat sessions which this user is a member of. Members means that you have at least one of: Can Respond, Notifications, Listen or Manager


**Returns:** Array of chat sessions the current user can access

```crmscript
NSChatAgent agent;
ChatSessionEntity[] res = agent.ChatSessionsForUser();
```

