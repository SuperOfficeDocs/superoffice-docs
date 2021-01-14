---
title: String GetPageConfiguration(String application, String instance, String page)
path: /EJScript/Classes/NSConfigurationAgent/Member functions/String GetPageConfiguration(String p_0, String p_1, String p_2)
intellisense: 1
classref: 1
sortOrder: 1617
keywords: GetPageConfiguration(String,String,String)
---


Get the configuration for one whole web page, including all its panels etc.  totally asynchronous items like menus are not included, but all references are resolved and all special processing is applied.



* **application:** The application name, for instance 'SixWeb
* **instance:** The instance name for the application, like 'MainInstance'
* **page:** Page name, must correspond to one of the pages in the Application Configuration
* **Returns:** XML containing the configuration for the given page, from the page down to the control level.


