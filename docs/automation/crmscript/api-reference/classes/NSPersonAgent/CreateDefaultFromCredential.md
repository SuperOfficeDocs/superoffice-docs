---
uid: crmscript_ref_NSPersonAgent_CreateDefaultFromCredential
title: NSPersonEntity CreateDefaultFromCredential(Integer contactId, String credentialType, String credentialValue, String credentialDisplayValue)
intellisense: NSPersonAgent.CreateDefaultFromCredential
keywords: NSPersonAgent, CreateDefaultFromCredential
so.topic: reference
---

# NSPersonEntity CreateDefaultFromCredential(Integer contactId, String credentialType, String credentialValue, String credentialDisplayValue)

Creates a NSPersonEntity with default values based on the contactId and credentials.

**Parameters:**
 - **contactId** Contact id of the person
 - **credentialType** Type of credentials, corresponding to name of plugin and type in the credentials table.
 - **credentialValue** This is the actuall value of the credentials.  This will typically be the password or teh users SID in active directory
 - **credentialDisplayValue** The value displayed to the user. this will typically be the users login name in active directory.
