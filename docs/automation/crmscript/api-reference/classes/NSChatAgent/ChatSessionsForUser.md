---
uid: crmscript_ref_NSChatAgent_ChatSessionsForUser
title: NSChatSessionEntity[] ChatSessionsForUser()
intellisense: NSChatAgent.ChatSessionsForUser
keywords: NSChatAgent, ChatSessionsForUser
so.topic: reference
---

# NSChatSessionEntity[] ChatSessionsForUser()

Get all chat sessions which this user is a member of. Members means that you have at least one of: Can Respond, Notifications, Listen or Manager

**Returns:** NSChatSessionEntity[]

```crmscript
NSChatAgent agent;
NSChatSessionEntity[] res = agent.ChatSessionsForUser();
```

