---
title: crmscript_ref_NSArchiveAgent_GetArchiveConfigurationV2
description: ArchiveConfiguration GetArchiveConfigurationV2(String guiName, String providerName, String context, String ownerKeys)
intellisense: NSArchiveAgent.GetArchiveConfigurationV2
keywords: NSArchiveAgent,GetArchiveConfigurationV2
so.topic: reference
---

Get the configuration for one archive. The configuration is keyed by a combination of archive provider name (plus optional context), gui name, and optional table binding. The archive provider name must match an archive provider plugin; the gui name is an arbitrary string used to distinguish multiple occurrences of the same underlying provider in a gui.

**Parameters:**
 - **guiName** String that identifies the archive in the GUI, must be the same when fetching and storing configurations, but does not otherwise have to match anything.
 - **providerName** Name of archive provider, must match one of the plugins known to the ArchiveProviderFactory.
 - **context** Context parameter, url-encoded string context parameter for ArchiveProvider constructor. Optional, but required for archives that depend on a context - for instance Quote archives that need to know their QuoteConnectionId to be meaningful
 - **ownerKeys** Name/value string containing ownership binding information. The first should resolve to a table/primarykey, such as selection=123. Future functionality may allow multiple/extended keys

**Returns:** Archive configuration consisting of column information, orderby information and entities

```crmscript
NSArchiveAgent agent;
String guiName;
String providerName;
String context;
String ownerKeys;
ArchiveConfiguration res = agent.GetArchiveConfigurationV2(guiName, providerName, context, ownerKeys);
```

