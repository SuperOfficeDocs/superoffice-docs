---
uid: crmscript_ref_NSUserAgent_CreateDefaultUserFromUserTypeAndCredential
title: User CreateDefaultUserFromUserTypeAndCredential(Integer userType, Integer contactId, String credentialType, String credentialValue, String credentialDisplayValue)
intellisense: NSUserAgent.CreateDefaultUserFromUserTypeAndCredential
keywords: NSUserAgent, CreateDefaultUserFromUserTypeAndCredential
so.topic: reference
---

Creates a PersonEntity with default values based on the contactId and credentials.

**Parameters:**
 - **userType** Type of associate for the user
     - Enum: 0 = Unknown 
     - Enum: 1 = InternalAssociate 
     - Enum: 2 = ResourceAssociate 
     - Enum: 3 = ExternalAssociate 
     - Enum: 4 = AnonymousAssociate 
     - Enum: 5 = SystemAssociate 
 - **contactId** Contact id of the person
 - **credentialType** Type of credentials, corresponding to name of plugin and type in the credentials table.
 - **credentialValue** This is the actuall value of the credentials.  This will typically be the password or teh users SID in active directory
 - **credentialDisplayValue** The value displayed to the user. this will typically be the users login name in active directory.
