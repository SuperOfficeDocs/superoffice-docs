---
title: crmscript_ref_NSEMailAgent_GetEMailEnvelopes
description: EMailEnvelopeArray GetEMailEnvelopes(EMailConnectionInfo connectionInfo, IntegerArray messageServerIds)
intellisense: NSEMailAgent.GetEMailEnvelopes
keywords: NSEMailAgent,GetEMailEnvelopes
so.topic: reference
---

Retrieve a set of e-mail envelopes

**Parameters:**
 - **connectionInfo** All information needed to connect to the mailserver
 - **messageServerIds** Unique identitifiers for the e-mails to retrieve envelopes for

**Returns:** The e-mail envelope objects

```crmscript
NSEMailAgent agent;
EMailConnectionInfo connectionInfo;
IntegerArray messageServerIds;
EMailEnvelopeArray res = agent.GetEMailEnvelopes(connectionInfo, messageServerIds);
```

