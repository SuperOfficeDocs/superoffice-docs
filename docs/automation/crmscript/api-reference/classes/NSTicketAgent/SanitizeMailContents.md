---
uid: crmscript_ref_NSTicketAgent_SanitizeMailContents
title: String[] SanitizeMailContents(String[] contents)
intellisense: NSTicketAgent.SanitizeMailContents
keywords: NSTicketAgent, SanitizeMailContents
so.topic: reference
---

# String[] SanitizeMailContents(String[] contents)

Remove harmful HTML tags and attributes from an email

**Parameters:**
 - **contents** The email contents to sanitize

**Returns:** String[]

```crmscript
NSTicketAgent agent;
String[] contents;
String[] res = agent.SanitizeMailContents(contents);
```

