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

Add custom buttons and links. For example, to run a CRMScript.

Tip: You can use [Template variables][1] in the URLs.

## Add buttons

Buttons work similarly to links. You can add links for looking up information in other websites, allow users to run CRM scripts from the company and contact cards, and add navigation to other parts of SuperOffice using soprotocol.

1. Select the tab you want to edit.
2. Click and drag the Button element to the layout.
3. Click the button. The Settings sections opens to the left.
4. Replace the text Button with the new button name.
5. You can also add the button name in other languages.
6. In the Action list, select the action to perform when clicking the button:

    * Open website: Select this option to add a link to a website. Select the URL encoding and target as necessary.
    * Execute CRMScript: Select this option to add a [CRM script][2] to run specific actions in SuperOffice.
    * Shortcut ([soprotocol][3]): Select this option to add a shortcut to other screens and records in SuperOffice.

7. In the Mode list, choose if the button should always be available, or if it should only be available in read or edit mode.

8. In the Style list, select the style of the button. The preview on the right will update with the selected button style.

## Add links

Add links for looking up information in other websites, allow users to run CRM scripts from the company and contact cards, and add navigation to other parts of SuperOffice using soprotocol. You can also use buttons to add links.

1. Select the tab you want to edit.
2. Click and drag the Link element to the layout.
3. Click the link field. The Settings sections opens to the left.
4. Replace the text Link with the new link name.
5. You can also add the link name in other languages.
6. In the Action list, select the action to perform when clicking the link:

    * Same list as for buttons

7. In the Mode list, choose if the link should always be available, or if it should only be available in read or edit mode.

<!-- Referenced links -->
[1]: ../../document/templates/variables/from-company-card.md
[2]: ../../automation/crmscript/overview/index.md
[3]: ../soprotocol/index.md

<!-- Referenced images -->
