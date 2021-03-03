---
title: pagebuilder_config_page
description: Page config files
author: Tony Yates
so.date: 06.24.2016
keywords: config
so.topic: concept
so.client: web
so.envir: onsite
---

# Page config files

As the name implies, this is the config that will contain the elements of the page. Below is a diagram that shows all the components of a page.

![01][img1]

The top-most level of the design of the page is the `page` element itself. All other elements that make up a page must be inside it.

**The actual config file for the SuperOffice contact page:**

[!code-xml[XML](includes/socontactpage.xml)]

The config file contains some config on data and some references to a few panels. Looking at the diagram, we can see that the second element of a page is a panel and inside the panel only the elements of a page exists. The `data` section of the file tells us where the data for this page is fetched from. The section of the config file shown below says which data handlers will be used to fetch the data for the archive panel.

## Data handler

[!code-xml[XML](includes/socontactpage.xml?range=16-25)]

The XML fragment above says the [data handler][1] for the archive panel is `ArchiveColumnConfigDataHandler`. The **Contact** page archive panel consists of 4 different tabs showing 4 different types of data. The `ArchiveColumnInfos` section tells us which providers the data for the different tabs are fetched from.

So the `data` section tells us how the data is fetched for a page.

## Panels

So now where does the config info of the rest of the elements of the page exist? That is where the below bit of code of the above config file comes in.

[!code-xml[XML](includes/socontactpage.xml?range=28-33)]

Here it tells us the config data for the rest of the page exists in the files that are referenced here. For example, the config data for the main panel of the contact page exists in the *SoContactPanel* config file. But here it has only referenced *Contact* and the system knows through its **config file naming convention** that it has to look in the *SoContactPanel.config* for the config data of the contact main panel.

**Next:** [panel config files][2]

<!-- Referenced links -->
[1]: ../usercontrols/data-binding/index.md
[2]: panel.md

<!-- Referenced images -->
[img1]: ../media/image001.gif
