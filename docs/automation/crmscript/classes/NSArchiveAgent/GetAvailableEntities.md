---
title: crmscript_ref_NSArchiveAgent_GetAvailableEntities_String_p_0_String_p_1
description: NSArchiveAgent.GetAvailableEntities(String p_0, String p_1)
intellisense: NSArchiveAgent.GetAvailableEntities
sortOrder: 1118
keywords: GetAvailableEntities(String,String)
so.topic: reference
---


Return list of all entities supported by an archive provider. See also GetArchiveConfiguration.



* **providerName:** The name of the archive provider to use; it will be created via the ArchiveProviderFactory from a plugin
* **context:** Optional context parameter, url-encoded string context parameter for ArchiveProvider constructor
* **Returns:** Array of all entity types supported by the archive provider. MDOListItem.Name = DisplayName, Tooltip = DisplayTooltip, Type = code name, StyleHint = optional/mandatory, IconHint=DefaultShow


