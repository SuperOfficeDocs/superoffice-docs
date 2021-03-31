---
title: crmscript_ref_NSConfigurationAgent_ClearConfigurationCache
description: Void ClearConfigurationCache(String application, String instance, Bool forAllAssociates)
intellisense: NSConfigurationAgent.ClearConfigurationCache
keywords: NSConfigurationAgent,ClearConfigurationCache
so.topic: reference
---

Configuration XML's may be expensive to build and parse, and are therefore cached to the database. <para/>Cahcing is per application/instance/associate, and can be turned off through the config file. <para/>If caching is on, and the configuration is changed, it is necessary to clear the cached configurations from the database, through this call.<para/>Note that changes to the externalapplication table require cache invalidation. SoAdmin will do so automatically.

**Parameters:**
 - **application** The application name, for instance 'SixWeb'
 - **instance** The instance name for the application, like 'MainInstance'
 - **forAllAssociates** If false, only the current associate's configuration is cleared. If true, configurations are cleared for all associates.

**Returns:** There is no return value.

```crmscript
NSConfigurationAgent agent;
String application;
String instance;
Bool forAllAssociates;
Void res = agent.ClearConfigurationCache(application, instance, forAllAssociates);
```

