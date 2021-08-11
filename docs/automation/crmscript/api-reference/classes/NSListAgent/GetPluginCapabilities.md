---
uid: crmscript_ref_NSListAgent_GetPluginCapabilities
title: StringDictionary GetPluginCapabilities(Integer pluginId)
intellisense: NSListAgent.GetPluginCapabilities
keywords: NSListAgent, GetPluginCapabilities
so.topic: reference
---

# StringDictionary GetPluginCapabilities(Integer pluginId)

Get a list of plugin-dependent capabilities for a given document archive plugin.<br/>A standard set of properties is defined in SuperOffice.CRM.Documents.Constants.Capabilities.

**Parameters:**
 - **pluginId** Numeric document plugin id, corresponding to the document.archiveProvider id or doctmpl.AutoeventId.

**Returns:** StringDictionary

```crmscript
NSListAgent agent;
Integer pluginId;
StringDictionary res = agent.GetPluginCapabilities(pluginId);
```

