---
uid: crmscript_ref_NSImportAgent_CreateDefaultImportLine
title: NSImportLine CreateDefaultImportLine(Integer countColumns)
intellisense: NSImportAgent.CreateDefaultImportLine
keywords: NSImportAgent, CreateDefaultImportLine
so.topic: reference
---

Create a new empty import row with x count of values

**Parameters:**
 - **countColumns** The count of values that will can be filled out

**Returns:** NSImportLine

```crmscript
NSImportAgent agent;
Integer countColumns;
NSImportLine res = agent.CreateDefaultImportLine(countColumns);
```

