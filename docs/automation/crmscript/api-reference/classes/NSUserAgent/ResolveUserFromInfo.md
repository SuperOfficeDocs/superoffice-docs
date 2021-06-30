---
uid: crmscript_ref_NSUserAgent_ResolveUserFromInfo
title: ResolvedUser ResolveUserFromInfo(Integer contactId, String personName, String[] phoneNumbers, String[] emails, Integer userType, Credential credential)
intellisense: NSUserAgent.ResolveUserFromInfo
keywords: NSUserAgent, ResolveUserFromInfo
so.topic: reference
---

Get a user from the provided information. If the user or associated person does not exist, it will be created on demand.

**Parameters:**
 - **contactId** The contact Id of the contact which the person belongs to. Cannot be 0.
 - **personName** The full name of the person to be resolved. Optional.
 - **phoneNumbers** Phone numbers registered on the person. Optional.
 - **emails** Email-addresses registered on the person. Optional.
 - **userType** The type of user to look up or create.
     - Enum: 0 = Unknown 
     - Enum: 1 = InternalAssociate 
     - Enum: 2 = ResourceAssociate 
     - Enum: 3 = ExternalAssociate 
     - Enum: 4 = AnonymousAssociate 
     - Enum: 5 = SystemAssociate 
 - **credential** The credentials to be used for the user. Required.

**Returns:** The results of the resolve-operation.

```crmscript
NSUserAgent agent;
Integer contactId;
String personName;
String[] phoneNumbers;
String[] emails;
Integer userType;
Credential credential;
ResolvedUser res = agent.ResolveUserFromInfo(contactId, personName, phoneNumbers, emails, userType, credential);
```

