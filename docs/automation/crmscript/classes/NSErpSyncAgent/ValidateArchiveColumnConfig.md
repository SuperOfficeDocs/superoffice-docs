---
uid: crmscript_ref_NSErpSyncAgent_ValidateArchiveColumnConfig
title: Void ValidateArchiveColumnConfig(String listOwner, Integer erpConnectionId)
intellisense: NSErpSyncAgent.ValidateArchiveColumnConfig
keywords: NSErpSyncAgent, ValidateArchiveColumnConfig
so.topic: reference
---

Clear field info from table SUPERLISTCOLUMNSIZE if field mapping changed on given connection

**Parameters:**
 - **listOwner** GUI name used in archive control config
 - **erpConnectionId** The ERP connection ID

**Returns:** Validated ArchiveColumnConfig

```crmscript
NSErpSyncAgent agent;
String listOwner;
Integer erpConnectionId;
Void res = agent.ValidateArchiveColumnConfig(listOwner, erpConnectionId);
```

