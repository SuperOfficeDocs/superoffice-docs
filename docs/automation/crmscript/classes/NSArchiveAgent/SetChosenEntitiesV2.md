---
title: crmscript_ref_NSArchiveAgent_SetChosenEntitiesV2
description: Void SetChosenEntitiesV2(String guiName, String providerName, String context, String ownerKeys, StringArray entities)
intellisense: NSArchiveAgent.SetChosenEntitiesV2
keywords: NSArchiveAgent,SetChosenEntitiesV2
so.topic: reference
---

Set the currently chosen entities for the given gui name/provider name combination. This service corresponds to the SetSelected method of the SelectableMDOList service, for a list called archiveEntities: plus the archive provider name and gui name as its additionalInfo.

**Parameters:**
 - **guiName** String that identifies the archive in the GUI, must be the same when fetching and storing configurations, but does not otherwise have to match anything.
 - **providerName** Name of archive provider, must match one of the plugins known to the ArchiveProviderFactory.
 - **context** Context parameter, url-encoded string context parameter for ArchiveProvider constructor. Optional, but required for archives that depend on a context - for instance Quote archives that need to know their QuoteConnectionId to be meaningful
 - **ownerKeys** Name/value string containing ownership binding information. The first should resolve to a table/primarykey, such as selection=123. Future functionality may allow multiple/extended keys
 - **entities** Array of entity names
