---
uid: help-en-marketing-editor
title: Drag and drop editor
description: Drag and drop editor
keywords: marketing, editor, template variable, merge tag
author: SuperOffice Product and Engineering
date: 09.26.2025
version: 10.5
content_type: concept
category: marketing
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
redirect_from: /en/marketing/learn/editor
language: en
---

# Drag and drop editor

![Drag and drop editor -screenshot][img1]

In the **Content** step you can edit the appearance and content of the message.

* You can [insert text and images][1] (and other content) in the columns and rows of the message.

* You can define format/layout (such as font type and size, colors and margins) at global level (the whole message) or by individual sections.

* You can easily drag and drop content from the side-panel (menus, buttons, SoMe links, HTML content, and header and footer blocks).

SuperOffice Marketing is supplied with many [ready-made message templates][9], and you can easily move content around to get the appearance you want. Save frequently used content as blocks to save time.

> [!TIP]
> We normally recommend a maximum width of 600 pixels for mailings. You can also check what the mailing will look like, on smart phones for example, by clicking **Mobile** (<i class="ph ph-device-mobile" aria-hidden="true"></i>) in the menu in the lower left corner. See also [Customize the message for display on mobile devices][3].

## Edit columns and blocks/sections

When you click a section (such as column, content box, row), buttons with editing options appear. The side-panel displays editing options for the selected section.

A blue frame is shown around the selected element, so that you always know which part of the message you are editing.

If you click text content, a text editing toolbar is displayed.

The global menu is always displayed at the lower left of the content area.

## Edit text and images

[Edit text][5], [insert images][6] and add other content by clicking a section in the message. Use the text editing toolbar and the side-panel to edit the selected section.

## Insert new content

In the side-panel, you can drag and drop elements from the **Content** section to the message. You can also click **+** over or under a row to insert a new row.

## Move, copy and delete content

You can select a section and use the buttons to move (<i class="ph ph-arrows-out-cardinal" aria-label="Arrows out (move)"></i>), duplicate (<i class="ph ph-copy" aria-label="Copy"></i>) and delete (<i class="ph ph-trash" aria-label="Delete icon"></i>) it.

## Edit format and layout

The appearance and properties of the message (such as font type and size, colors and margins) can be defined at global level (the whole message) or by section (as described above).

To edit the message at a global level, select **Body** in the side-panel.

As you build your email, it is easy to overlook details such as a forgotten preheader or an empty link. The **Audit** tab highlights these issues, allowing you to review and resolve them directly.

For example, if you see a warning for missing preheader text, go to the **Body** tab and find the **Email Settings** section to add this detail. The preheader text appears right after the subject line in the recipient's inbox, making it a small but impactful part of your email's first impression.

![Marketing - Audit tab to check settings for email mailing -screenshot][img12]

## Side-panel

The side-panel contains the following main sections:

| Icon | Name | Function |
|:-:|---|---|
| ![icon][img21] | Content | This section contains various content types, such as columns, text sections, images, menus/buttons and SoMe links. Drag and drop content from this section to the message. [Click the content to edit][5] it in the side panel. |
| ![icon][img22] | Blocks | This section contains saved content blocks such as headers and footers. Drag and drop content from this section to the message.<br />To save a content block, click a row and select **Save block** <i class="ph ph-floppy-disk-back" aria-label="Save block"></i>. |
| ![icon][img23] | Body | In this section you can edit the global properties and layout for the message.<br />If you have defined specific properties for individual sections, these are not overridden by global properties. |
| ![icon][img24] | Images | In this section you can find millions of [images to use in your mailing][6]. Drag and drop content from this section to the message. |
| ![icon][img25] | Audit | In this section you can check for issues in your design and content. |

> [!NOTE]
> If the **Images** section is not visible, this preference may have been disabled due to organizational privacy rules.

See also [Add content][1].

## Global menu

From the global menu, you can preview, undo or repeat actions, and se how the message looks on desktop or mobile. This menu is always displayed at the lower left in the content area.

