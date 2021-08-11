---
uid: crmscript_ref_NSConfigurationAgent_GetCSRegistryValue
title: String GetCSRegistryValue(Integer entry)
intellisense: NSConfigurationAgent.GetCSRegistryValue
keywords: NSConfigurationAgent, GetCSRegistryValue
so.topic: reference
---

# String GetCSRegistryValue(Integer entry)

This method will get a value from the CS Registry table.

**Parameters:**
 - **entry** The Registry entry to get

**Returns:** String

```crmscript
NSConfigurationAgent agent;
Integer entry;
String res = agent.GetCSRegistryValue(entry);
```

