---
uid: crmscript_ref_NSChatAgent_DeleteChatTopicUserAgent
title: Void DeleteChatTopicUserAgent(Integer chatTopicId, String username)
intellisense: NSChatAgent.DeleteChatTopicUserAgent
keywords: NSChatAgent, DeleteChatTopicUserAgent
so.topic: reference
---

Remove a user from a topic

**Parameters:**
 - **chatTopicId** Id of the chat topic
 - **username** Associate username or associate id to delete.

**Returns:** This method has no return value

```crmscript
NSChatAgent agent;
Integer chatTopicId;
String username;
agent.DeleteChatTopicUserAgent(chatTopicId, username);
```

