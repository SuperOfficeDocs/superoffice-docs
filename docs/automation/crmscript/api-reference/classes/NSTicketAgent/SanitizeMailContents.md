---
uid: crmscript_ref_NSTicketAgent_SanitizeMailContents
title: String[] SanitizeMailContents(String[] contents)
intellisense: NSTicketAgent.SanitizeMailContents
keywords: NSTicketAgent, SanitizeMailContents
so.topic: reference
---

Remove harmful HTML tags and attributes from an email

**Parameters:**
 - **contents** The email contents to sanitize

**Returns:** The sanitized email contents

```crmscript
NSTicketAgent agent;
String[] contents;
String[] res = agent.SanitizeMailContents(contents);
```

