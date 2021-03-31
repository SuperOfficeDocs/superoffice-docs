---
title: crmscript_ref_NSArchiveAgent_GetArchiveConfigurationWithContext
description: ArchiveConfiguration GetArchiveConfigurationWithContext(String guiName, String providerName, String context)
intellisense: NSArchiveAgent.GetArchiveConfigurationWithContext
keywords: NSArchiveAgent,GetArchiveConfigurationWithContext
so.topic: reference
---

Get the configuration for one archive, with context parameter. The configuration is keyed by a combination of archive provider name and gui name. The archive provider name must match an archive provider plugin; the gui name is an arbitrary string used to distinguish multiple occurrences of the same underlying provider in a gui.

**Parameters:**
 - **guiName** String that identifies the archive in the GUI, must be the same when fetching and storing configurations, but does not otherwise have to match anything.
 - **providerName** Name of archive provider, must match one of the plugins known to the ArchiveProviderFactory.
 - **context** Context parameter, url-encoded string context parameter for ArchiveProvider constructor

**Returns:** Archive configuration consisting of column information, orderby information and entities

```crmscript
NSArchiveAgent agent;
String guiName;
String providerName;
String context;
ArchiveConfiguration res = agent.GetArchiveConfigurationWithContext(guiName, providerName, context);
```

