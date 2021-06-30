---
uid: crmscript_ref_NSEMailAgent_GetNewMail
title: EMailEnvelope[] GetNewMail(Integer[] folders)
intellisense: NSEMailAgent.GetNewMail
keywords: NSEMailAgent, GetNewMail
so.topic: reference
---

Get new email in folder(s) for current associate

**Parameters:**
 - **folders** List of folder ids to check for new email

**Returns:** The downloaded email envelopes

```crmscript
NSEMailAgent agent;
Integer[] folders;
EMailEnvelope[] res = agent.GetNewMail(folders);
```

