---
title: Void ClearConfigurationCache(String application, String instance, Bool forAllAssociates)
path: /EJScript/Classes/NSConfigurationAgent/Member functions/Void ClearConfigurationCache(String p_0, String p_1, Bool p_2)
intellisense: 1
classref: 1
sortOrder: 1621
keywords: ClearConfigurationCache(String,String,Bool)
---


Configuration XML's may be expensive to build and parse, and are therefore cached to the database. \<para/>Cahcing is per application/instance/associate, and can be turned off through the config file. \<para/>If caching is on, and the configuration is changed, it is necessary to clear the cached configurations from the database, through this call.\<para/>Note that changes to the externalapplication table require cache invalidation. SoAdmin will do so automatically.



* **application:** The application name, for instance 'SixWeb'
* **instance:** The instance name for the application, like 'MainInstance'
* **forAllAssociates:** If false, only the current associate's configuration is cleared. If true, configurations are cleared for all associates.
* **Returns:** There is no return value.


