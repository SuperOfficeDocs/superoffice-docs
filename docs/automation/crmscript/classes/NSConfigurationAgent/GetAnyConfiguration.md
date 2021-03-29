---
title: crmscript_ref_NSConfigurationAgent_GetAnyConfiguration_String_p_0_String_p_1_String_p_2_String_p_3
description: NSConfigurationAgent.GetAnyConfiguration(String p_0, String p_1, String p_2, String p_3)
intellisense: NSConfigurationAgent.GetAnyConfiguration
sortOrder: 1604
keywords: GetAnyConfiguration(String,String,String,String)
so.topic: reference
---


Get one defined configuration fragment, with full reference resolution and parsing applied. This is essentially the same service as the GetPageConfiguration, except that this service is not locked to objects of type Page.



* **application:** The application name, for instance Six.Web
* **instance:** The instance name, for instance Main
* **item:** The configuration item name (first component of file name)
* **type:** The configuration item type (second component of file name)
* **Returns:** Fully resolved and parsed configuration XML, as string.


