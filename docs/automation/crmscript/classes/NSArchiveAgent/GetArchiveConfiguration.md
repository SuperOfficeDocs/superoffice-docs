---
title: crmscript_ref_NSArchiveAgent_GetArchiveConfiguration_String_p_0_String_p_1
description: NSArchiveAgent.GetArchiveConfiguration(String p_0, String p_1)
intellisense: NSArchiveAgent.GetArchiveConfiguration
sortOrder: 1103
keywords: GetArchiveConfiguration(String,String)
so.topic: reference
---


Get the configuration for one archive. The configuration is keyed by a combination of archive provider name and gui name. The archive provider name must match an archive provider plugin; the gui name is an arbitrary string used to distinguish multiple occurrences of the same underlying provider in a gui.



* **guiName:** String that identifies the archive in the GUI, must be the same when fetching and storing configurations, but does not otherwise have to match anything.
* **providerName:** Name of archive provider, must match one of the plugins known to the ArchiveProviderFactory.
* **Returns:** Archive configuration consisting of column information, orderby information and entities