| Icon | Name | Function |
|:-:|---|---|
| <i class="ph ph-arrow-counter-clockwise" aria-label="Undo"></i><i class="ph ph-arrow-clockwise" aria-label="Redo"></i> | Undo/Redo | Undoes the last action or redoes an undone action. |
| <i class="ph ph-eye" aria-label="Preview"></i> | Preview | Opens a preview of the message on a desktop or mobile display. |
| <i class="ph ph-monitor" aria-label="Desktop"></i>, <i class="ph ph-device-mobile" aria-label="Mobile icon"></i> | Toggle showing for desktop or mobile devices | Used to see what the appearance is like on a desktop or smart phone. |

## Context menu

When you click a section in a message, you get access to various functions for the section.

| Icon | Name | Function |
|:-:|---|---|
| <i class="ph ph-plus" aria-label="Add"></i> | Add row | Adds a row below or above the selected section. |
| <i class="ph ph-arrows-out-cardinal" aria-label="Arrows out (move)"></i> | Move | Click and drag to move the section. |
| <i class="ph ph-trash" aria-label="Delete icon"></i> | Delete | Deletes the section. |
| <i class="ph ph-copy" aria-label="Copy"></i> | Duplicate | Creates a copy of the section. |
| <i class="ph ph-floppy-disk-back" aria-label="Save block"></i> | Save block | Saves the selected section as a block. Lets you reuse content (like headers and footers) across messages. |

## <a id="variables"></a>Placeholders

To give the message a more personal touch, you can use placeholders to insert customer-specific information such as the customer's first name. In this way, you can customize the content for each individual customer.

These placeholders are called **template variables** in the old editor and **merge tags** in the Drag and drop editor.

Types:

* Merge tags linked to contacts. For example, **\[\[customer.name\]\]** inserts the contact's full name.
* Merge tags linked to companies. For example, **\[\[company.name\]\]** inserts the name of the company the contact belongs to.

### Example

Instead of this text:

"Dear Customer. Would you like to know more about how our product can help your company win new customers? Please call us at SuperShop."

You can send this one:

"Dear Chris. Would you like to know more about how our product can help Car Care Ltd win new customers? Please call Ryan Webster at SuperShop."

The text you enter will look like this:

"Dear **\[\[customer.firstname\]\]**. Would you like to know more about how our product can help **\[\[company.name\]\]** win new customers? Please call **\[\[company.ourSalesContact.name\]\]** at SuperShop."

## Two different editors

Are you using the new Drag & drop editor or the previous version of the editor?

In early 2021 SuperOffice added a new message editor (the "Drag & drop editor") to replace the old one (the "Editor"). The message editor is used when creating email mailings and form responses. The old message editor will still be available to edit messages and templates created in the old version. All new mailings and templates use the new message editor.

### <a id="old"></a>Editor (old)

![Editor (old) -screenshot][img13]

The user guide for the old editor is located in the [SuperOffice version 10.1 help][2].

## Related content

* [Add content][1]
* [Edit content][5]
* [Include links you want to track][8]
* [Use merge tags in messages][7]
* [Insert images in the message][6]

<!-- Referenced links -->
[3]: ../../learn/best-practices.md#mobile
[9]: ../../learn/message-templates.md
[1]: add-content.md
[5]: edit-paragraph.md
[6]: insert-images-in-message.md
[7]: add-merge-tag.md
[8]: add-tracked-link-to-msg.md
[2]: https://help.superoffice.com/Documentation/Help/EN/CRM/UserHelp/index.htm#t=Mailing%2FHelptopics%2Foldeditor%2FStep_3__Content_-_Formatted_e-mail.htm

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/edit-template.png

[img21]: ../../../../media/icons/marketing-and-forms/side-panel-content.png
[img22]: ../../../../media/icons/marketing-and-forms/side-panel-blocks.png
[img23]: ../../../../media/icons/marketing-and-forms/side-panel-body.png
[img24]: ../../../../media/icons/marketing-and-forms/side-panel-images.png
[img25]: ../../../../media/icons/marketing-and-forms/side-panel-audit.png

[img12]: ../../../../media/loc/en/marketing/content-audit-missing-preheader.png
[img13]: ../../../../media/loc/en/marketing/template-edit-overview-old.png
