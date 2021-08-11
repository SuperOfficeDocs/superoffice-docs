---
uid: crmscript_ref_NSArchiveAgent_SetColumnWidths
title: Void SetColumnWidths(String guiName, String[] columnWidths)
intellisense: NSArchiveAgent.SetColumnWidths
keywords: NSArchiveAgent, SetColumnWidths
so.topic: reference
---

# Void SetColumnWidths(String guiName, String[] columnWidths)

Set the column widths for the given set of columns and GUI name. 

**Parameters:**
 - **guiName** String that identifies the archive in the GUI, must be the same when fetching and storing configurations, but does not otherwise have to match anything.
 - **columnWidths** Array of column widths. A column width is specified either as a fixed number of character (10c) or as a percentage (10%). Percentages will be recalculated so that they add up to exactly 100 when the configuration is fetched again.
