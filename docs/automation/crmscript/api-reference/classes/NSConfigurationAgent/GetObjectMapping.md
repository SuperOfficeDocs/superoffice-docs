---
uid: crmscript_ref_NSConfigurationAgent_GetObjectMapping
title: String GetObjectMapping(String application, String instance)
intellisense: NSConfigurationAgent.GetObjectMapping
keywords: NSConfigurationAgent, GetObjectMapping
so.topic: reference
---

# String GetObjectMapping(String application, String instance)

Get the object mappings, i.e., the what code objects should be instantiated to handle the entities of the client configuration.

**Parameters:**
 - **application** The application name, for instance 'SixWeb'
 - **instance** The instance name for the application, like 'MainInstance'

**Returns:** String

```crmscript
NSConfigurationAgent agent;
String application;
String instance;
String res = agent.GetObjectMapping(application, instance);
```

