---
uid: crmscript_ref_NSChatAgent_GetChatTranscript
title: String GetChatTranscript(Integer chatSessionId, Bool html)
intellisense: NSChatAgent.GetChatTranscript
keywords: NSChatAgent, GetChatTranscript
so.topic: reference
---

Get the chat transcript, formatted as plain text or html

**Parameters:**
 - **chatSessionId** id of the chat session to get the transcript for
 - **html** Get transcript as HTML

**Returns:** String

```crmscript
NSChatAgent agent;
Integer chatSessionId;
Bool html;
String res = agent.GetChatTranscript(chatSessionId, html);
```

