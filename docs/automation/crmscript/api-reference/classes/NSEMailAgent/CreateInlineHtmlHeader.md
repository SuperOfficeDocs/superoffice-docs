---
uid: crmscript_ref_NSEMailAgent_CreateInlineHtmlHeader
title: String CreateInlineHtmlHeader(NSEMailEntity email)
intellisense: NSEMailAgent.CreateInlineHtmlHeader
keywords: NSEMailAgent, CreateInlineHtmlHeader
so.topic: reference
---

# String CreateInlineHtmlHeader(NSEMailEntity email)

Create Outlook style HTML header to use in for instance reply entities and when printing

**Parameters:**
 - **email** The e-mail to generate header based on

**Returns:** String

```crmscript
NSEMailAgent agent;
NSEMailEntity email;
String res = agent.CreateInlineHtmlHeader(email);
```

