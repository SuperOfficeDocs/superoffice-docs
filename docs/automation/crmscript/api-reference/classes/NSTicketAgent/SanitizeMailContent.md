---
uid: crmscript_ref_NSTicketAgent_SanitizeMailContent
title: String SanitizeMailContent(String content)
intellisense: NSTicketAgent.SanitizeMailContent
keywords: NSTicketAgent, SanitizeMailContent
so.topic: reference
---

Remove harmful HTML tags and attributes from an email

**Parameters:**
 - **content** The email content to sanitize

**Returns:** String

```crmscript
NSTicketAgent agent;
String content;
String res = agent.SanitizeMailContent(content);
```

