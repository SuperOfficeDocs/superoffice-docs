---
uid: crmscript_ref_NSUserAgent_GetUntrustedCredentialsForAssociate
title: NSUntrustedCredentials[] GetUntrustedCredentialsForAssociate(Integer associateId, String type)
intellisense: NSUserAgent.GetUntrustedCredentialsForAssociate
keywords: NSUserAgent, GetUntrustedCredentialsForAssociate
so.topic: reference
---

# NSUntrustedCredentials[] GetUntrustedCredentialsForAssociate(Integer associateId, String type)

Get a set of credentials of a specified type for a specified user. SecretValue is only populated for authenticated user, and system users.

**Parameters:**
 - **associateId** Id of user to retrieve credentials for.
 - **type** Type of credential(Ex: "imap", "smtp").

**Returns:** NSUntrustedCredentials[]

```crmscript
NSUserAgent agent;
Integer associateId;
String type;
NSUntrustedCredentials[] res = agent.GetUntrustedCredentialsForAssociate(associateId, type);
```

