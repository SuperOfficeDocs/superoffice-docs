---
uid: help-en-screen-designer-elements
title: Elements in the Screen Designer
description: Elements in the Screen Designer
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Elements

## Add labels

Labels can be used to create headings for specific groups of fields or a column.

1. Select the tab you want to edit.
2. Click and drag the **Label** element to the layout.
3. Click the label.
4. In the **Settings** sections, replace the text **New label** with the new label name.
5. You can also [add the label in other languages][2] by clicking ![icon][img1].
6. Change the font formatting as necessary.

## Add dividers

Use dividers to create sections within columns. Useful for grouping various types of information.

1. Select the tab you want to edit.
2. Click and drag the **Divider** element to the layout.
3. Click the divider.
4. If relevant, change the spacer type.

## Add links

Add links for looking up information in other websites, allow users to run CRM scripts from the company and contact cards, and add navigation to other parts of SuperOffice using soprotocol. You can also use buttons to add links.

> [!TIP]
> You can use [Template variables][3] in the URLs.

1. Select the tab you want to edit.

2. Click and drag the **Link** element to the layout.

3. Click the link field.

4. In the **Settings** sections, replace the text **Link** with the new link name.

5. You can also [add the link name in other languages][2] by clicking ![icon][img1].

6. In the **Action** list, select the action to perform when clicking the link:

    * **Open website**: Select this option to add a link to a website. Select the URL encoding and target as necessary.
    * **Execute CRMScript**: Select this option to add a [CRMScript][6] to run specific actions in SuperOffice.
    * **Shortcut (soprotocol)**: Select this option to add a [shortcut to other screens and records][1] in SuperOffice.

7. In the **Mode** list, choose if the link should always be available, or if it should be available only in read or edit mode.

## Add buttons

Buttons work similarly to links. You can add links for looking up information in other websites, allow users to run CRM scripts from the company and contact cards, and add navigation to other parts of SuperOffice using soprotocol.

> [!TIP]
> You can use [Template variables][3] in the URLs.

1. Select the tab you want to edit.

2. Click and drag the **Button** element to the layout.

3. Click the button.

4. In the **Settings** sections, replace the text **Button** with the new button name.

5. You can also [add the button name in other languages][2] by clicking ![icon][img1].

6. In the **Action** list, select the action to perform when clicking the button:

    * **Open website**: Select this option to add a link to a website. Select the URL encoding and target as necessary.
    * **Execute CRMScript**: Select this option to add a CRM script to run specific actions in SuperOffice. See [CRMScript][6].
    * **Shortcut (soprotocol)**: Select this option to add a shortcut to other screens and records in SuperOffice. See [SOProtocol][1].

7. In the **Mode** list, choose if the button should always be available, or if it should be available only in read or edit mode.

8. In the **Style** list, select the style of the button. The preview on the right will update with the selected button style.

## Add grid (table)

Grids give you more control over the position of fields. It can be useful if you have many user-defined fields.

1. Select the tab you want to edit.

2. Click and drag the **Grid** element to the layout.

3. Click to select the grid in the preview.

4. In the **Settings** sections, adjust the number of rows and columns.

5. Choose a grid style: lines (default), none, or header.

6. Add fields, labels, links, and buttons to the grid to populate it.

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/ui/soprotocol/index.html
[2]: ../../../globalization-and-localization/learn/translate-fields.md
[3]: ../../../document/learn/template-variables.md
[6]: ../../../automation/crmscript/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/az.png
