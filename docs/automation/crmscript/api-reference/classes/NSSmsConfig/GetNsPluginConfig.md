---
uid: crmscript_ref_NSSmsConfig_GetNsPluginConfig
title: StringDictionary GetNsPluginConfig()
intellisense: NSSmsConfig.GetNsPluginConfig
keywords: NSSmsConfig, GetNsPluginConfig
so.topic: reference
---

# StringDictionary GetNsPluginConfig()

Configuration settings provided by the SMS provider. Typically contains newline-delimited settings such as username and password.

**Returns:** StringDictionary

```crmscript
NSSmsConfig thing;
StringDictionary nsPluginConfig  = thing.GetNsPluginConfig();
```

