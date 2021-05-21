---
title: Card config files
uid: pagebuilder_config_card
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

A card configuration file defines the UI structure of a card and contains the layout of views in the card, which in turn contain controls.

Cards are placeholders inside panels and use layout positioning, and are responsible for invoking relevant data handlers for save and delete actions.

![PageFramework][img1]

```xml
<!-- SoExampleCard.config -->
<card id="ExampleCard" type="Card"
       placeholderid="OnePanePlaceHolder"
       cardtype="SoTabbedCard">
  <views>
    <view />
  </views>
  <config>
    <datahandlers-to-save>
      <datahandler-reference>ExampleDataHandler</datahandler-reference>
    </datahandlers-to-save>
    <datahandlers-to-delete>
      <datahandler-reference>ExampleDataHandler</datahandler-reference>
    </datahandlers-to-delete>
    <keep-params-onsave />
    <customcssclass />
    <editmode />
  </config>
</card>
```

## Different card types

| Name | Description |
|---|---|
| [SoDialogCard][3] | Used with DialogPanel. |
| [SoDialogSimpleCard][4] | Used with DialogPanel. |
| [SoDiaryCard][5] | Adds an associate chooser to the card. |
| [FloatingCard][6] | Not used |
| [SoFindCard][7] | |
| [SoTabbedCard][8] | Used to add tab container for views |
| [SoWizardCard][9] | As seen in MailMerge and Add todo task. |

## Attributes

[!code-xml[XML](includes/minicard.xml?range=1)]

The above line explains the config for the card. It says the card ID is *MiniCard* and the place holder is the right panel. The `placeholderid` refers to the pane ID defined in the panel config.

The card type here tells us what the type of the card within the page is since there can be many types of cards within a page like the **Archive** card, the **Mini card**, and so on.

## Views

Within the card comes the `views` element, which groups the config data for the views within a given card.

The views can be displayed one by one or all at once, this is decided by the implementation of the card. In SuperOffice, the card will display a tab control or a drop-down control telling the user which view is active and what other views are available.

![02][img2]

You can use [SoProtocol][10] strings in the URL to force a switch to a particular view.

The config data for a view can appear in 2 ways: within the views tag or in a separate config file called a [fragment][11]

**Next:** [view config files][2]

<!-- Referenced links -->
[1]: panel.md
[2]: view.md
[3]: https://community.superoffice.com/documentation/SDK/SO.Web.Application/html/T_SuperOffice_CRM_Web_UI_Controls_DialogCard.htm
[4]: https://community.superoffice.com/documentation/SDK/SO.Web.Application/html/T_SuperOffice_CRM_Web_UI_Cards_and_Views_DialogSimpleCard.htm
[5]: https://community.superoffice.com/documentation/SDK/SO.Web.Application/html/T_SuperOffice_CRM_Web_UI_Controls_DiaryCard.htm
[6]: https://community.superoffice.com/documentation/SDK/SO.Web.Application/html/T_SuperOffice_CRM_Web_UI_Controls_FloatingCard.htm
[7]: https://community.superoffice.com/documentation/SDK/SO.Web.Application/html/T_SuperOffice_CRM_Web_UI_Controls_FindCard.htm
[8]: https://community.superoffice.com/documentation/SDK/SO.Web.Application/html/T_SuperOffice_CRM_Web_UI_Controls_TabbedCard.htm
[9]: https://community.superoffice.com/documentation/SDK/SO.Web.Application/html/T_SuperOffice_DCF_Web_UI_Controls_WizardCard.htm
[10]: ../../../soprotocol/index.md
[11]: soml.md

<!-- Referenced images -->
[img1]: media/web-client-pagebuilder-framework2.png
[img2]: media/image002.jpg
