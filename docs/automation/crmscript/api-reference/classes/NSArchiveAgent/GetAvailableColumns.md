---
uid: crmscript_ref_NSArchiveAgent_GetAvailableColumns
title: NSArchiveColumnInfo[] GetAvailableColumns(String providerName, String context)
intellisense: NSArchiveAgent.GetAvailableColumns
keywords: NSArchiveAgent, GetAvailableColumns
so.topic: reference
---

# NSArchiveColumnInfo[] GetAvailableColumns(String providerName, String context)

Return list of all columns supported by an archive provider. See also GetArchiveConfiguration.

**Parameters:**
 - **providerName** The name of the archive provider to use; it will be created via the ArchiveProviderFactory from a plugin
 - **context** Optional context parameter, url-encoded string context parameter for ArchiveProvider constructor

**Returns:** Array of all columns supported by the archive provider. 

```crmscript
NSArchiveAgent agent;
String providerName;
String context;
NSArchiveColumnInfo[] res = agent.GetAvailableColumns(providerName, context);
```

