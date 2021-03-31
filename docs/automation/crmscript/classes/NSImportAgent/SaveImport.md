---
uid: crmscript_ref_NSImportAgent_SaveImport
title: IntegerArray SaveImport(ImportLineArray importLines, StringArray columnDefinition, Bool createSelection, String culture, String context)
intellisense: NSImportAgent.SaveImport
keywords: NSImportAgent, SaveImport
so.topic: reference
---

Do the actual import

**Parameters:**
 - **importLines** The rows that will be imported
 - **columnDefinition** An array of the columndefinitions, like firstname, lastname, ...
 - **createSelection** true if a selection of the imported entities shall be made
 - **culture** The current culture used in the import. Used to match language specific strings
 - **context** Optional context for the import.

**Returns:** First part: the id of the selection created after the import, 0 if no selection is created. Second part: The number of rows actually imported

```crmscript
NSImportAgent agent;
ImportLineArray importLines;
StringArray columnDefinition;
Bool createSelection;
String culture;
String context;
IntegerArray res = agent.SaveImport(importLines, columnDefinition, createSelection, culture, context);
```

