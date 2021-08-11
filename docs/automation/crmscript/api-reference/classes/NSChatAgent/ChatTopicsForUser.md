---
uid: crmscript_ref_NSChatAgent_ChatTopicsForUser
title: NSChatTopicEntity[] ChatTopicsForUser()
intellisense: NSChatAgent.ChatTopicsForUser
keywords: NSChatAgent, ChatTopicsForUser
so.topic: reference
---

# NSChatTopicEntity[] ChatTopicsForUser()

Get all chat topics which this user is a member of. Members means that you have at least one of: Can Respond, Notifications, Listen or Manager

**Returns:** NSChatTopicEntity[]

```crmscript
NSChatAgent agent;
NSChatTopicEntity[] res = agent.ChatTopicsForUser();
```

