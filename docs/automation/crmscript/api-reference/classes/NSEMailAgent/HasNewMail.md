---
uid: crmscript_ref_NSEMailAgent_HasNewMail
title: Bool HasNewMail(Integer mailItemId, Integer folderId)
intellisense: NSEMailAgent.HasNewMail
keywords: NSEMailAgent, HasNewMail
so.topic: reference
---

Fast check for new mail in the database

**Parameters:**
 - **mailItemId** The last known mailitemid
 - **folderId** The folderId for the folder to check for new mail

**Returns:** Has new mail if true

```crmscript
NSEMailAgent agent;
Integer mailItemId;
Integer folderId;
Bool res = agent.HasNewMail(mailItemId, folderId);
```

