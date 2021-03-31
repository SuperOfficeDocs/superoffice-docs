---
title: crmscript_ref_NSEMailAgent_Save
description: EMailEntity Save(EMailEntity email)
intellisense: NSEMailAgent.Save
keywords: NSEMailAgent,Save
so.topic: reference
---

Save the e-mail back to the database

**Parameters:**
 - **email** The e-mail to save

**Returns:** The updated saved entity

```crmscript
NSEMailAgent agent;
EMailEntity email;
EMailEntity res = agent.Save(email);
```

