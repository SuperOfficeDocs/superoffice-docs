---
title: pagebuilder_config_objectmapping
description: Object mapping config files
author: Tony Yates
so.date: 06.24.2016
keywords: config
so.topic: concept
so.client: web
so.envir: onsite
---

# Object mapping files

Since all the rendering and building of a page in SuperOffice Web depends on XML configuration files, we need a mechanism to map the objects of the pages to the actual objects of the system. For example, in which assembly a particular control is taken from.

Below is an excerpt of an object mapping config file. We have cut out some parts to keep it reasonably short.

[!code-xml[XML](includes/mapping.xml)]

[!include[ALT](../includes/object-parameters.md)]

For example, the following line tells us the object that is represented by this line is referred to as *SoPanel* in other config files, resides in the *SuperOffice.CRMWeb* assembly, and is called `SuperOffice.CRM.Web.UI.Controls.Panel`.

[!code-xml[XML](includes/mapping.xml?range=3)]

When you have the mapping like this in a config file, it is very easy for a class factory to come in and use these configurations to build the actual objects. By using this method we can gain another advantage: we can very easily extend the object library and we can add customization versions very easily as well. The logic behind this is if the name of the object does not change, we can alter the behavior of the object and the PageBuilder framework will not know the difference.
