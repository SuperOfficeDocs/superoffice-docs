---
uid: crmscript_ref_NSConfigurationAgent_GetAnyConfiguration
title: String GetAnyConfiguration(String application, String instance, String item, String type)
intellisense: NSConfigurationAgent.GetAnyConfiguration
keywords: NSConfigurationAgent, GetAnyConfiguration
so.topic: reference
---

# String GetAnyConfiguration(String application, String instance, String item, String type)

Get one defined configuration fragment, with full reference resolution and parsing applied. This is essentially the same service as the GetPageConfiguration, except that this service is not locked to objects of type Page.

**Parameters:**
 - **application** The application name, for instance Six.Web
 - **instance** The instance name, for instance Main
 - **item** The configuration item name (first component of file name)
 - **type** The configuration item type (second component of file name)

**Returns:** String

```crmscript
NSConfigurationAgent agent;
String application;
String instance;
String item;
String type;
String res = agent.GetAnyConfiguration(application, instance, item, type);
```

