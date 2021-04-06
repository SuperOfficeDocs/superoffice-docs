---
uid: crmscript_ref_NSEMailAgent_SaveDraft
title: EMailEntity SaveDraft(EMailEntity entity)
intellisense: NSEMailAgent.SaveDraft
keywords: NSEMailAgent, SaveDraft
so.topic: reference
---

Save the Email entity to the drafts folder

**Parameters:**
 - **entity** The entity to save

**Returns:** The saved e-mail entity

```crmscript
NSEMailAgent agent;
EMailEntity entity;
EMailEntity res = agent.SaveDraft(entity);
```

