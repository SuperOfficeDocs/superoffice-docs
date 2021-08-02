---
uid: crmscript_ref_NSUserAgent_FindCredentialsGroups
title: NSCredentialsGroup[] FindCredentialsGroups(String type, String searchString)
intellisense: NSUserAgent.FindCredentialsGroups
keywords: NSUserAgent, FindCredentialsGroups
so.topic: reference
---

Get user groups holding users filtered by the searchString.  This method is only relevant if the CredentialType control is of type link.  There will allways be at least one groups even if the underlying provider does not support groups.

**Parameters:**
 - **type** Type of credentials, corresponding to name of plugin and type in the credentials table.
 - **searchString** Partly name of domain group.

**Returns:** NSCredentialsGroup[]