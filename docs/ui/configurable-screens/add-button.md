---
uid: screen-add-button
title:  Add a button or link
description: How to add a button or link to a layout using the Screen Designer in Settings and maintenance.
author: Bergfrid Dias
so.date: 10.10.2022
keywords: ui, screen, customization
so.topic: howto
so.version: 10
so.envir:
so.client:
---

# Add a button or link

[!include[Requirement](../../../common/includes/req-dev-tools.md)]

Add custom buttons and links to the same areas you can add fields to. You can add URLs for looking up information in other websites, allow users to run CRMScripts from the screen, and add navigation to other parts of SuperOffice using SoProtocol.

Buttons and links work similarly. The difference is that you can style a button but not a link.

> [!TIP]
> You can use [template variables][1] in the URLs.

## Add a button

1. Select the tab you want to edit.
1. Select the **Elements** section on the left.
1. Click and drag the **Button** element to the layout.
1. Click to select the new button.
1. In the **Settings** sections to the left, replace the text "Button" with the new button name.

    > [!TIP]
    > You can also add the link name in other languages.

1. In the **Action** list, select the action to perform when clicking the button:

    * Open website: Select this option to add a link to a website. Select the URL encoding and target as necessary.
    * Execute CRMScript: Select this option to add a [CRM script][2] to run specific actions in SuperOffice.
    * Shortcut ([SoProtocol][3]): Select this option to add a shortcut to other screens and records in SuperOffice.

1. In the **Mode** list, choose if the button should always be available, or if it should only be available in read or edit mode.
1. In the **Style** list, select the style of the button.

## Add links

1. Select the tab you want to edit.
1. Select the **Elements** section on the left.
1. Click and drag the **Link** element to the layout.
1. Click to select the new link field.
1. In the **Settings** sections to the left, replace the text "Link" with the new link name.

    > [!TIP]
    > You can also add the link name in other languages.

1. In the **Action list**, select the action to perform when clicking the link. (Same list as for buttons.)
1. In the **Mode** list, choose if the link should always be available, or if it should only be available in read or edit mode.

<!-- Referenced links -->
[1]: ../../document/templates/variables/from-company-card.md
[2]: ../../automation/crmscript/overview/index.md
[3]: ../soprotocol/index.md

<!-- Referenced images -->
