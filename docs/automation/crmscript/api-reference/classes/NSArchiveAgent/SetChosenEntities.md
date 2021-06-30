---
uid: crmscript_ref_NSArchiveAgent_SetChosenEntities
title: Void SetChosenEntities(String guiName, String providerName, String[] entities)
intellisense: NSArchiveAgent.SetChosenEntities
keywords: NSArchiveAgent, SetChosenEntities
so.topic: reference
---

Set the currently chosen entities for the given gui name/provider name combination. This service corresponds to the SetSelected method of the SelectableMDOList service, for a list called archiveEntities: plus the archive provider name and gui name as its additionalInfo.

**Parameters:**
 - **guiName** String that identifies the archive in the GUI, must be the same when fetching and storing configurations, but does not otherwise have to match anything.
 - **providerName** Name of archive provider, must match one of the plugins known to the ArchiveProviderFactory.
 - **entities** Array of entity names
