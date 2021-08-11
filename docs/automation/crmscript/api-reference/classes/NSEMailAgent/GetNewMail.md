---
uid: crmscript_ref_NSEMailAgent_GetNewMail
title: NSEMailEnvelope[] GetNewMail(Integer[] folders)
intellisense: NSEMailAgent.GetNewMail
keywords: NSEMailAgent, GetNewMail
so.topic: reference
---

# NSEMailEnvelope[] GetNewMail(Integer[] folders)

Get new email in folder(s) for current associate

**Parameters:**
 - **folders** List of folder ids to check for new email

**Returns:** NSEMailEnvelope[]

```crmscript
NSEMailAgent agent;
Integer[] folders;
NSEMailEnvelope[] res = agent.GetNewMail(folders);
```

