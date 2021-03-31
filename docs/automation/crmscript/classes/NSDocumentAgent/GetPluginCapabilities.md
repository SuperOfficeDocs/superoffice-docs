---
uid: crmscript_ref_NSDocumentAgent_GetPluginCapabilities
title: StringDictionary GetPluginCapabilities(Integer pluginId)
intellisense: NSDocumentAgent.GetPluginCapabilities
keywords: NSDocumentAgent, GetPluginCapabilities
so.topic: reference
---

Get a list of plugin-dependent capabilities for a given document archive plugin.<br/>A standard set of properties is defined in SuperOffice.CRM.Documents.Constants.Capabilities.

**Parameters:**
 - **pluginId** Numeric document plugin id, corresponding to the document.archiveProvider id or doctmpl.autoeventid.

**Returns:** Dictionary mapping capability names=values

```crmscript
NSDocumentAgent agent;
Integer pluginId;
StringDictionary res = agent.GetPluginCapabilities(pluginId);
```

