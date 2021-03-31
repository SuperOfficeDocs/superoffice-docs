---
uid: crmscript_ref_NSConfigurationAgent_GetRefreshedPageConfiguration
title: String GetRefreshedPageConfiguration(String application, String instance, String page)
intellisense: NSConfigurationAgent.GetRefreshedPageConfiguration
keywords: NSConfigurationAgent, GetRefreshedPageConfiguration
so.topic: reference
---

Get the configuration for one whole web page, including all its panels etc.  totally asynchronous items like menus are not included, but all references are resolved and all special processing is applied. Does not use cache for fetching, but updates the cache with refreshed configuration.

**Parameters:**
 - **application** The application name, for instance 'SixWeb
 - **instance** The instance name for the application, like 'MainInstance'
 - **page** Page name, must correspond to one of the pages in the Application Configuration

**Returns:** XML containing the configuration for the given page, from the page down to the control level.

```crmscript
NSConfigurationAgent agent;
String application;
String instance;
String page;
String res = agent.GetRefreshedPageConfiguration(application, instance, page);
```

