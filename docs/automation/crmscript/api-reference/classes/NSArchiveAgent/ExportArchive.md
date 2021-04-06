---
uid: crmscript_ref_NSArchiveAgent_ExportArchive
title: ExportArchiveResult ExportArchive(String providerName, String context, StringArray desiredEntities, StringArray columns, ArchiveOrderByInfoArray sortOrder, ArchiveRestrictionInfoArray restrictions, String exportType, StringArray selectedRowIds, Integer estimatedRowCount)
intellisense: NSArchiveAgent.ExportArchive
keywords: NSArchiveAgent, ExportArchive
so.topic: reference
---

Exports the target archive to a downloadable format.

**Parameters:**
 - **providerName** The name of the archive provider to use; it will be created via the ArchiveProviderFactory from a plugin
 - **context** Context parameter, url-encoded string context parameter for ArchiveProvider constructor
 - **desiredEntities** Comma separated list of the names of the desired entities.
 - **columns** Comma separated list of the names of the columns wanted; supports display names
 - **sortOrder** 
 - **restrictions** 
 - **exportType** To what format the archive should be exported; Excel, etc.
 - **selectedRowIds** 
 - **estimatedRowCount** The estimated amount of rows to be exported. Used to determine if the operation should be run as a batch task or immediately.
