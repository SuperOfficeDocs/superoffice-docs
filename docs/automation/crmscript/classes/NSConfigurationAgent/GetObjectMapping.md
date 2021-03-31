---
title: crmscript_ref_NSConfigurationAgent_GetObjectMapping
description: String GetObjectMapping(String application, String instance)
intellisense: NSConfigurationAgent.GetObjectMapping
keywords: NSConfigurationAgent,GetObjectMapping
so.topic: reference
---

Get the object mappings, i.e., the what code objects should be instantiated to handle the entities of the client configuration.

**Parameters:**
 - **application** The application name, for instance 'SixWeb'
 - **instance** The instance name for the application, like 'MainInstance'

**Returns:** XML containing the object mappings, including assembly and class names

```crmscript
NSConfigurationAgent agent;
String application;
String instance;
String res = agent.GetObjectMapping(application, instance);
```

