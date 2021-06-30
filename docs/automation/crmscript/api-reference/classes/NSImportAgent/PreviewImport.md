---
uid: crmscript_ref_NSImportAgent_PreviewImport
title: ImportLine[] PreviewImport(ImportLine[] importLines, String[] columnDefinition, String culture, String context)
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

**Returns:** An array of the the rows that can be imported, manipulated according to Import rules given

```crmscript
NSImportAgent agent;
ImportLine[] importLines;
String[] columnDefinition;
String culture;
String context;
ImportLine[] res = agent.PreviewImport(importLines, columnDefinition, culture, context);
```

