---
title: pagebuilder_config_panel
description: Panel config files
author: Tony Yates
so.date: 06.24.2016
keywords: config
so.topic: concept
so.client: web
so.envir: onsite
---

# Panel config files

Corresponding to the same diagram as we looked at discussing the components of a page, a panel config file contains config data on the other elements of the page.

![01][img1]

* Inside a panel, there can be many cards
* Inside a card, there can be views
* Inside a view, there can be many controls (Which are not shown in the diagram)

## SoContactPanel

Below is an excerpt of the *SoContactPanel.config* file. We have cut out some parts to keep it reasonably short.

[!code-xml[XML](includes/socontactpanel.xml)]

The essential structure of the panel configuration looks like this:

[!code-xml[XML](includes/socontactpanel.xml?range=2,4-8,19-23,92-93,96-98,109)]

The **outer element** in this config file is `panel`. All the other config data is inside this element and makes up the config for the panel.

## cards element

The second level here is the `cards` element, which holds the config data for all the cards in the config. That means a panel can hold many cards and the config data for those cards are grouped by the `cards` element.

* The `placeholderid` is a reference to a region of a page – where the content of this section should be placed. These names are defined on the master page.

* The `type` and `cardtype` indicate which rendering interface should be used. These are defined in the *SoObjectMapping.config* file.

## card element

The next level of the config file is the `card` element. The config data for the card can appear in 2 ways inside the `cards` element. If it is referenced, there will be a [separate config file for the card][1].

**Option 1:**

[!code-xml[XML](includes/socontactpanel.xml?range=5)]

**Option 2:**

[!code-xml[XML](includes/socontactpanel.xml?range=20)]

<!-- Referenced links -->
[1]: card.md

<!-- Referenced images -->
[img1]: media/image001.gif
