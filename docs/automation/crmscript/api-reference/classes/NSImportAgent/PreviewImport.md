---
uid: crmscript_ref_NSImportAgent_PreviewImport
title: NSImportLine[] PreviewImport(NSImportLine[] importLines, String[] columnDefinition, String culture, String context)
intellisense: NSImportAgent.PreviewImport
keywords: NSImportAgent, PreviewImport
so.topic: reference
---

Preview the import

**Parameters:**
 - **importLines** The rows that will be manipulated and according to Import rules
 - **columnDefinition** An array of the columndefinitions, like firstname, lastname, ...
 - **culture** The current culture used in the import. Used to match language specific strings
 - **context** Optional context for the import.

**Returns:** NSImportLine[]

```crmscript
NSImportAgent agent;
NSImportLine[] importLines;
String[] columnDefinition;
String culture;
String context;
NSImportLine[] res = agent.PreviewImport(importLines, columnDefinition, culture, context);
```

