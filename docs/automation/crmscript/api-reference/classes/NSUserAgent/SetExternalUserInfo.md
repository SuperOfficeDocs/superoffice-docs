---
uid: crmscript_ref_NSUserAgent_SetExternalUserInfo
title: Void SetExternalUserInfo(Integer associateId, String userName, String password, Bool isActive, Integer roleId, Integer externalUserInfoModification)
intellisense: NSUserAgent.SetExternalUserInfo
keywords: NSUserAgent, SetExternalUserInfo
so.topic: reference
---

# Void SetExternalUserInfo(Integer associateId, String userName, String password, Bool isActive, Integer roleId, Integer externalUserInfoModification)

Modifies an external user. Changes external users information according to the flags set in  externalUserInfoModification.

**Parameters:**
 - **associateId** The associateId to alter.
 - **userName** Login username.
 - **password** Login password.
 - **isActive** Set isActive to true to enable the external user to log in.
 - **roleId** Id of role for the external user. The role must be a role of type external users.
 - **externalUserInfoModification** externalUserInfoModification is a flag describing what to change. <see cref="SuperOffice.CRM.Services.Util.ExternalUserInfoModification"/>.
     - Enum: 0 = Unknown 
     - Enum: 1 = UserName 
     - Enum: 2 = Password 
     - Enum: 4 = Role 
     - Enum: 8 = Active 
     - Enum: 15 = All 
