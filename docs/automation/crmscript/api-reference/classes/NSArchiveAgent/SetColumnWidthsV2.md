---
uid: crmscript_ref_NSArchiveAgent_SetColumnWidthsV2
title: Void SetColumnWidthsV2(String guiName, String providerName, String context, String ownerKeys, String[] columnWidths)
intellisense: NSArchiveAgent.SetColumnWidthsV2
keywords: NSArchiveAgent, SetColumnWidthsV2
so.topic: reference
---

# Void SetColumnWidthsV2(String guiName, String providerName, String context, String ownerKeys, String[] columnWidths)

Set the column widths for the given set of columns and GUI name. 

**Parameters:**
 - **guiName** String that identifies the archive in the GUI, must be the same when fetching and storing configurations, but does not otherwise have to match anything.
 - **providerName** Name of archive provider, must match one of the plugins known to the ArchiveProviderFactory.
 - **context** Context parameter, url-encoded string context parameter for ArchiveProvider constructor. Optional, but required for archives that depend on a context - for instance Quote archives that need to know their QuoteConnectionId to be meaningful
 - **ownerKeys** Name/value string containing ownership binding information. The first should resolve to a table/primarykey, such as selection=123. Future functionality may allow multiple/extended keys
 - **columnWidths** Array of column widths. A column width is specified either as a fixed number of character (10c) or as a percentage (10%). Percentages will be recalculated so that they add up to exactly 100 when the configuration is fetched again.
