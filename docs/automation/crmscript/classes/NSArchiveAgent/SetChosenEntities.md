---
title: Void SetChosenEntities(String guiName, String providerName, String[] entities)
path: /EJScript/Classes/NSArchiveAgent/Member functions/Void SetChosenEntities(String p_0, String p_1, String[] p_2)
intellisense: 1
classref: 1
sortOrder: 1122
keywords: SetChosenEntities(String,String,String[])
---


Set the currently chosen entities for the given gui name/provider name combination. This service corresponds to the SetSelected method of the SelectableMDOList service, for a list called archiveEntities: plus the archive provider name and gui name as its additionalInfo.



* **guiName:** String that identifies the archive in the GUI, must be the same when fetching and storing configurations, but does not otherwise have to match anything.
* **providerName:** Name of archive provider, must match one of the plugins known to the ArchiveProviderFactory.
* **entities:** Array of entity names


