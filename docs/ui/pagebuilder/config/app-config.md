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

# Application config file

The application configuration file lists all the pages used in the system. It stores data like the preference section for a given page in the `UserPreference` table and what the key of the preference is. It holds the current information of a given page in the current section of the file.

## SoApplicationConfiguration

[!code-xml[xml](includes/soapplicationconfiguration.xml)]

In the above file, we can see that the pages are listed inside the `pages` element. The user preference data for all the pages will be stored under the *SuperMode* section and the key will be *MainPanel*.

When we go into the individual pages, it gives the page ID, the type of the page, and if it is a main page, the functional rights it has. If the page is not a main page, we can see that the size information of the page has been detailed out since it is not appearing as a page but as a dialog.

In the `currents` section, it gives details about where the application has stored the current data for a given page. For example, the below line says that the current appointment is stored in the `history` table and the provider that will retrieve the data for us is the *SoProtocolProvider*. Likewise, it will list all the current values of the application.

[!code-xml[xml](includes/soapplicationconfiguration.xml?range=14)]
