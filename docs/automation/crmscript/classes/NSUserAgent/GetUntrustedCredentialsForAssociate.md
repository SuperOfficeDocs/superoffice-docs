---
title: crmscript_ref_NSUserAgent_GetUntrustedCredentialsForAssociate_Integer_p_0_String_p_1
description: NSUserAgent.GetUntrustedCredentialsForAssociate(Integer p_0, String p_1)
intellisense: NSUserAgent.GetUntrustedCredentialsForAssociate
keywords: GetUntrustedCredentialsForAssociate(Integer,String)
so.topic: reference
---


Get a set of credentials of a specified type for a specified user. SecretValue is only populated for authenticated user, and system users.



* **associateId:** Id of user to retrieve credentials for.
* **type:** Type of credential(Ex: "imap", "smtp").
* **Returns:** Array of credentials of the specified type.


