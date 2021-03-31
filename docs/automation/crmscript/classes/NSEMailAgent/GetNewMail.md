---
title: crmscript_ref_NSEMailAgent_GetNewMail
description: EMailEnvelopeArray GetNewMail(IntegerArray folders)
intellisense: NSEMailAgent.GetNewMail
keywords: NSEMailAgent,GetNewMail
so.topic: reference
---

Get new email in folder(s) for current associate

**Parameters:**
 - **folders** List of folder ids to check for new email

**Returns:** The downloaded email envelopes

```crmscript
NSEMailAgent agent;
IntegerArray folders;
EMailEnvelopeArray res = agent.GetNewMail(folders);
```

