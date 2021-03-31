---
title: crmscript_ref_NSChatAgent_ChatTopicsForUser
description: ChatTopicEntityArray ChatTopicsForUser()
intellisense: NSChatAgent.ChatTopicsForUser
keywords: NSChatAgent,ChatTopicsForUser
so.topic: reference
---

Get all chat topics which this user is a member of. Members means that you have at least one of: Can Respond, Notifications, Listen or Manager


**Returns:** Array of chat topics the current user can access

```crmscript
NSChatAgent agent;
ChatTopicEntityArray res = agent.ChatTopicsForUser();
```

