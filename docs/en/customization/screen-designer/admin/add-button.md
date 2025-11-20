---
uid: help-en-screen-designer-button
title: Add a button or link
description: How to add a button or link to a layout using the Screen Designer in Settings and maintenance.
keywords: add button, new button, add link, new link, label
author: digitaldiina
date: 11.20.2025
version: 11.6
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: screen designer
language: en
index: true
redirect_from:
  - /en/ui/screen-designer/configurable-screens/add-button
  - /en/customization/screen-designer/add-button
---

# Add a button or link

[!include[Requirement](../../../includes/req-dev-tools.md)]

Custom buttons and links are added to the **Preview** pane when editing a layout. The URL is used to open a webpage in the current or new tab, run a CRMScript from the screen, or navigate to other parts of SuperOffice using [SoProtocol][3].

Buttons and links work similarly. The difference is that you can style a button but not a link.

> [!TIP]
> You can use [template variables][1] in the URLs.

The instructions below assume you are already [editing the layout][4].

## Add a button

1. Select the tab you want to edit.

1. Select the **Elements** section on the left.

1. Click and drag the **Button** element to the layout.

1. Click to select the new button.

1. In the **Settings** sections to the left, replace the text "Button" with the new button name.

    ![Screen Designer, settings for button element -screenshot][img1]

    > [!TIP]
    > You can also add the button name in other languages.

1. In the **Action** list, select the action to perform when clicking the button. For details about each action, see the reference section at the end of this page.

    * Open website: Select this option to add a link to a website. Select the URL encoding and target as necessary.

    * Execute CRMScript: Select this option to add a [CRMScript][2] to run specific actions in SuperOffice.

    * Shortcut ([SoProtocol][3]): Select this option to add a control that, when clicked, navigates to a different area or screen in SuperOffice.

1. In the **Mode** list, choose if the button should always be available, or if it should only be available in read or edit mode.

1. In the **Style** list, select the style of the button.

## <a id="link"></a>Add links

1. Select the tab you want to edit.

1. Select the **Elements** section on the left.

1. Click and drag the **Link** element to the layout.

1. Click to select the new link field.

1. In the **Settings** sections to the left, replace the text "Link" with the new link name.

    > [!TIP]
    > You can also add the link name in other languages.

1. In the **Action list**, select the action to perform when clicking the link. (Same list as for buttons.)

1. In the **Mode** list, choose if the link should always be available, or if it should only be available in read or edit mode.

## Translating labels

The name and tooltip text can be translated into other languages.

When the element is selected:

1. Click the <i class="ph ph-translate" aria-label="Translate"></i> button next to the label.
1. Click **Add** and select a language from the list.
1. Enter text for the new language.

    ![Screen Designer, translate label -screenshot][img2]

1. Repeat steps 2-3 for additional languages.
1. Click **Close** to exit the translation dialog.

Remember to republish the layout.

## Reference

| Setting | Description | Comment |
|---|---|---|
| Name | Text | Can be translated |
| Action | What will happen when clicked: Open website, CRMScript, SoProtocol | |
| URL | URL | HTTP prefix is added automatically. You must add 'https://' yourself if applicable. |
| Mode | When the element is shown: Always, read mode, edit mode | |
| Tooltip | Text | Can be translated |
| Style | Action, Normal Delete, OK, Edit| NA to links |

Some settings depend on the selected action.

### Open website

* URL encoding: none, ANSI, or Unicode
* Target: new tab or same tab

![Screen Designer, open website on button -screenshot][img4]

> [!NOTE]
> It's recommended to specify the protocol, for example `https://www.superoffice.com`; otherwise, the default is HTTP.

### Execute CRMScript

* CRMScript: Select the specific script to run.

![Screen Designer, execute CRMScript on button -screenshot][img3]

[Learn more about CRMScript][2]

### Shortcut (SoProtocol)

* SoProtocol: The navigation and content part of the URL without the `superoffice:` prefix.

![Screen Designer, SoProtocol on button -screenshot][img5]

[Learn more about SoProtocol][3]

<!-- Referenced links -->
[1]: ../../../document/templates/variables/from-company-card.md
[2]: ../../../../en/automation/crmscript/overview/index.md
[3]: ../../../../en/customization/soprotocol/index.md
[4]: edit-layout.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/customization/new-button.png
[img2]: ../../../../media/loc/en/customization/translate-button-label.png
[img3]: ../../../../media/loc/en/customization/button-script.png
[img4]: ../../../../media/loc/en/customization/button-website.png
[img5]: ../../../../media/loc/en/customization/button-soprotocol.png
