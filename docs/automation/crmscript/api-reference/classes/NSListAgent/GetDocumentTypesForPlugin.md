---
uid: crmscript_ref_NSListAgent_GetDocumentTypesForPlugin
title: StringDictionary GetDocumentTypesForPlugin(Integer pluginId)
intellisense: NSListAgent.GetDocumentTypesForPlugin
keywords: NSListAgent, GetDocumentTypesForPlugin
so.topic: reference
---

# StringDictionary GetDocumentTypesForPlugin(Integer pluginId)

Get a list of document types supported by a given document plugin. Use the document template type when creating a new template.

**Parameters:**
 - **pluginId** Numeric document plugin id, corresponding to the doctmpl.AutoeventId, doctmpl.LoadTemplateFromPlugin.

**Returns:** StringDictionary

```crmscript
NSListAgent agent;
Integer pluginId;
StringDictionary res = agent.GetDocumentTypesForPlugin(pluginId);
```

