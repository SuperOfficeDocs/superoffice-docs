---
uid: crmscript_ref_NSArchiveAgent_SetChosenColumns
title: Void SetChosenColumns(String guiName, String providerName, String[] chosenColumns)
intellisense: NSArchiveAgent.SetChosenColumns
keywords: NSArchiveAgent, SetChosenColumns
so.topic: reference
---

Set the currently chosen columns for the given gui name/provider name combination. This service corresponds to the SetSelected method of the SelectableMDOList service, for a list called archiveColumns: plus the archive provider name and gui name as its additionalInfo.

**Parameters:**
 - **guiName** String that identifies the archive in the GUI, must be the same when fetching and storing configurations, but does not otherwise have to match anything.
 - **providerName** Name of archive provider, must match one of the plugins known to the ArchiveProviderFactory.
 - **chosenColumns** Array of column names, where array order indicates left to right order in the archive.
