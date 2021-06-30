---
uid: crmscript_ref_NSUserAgent_GetUntrustedCredentialsForAssociate
title: UntrustedCredentials[] GetUntrustedCredentialsForAssociate(Integer associateId, String type)
intellisense: NSUserAgent.GetUntrustedCredentialsForAssociate
keywords: NSUserAgent, GetUntrustedCredentialsForAssociate
so.topic: reference
---

Get a set of credentials of a specified type for a specified user. SecretValue is only populated for authenticated user, and system users.

**Parameters:**
 - **associateId** Id of user to retrieve credentials for.
 - **type** Type of credential(Ex: "imap", "smtp").

**Returns:** Array of credentials of the specified type.

```crmscript
NSUserAgent agent;
Integer associateId;
String type;
UntrustedCredentials[] res = agent.GetUntrustedCredentialsForAssociate(associateId, type);
```

