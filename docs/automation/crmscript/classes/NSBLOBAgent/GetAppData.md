---
uid: crmscript_ref_NSBLOBAgent_GetAppData
title: String GetAppData(String key)
intellisense: NSBLOBAgent.GetAppData
keywords: NSBLOBAgent, GetAppData
so.topic: reference
---

Get a CLOB (limited to a reasonable size by the mechanics of Web Services) according to a string key; ALSO limits to the current ApplicationToken if any

**Parameters:**
 - **key** The key string, less than 200 characters. Must be unique within each application.

**Returns:** The applications value, suggested to be a JSON, XML or other readable structure

```crmscript
NSBLOBAgent agent;
String key;
String res = agent.GetAppData(key);
```

