---
title: crmscript_ref_NSListAgent_GetDocumentTypesForPlugin
description: IntStringDictionary GetDocumentTypesForPlugin(Integer pluginId)
intellisense: NSListAgent.GetDocumentTypesForPlugin
keywords: NSListAgent,GetDocumentTypesForPlugin
so.topic: reference
---

Get a list of document types supported by a given document plugin. Use the document template type when creating a new template.

**Parameters:**
 - **pluginId** Numeric document plugin id, corresponding to the doctmpl.AutoeventId, doctmpl.LoadTemplateFromPlugin.

**Returns:** Dictionary mapping document type id=name

```crmscript
NSListAgent agent;
Integer pluginId;
IntStringDictionary res = agent.GetDocumentTypesForPlugin(pluginId);
```

