---
uid: crmscript_ref_NSConfigurationAgent_GetPageConfiguration
title: String GetPageConfiguration(String application, String instance, String page)
intellisense: NSConfigurationAgent.GetPageConfiguration
keywords: NSConfigurationAgent, GetPageConfiguration
so.topic: reference
---

Get the configuration for one whole web page, including all its panels etc.  totally asynchronous items like menus are not included, but all references are resolved and all special processing is applied.

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
String res = agent.GetPageConfiguration(application, instance, page);
```

