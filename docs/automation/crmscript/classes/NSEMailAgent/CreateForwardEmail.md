---
uid: crmscript_ref_NSEMailAgent_CreateForwardEmail
title: EMailEntity CreateForwardEmail(EMailEntity email)
intellisense: NSEMailAgent.CreateForwardEmail
keywords: NSEMailAgent, CreateForwardEmail
so.topic: reference
---

Create forward email

**Parameters:**
 - **email** The e-mail to forward

**Returns:** The new forward email entity

```crmscript
NSEMailAgent agent;
EMailEntity email;
EMailEntity res = agent.CreateForwardEmail(email);
```

