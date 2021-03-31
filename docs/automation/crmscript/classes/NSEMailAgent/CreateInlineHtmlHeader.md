---
title: crmscript_ref_NSEMailAgent_CreateInlineHtmlHeader
description: String CreateInlineHtmlHeader(EMailEntity email)
intellisense: NSEMailAgent.CreateInlineHtmlHeader
keywords: NSEMailAgent,CreateInlineHtmlHeader
so.topic: reference
---

Create Outlook style HTML header to use in for instance reply entities and when printing

**Parameters:**
 - **email** The e-mail to generate header based on

**Returns:** The generated HTML header

```crmscript
NSEMailAgent agent;
EMailEntity email;
String res = agent.CreateInlineHtmlHeader(email);
```

