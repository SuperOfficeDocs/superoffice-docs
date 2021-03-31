---
title: crmscript_ref_NSTicketAgent_SanitizeMailContent
description: String SanitizeMailContent(String content)
intellisense: NSTicketAgent.SanitizeMailContent
keywords: NSTicketAgent,SanitizeMailContent
so.topic: reference
---

Remove harmful HTML tags and attributes from an email

**Parameters:**
 - **content** The email content to sanitize

**Returns:** The sanitized email content

```crmscript
NSTicketAgent agent;
String content;
String res = agent.SanitizeMailContent(content);
```

