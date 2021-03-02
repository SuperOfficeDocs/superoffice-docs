---
title: pagebuilder_config_card
description: Card config files
author: Tony Yates
so.date: 06.24.2016
keywords: config
so.topic: concept
so.client: web
so.envir: onsite
---

# Card config files

What appears inside the `card` element is the config data for the many views that a card can have. Let’s take the below config section from the card config file that was referenced in [SoContactPanel][1], *MiniCard*.

[!code-xml[XML](includes/minicard.xml)]

The **outer** element in the config file is `card`, just like the `panel` element was in the panel config file. This element holds the config data for the different views that can appear on a card.

## Attributes

[!code-xml[XML](includes/minicard.xml?range=1)]

The above line explains the config for the card. It says the card ID is *MiniCard* and the place holder is the right panel. The `placeholderid` refers to the pane ID defined in the panel config.

The card type here tells us what the type of the card within the page is since there can be many types of cards within a page like the **Archive** card, the **Mini card**, and so on.

## Views

Within the card comes the `views` element, which groups the config data for the views within a given card.

The config data for a view can appear in 2 ways: within the views tag or in a separate config file.

With the code below, the config data for a view will appear as a separate config file because we have referenced the views within the cards:

```XML
<cards>
  <card id="ContactMainCard" type="SoTabbedCard" placeholderid="leftpanel" cardtype="MainCard">
    <views>
      <view id="MainView" reference="MainView"></view>
    </views>
  </card>
</cards>
```

The reference *MainView* in the `view` element means that the definition can be found in the `SoMainViewconfig` file.

**Next:** [view config files][2]

<!-- Referenced links -->
[1]: panel.md
[2]: view.md

<!-- Referenced images -->
