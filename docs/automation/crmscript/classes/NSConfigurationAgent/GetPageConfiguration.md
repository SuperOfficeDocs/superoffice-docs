---
title: crmscript_ref_NSConfigurationAgent_GetPageConfiguration_String_p_0_String_p_1_String_p_2
description: NSConfigurationAgent.GetPageConfiguration(String p_0, String p_1, String p_2)
intellisense: NSConfigurationAgent.GetPageConfiguration
sortOrder: 1617
keywords: GetPageConfiguration(String,String,String)
so.topic: reference
---


Get the configuration for one whole web page, including all its panels etc.  totally asynchronous items like menus are not included, but all references are resolved and all special processing is applied.



* **application:** The application name, for instance 'SixWeb
* **instance:** The instance name for the application, like 'MainInstance'
* **page:** Page name, must correspond to one of the pages in the Application Configuration
* **Returns:** XML containing the configuration for the given page, from the page down to the control level.


