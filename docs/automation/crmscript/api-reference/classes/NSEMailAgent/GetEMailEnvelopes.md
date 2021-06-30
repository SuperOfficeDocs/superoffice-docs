---
uid: crmscript_ref_NSEMailAgent_GetEMailEnvelopes
title: EMailEnvelope[] GetEMailEnvelopes(EMailConnectionInfo connectionInfo, Integer[] messageServerIds)
intellisense: NSEMailAgent.GetEMailEnvelopes
keywords: NSEMailAgent, GetEMailEnvelopes
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
Integer[] messageServerIds;
EMailEnvelope[] res = agent.GetEMailEnvelopes(connectionInfo, messageServerIds);
```

