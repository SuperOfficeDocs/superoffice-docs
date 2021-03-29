---
title: crmscript_ref_NSArchiveAgent_SetChosenEntities_String_p_0_String_p_1_String__p_2
description: NSArchiveAgent.SetChosenEntities(String p_0, String p_1, String[] p_2)
intellisense: NSArchiveAgent.SetChosenEntities
sortOrder: 1122
keywords: SetChosenEntities(String,String,String[])
so.topic: reference
---


Set the currently chosen entities for the given gui name/provider name combination. This service corresponds to the SetSelected method of the SelectableMDOList service, for a list called archiveEntities: plus the archive provider name and gui name as its additionalInfo.



* **guiName:** String that identifies the archive in the GUI, must be the same when fetching and storing configurations, but does not otherwise have to match anything.
* **providerName:** Name of archive provider, must match one of the plugins known to the ArchiveProviderFactory.
* **entities:** Array of entity names


