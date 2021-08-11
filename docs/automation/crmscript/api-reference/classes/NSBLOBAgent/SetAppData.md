---
uid: crmscript_ref_NSBLOBAgent_SetAppData
title: Void SetAppData(String key, String data)
intellisense: NSBLOBAgent.SetAppData
keywords: NSBLOBAgent, SetAppData
so.topic: reference
---

# Void SetAppData(String key, String data)

Get a CLOB (limited to a reasonable size by the mechanics of Web Services) according to a string key; ALSO limits to the current ApplicationToken if any. Existing data, if any, will be overwritten. Overwrite with a blank value to delete.

**Parameters:**
 - **key** The key string, less than 200 characters. Must be unique within each application.
 - **data** The applications value, suggested to be a JSON, XML or other readable structure

**Returns:** This method has no return value

```crmscript
NSBLOBAgent agent;
String key;
String data;
agent.SetAppData(key, data);
```

