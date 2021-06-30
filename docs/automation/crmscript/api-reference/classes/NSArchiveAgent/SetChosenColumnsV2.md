---
uid: crmscript_ref_NSArchiveAgent_SetChosenColumnsV2
title: Void SetChosenColumnsV2(String guiName, String providerName, String context, String ownerKeys, String[] chosenColumns)
intellisense: NSArchiveAgent.SetChosenColumnsV2
keywords: NSArchiveAgent, SetChosenColumnsV2
so.topic: reference
---

Set the currently chosen columns for the given gui name/provider name combination. This service corresponds to the SetSelected method of the SelectableMDOList service, for a list called archiveColumns: plus the archive provider name and gui name as its additionalInfo.

**Parameters:**
 - **guiName** String that identifies the archive in the GUI, must be the same when fetching and storing configurations, but does not otherwise have to match anything.
 - **providerName** Name of archive provider, must match one of the plugins known to the ArchiveProviderFactory.
 - **context** Context parameter, url-encoded string context parameter for ArchiveProvider constructor. Optional, but required for archives that depend on a context - for instance Quote archives that need to know their QuoteConnectionId to be meaningful
 - **ownerKeys** Name/value string containing ownership binding information. The first should resolve to a table/primarykey, such as selection=123. Future functionality may allow multiple/extended keys
 - **chosenColumns** Array of column names, where array order indicates left to right order in the archive.
