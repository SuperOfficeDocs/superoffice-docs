---
uid: crmscript_ref_NSUserAgent_GetCredentialTypesForUserType
title: CredentialTypeArray GetCredentialTypesForUserType(Integer userType)
intellisense: NSUserAgent.GetCredentialTypesForUserType
keywords: NSUserAgent, GetCredentialTypesForUserType
so.topic: reference
---

Get available credential types that can be used for the specified user type.

**Parameters:**
 - **userType** The user type to retrieve credential types for
     - Enum: 0 = Unknown 
     - Enum: 1 = InternalAssociate 
     - Enum: 2 = ResourceAssociate 
     - Enum: 3 = ExternalAssociate 
     - Enum: 4 = AnonymousAssociate 
     - Enum: 5 = SystemAssociate 

**Returns:** Credential types that can be used for authentication

```crmscript
NSUserAgent agent;
Integer userType;
CredentialTypeArray res = agent.GetCredentialTypesForUserType(userType);
```

