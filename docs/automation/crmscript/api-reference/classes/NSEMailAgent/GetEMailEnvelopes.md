---
uid: crmscript_ref_NSEMailAgent_GetEMailEnvelopes
title: NSEMailEnvelope[] GetEMailEnvelopes(NSEMailConnectionInfo connectionInfo, Integer[] messageServerIds)
intellisense: NSEMailAgent.GetEMailEnvelopes
keywords: NSEMailAgent, GetEMailEnvelopes
so.topic: reference
---

# NSEMailEnvelope[] GetEMailEnvelopes(NSEMailConnectionInfo connectionInfo, Integer[] messageServerIds)

Retrieve a set of e-mail envelopes

**Parameters:**
 - **connectionInfo** All information needed to connect to the mailserver
 - **messageServerIds** Unique identitifiers for the e-mails to retrieve envelopes for

**Returns:** NSEMailEnvelope[]

```crmscript
NSEMailAgent agent;
NSEMailConnectionInfo connectionInfo;
Integer[] messageServerIds;
NSEMailEnvelope[] res = agent.GetEMailEnvelopes(connectionInfo, messageServerIds);
```

