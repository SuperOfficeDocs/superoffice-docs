---
uid: crmscript_ref_NSImportAgent_CreateDefaultImportLine
title: ImportLine CreateDefaultImportLine(Integer countColumns)
intellisense: NSImportAgent.CreateDefaultImportLine
keywords: NSImportAgent, CreateDefaultImportLine
so.topic: reference
---

Create a new empty import row with x count of values

**Parameters:**
 - **countColumns** The count of values that will can be filled out

**Returns:** A new ImportLine

```crmscript
NSImportAgent agent;
Integer countColumns;
ImportLine res = agent.CreateDefaultImportLine(countColumns);
```

