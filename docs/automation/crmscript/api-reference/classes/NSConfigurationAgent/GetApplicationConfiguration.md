---
uid: crmscript_ref_NSConfigurationAgent_GetApplicationConfiguration
title: String GetApplicationConfiguration(String application, String instance)
intellisense: NSConfigurationAgent.GetApplicationConfiguration
keywords: NSConfigurationAgent, GetApplicationConfiguration
so.topic: reference
---

# String GetApplicationConfiguration(String application, String instance)

Return the application configuration. This is a list of pages, with information about the name, main panel and preference mappings of each page.

**Parameters:**
 - **application** The application name, for instance 'SixWeb'
 - **instance** The instance name for the application, like 'MainInstance'

**Returns:** String

```crmscript
NSConfigurationAgent agent;
String application;
String instance;
String res = agent.GetApplicationConfiguration(application, instance);
```

