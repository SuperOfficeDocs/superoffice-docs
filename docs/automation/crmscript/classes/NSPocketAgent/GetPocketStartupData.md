---
title: crmscript_ref_NSPocketAgent_GetPocketStartupData
description: PocketStartupData GetPocketStartupData(StringArray tables, DateTime currentClientTime)
intellisense: NSPocketAgent.GetPocketStartupData
keywords: NSPocketAgent,GetPocketStartupData
so.topic: reference
---



**Parameters:**
 - **tables** Tables to check for license
 - **currentClientTime** Current time on the client, used for overdue sale lookup having correct timezone relative to client

**Returns:** Startup data for pocket

```crmscript
NSPocketAgent agent;
StringArray tables;
DateTime currentClientTime;
PocketStartupData res = agent.GetPocketStartupData(tables, currentClientTime);
```

