---
title: NSMDOListItem[] GetAvailableEntities(String providerName, String context)
path: /EJScript/Classes/NSArchiveAgent/Member functions/NSMDOListItem[] GetAvailableEntities(String p_0, String p_1)
intellisense: 1
classref: 1
sortOrder: 1118
keywords: GetAvailableEntities(String,String)
---


Return list of all entities supported by an archive provider. See also GetArchiveConfiguration.



* **providerName:** The name of the archive provider to use; it will be created via the ArchiveProviderFactory from a plugin
* **context:** Optional context parameter, url-encoded string context parameter for ArchiveProvider constructor
* **Returns:** Array of all entity types supported by the archive provider. MDOListItem.Name = DisplayName, Tooltip = DisplayTooltip, Type = code name, StyleHint = optional/mandatory, IconHint=DefaultShow


