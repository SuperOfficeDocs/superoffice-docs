---
uid: help-en-editor
title: Drag and drop editor
description: Drag and drop editor
author: SuperOffice RnD
so.date: 02.20.2023
keywords: marketing, editor, template variable, merge tag
so.topic: concept
language: en
---

# Drag and drop editor

![Drag and drop editor -screenshot][img1]

In the **Content** step you can edit the appearance and content of the message.

* You can [insert text and images][1] (and other content) in the columns and rows of the message.

* You can define format/layout (such as font type and size, colors and margins) at global level (the whole message) or by individual sections.

* You can easily drag and drop content from the side-panel (menus, buttons, SoMe links, html content, and header and footer blocks).

SuperOffice Marketing is supplied with many [ready-made message templates][9]), and you can easily move content around to get the appearance you want. Save frequently used content as blocks to save time.

> [!TIP]
> We normally recommend a maximum width of 600 pixels for mailings. You can also check what the mailing will look like, on smart phones for example, by clicking **Mobile** (![icon][img4]) in the menu in the lower left corner. See also [Customize the message for display on mobile devices][3].

## Edit columns and blocks/sections

When you click a section (such as column, content box, row), buttons with editing options appears. The side-panel displays editing options for the selected section.

A blue frame is shown around the selected element, so that you always know which part of the message you are editing.

If you click text content, a text editing toolbar is displayed.

The global menu is always displayed at the lower left of the content area.

## Edit text and images

[Edit text][5], [insert images][6] and add other content by clicking a section in the message. Use the text editing toolbar and the side-panel to edit the selected section.

## Insert new content

In the side-panel, you can drag and drop elements from the **Content** section to the message. You can also click **+** over or under a row to insert a new row.

## Move, copy and delete content

You can select a section and use the buttons to move ( ![icon][img6] ), duplicate ( ![icon][img8] ) and delete ( ![icon][img7] ) it.

## Edit format and layout

The appearance and properties of the message (such as font type and size, colors and margins) can be defined at global level (the whole message) or by section (as described above).

To edit the message at a global level, select **Body** (![icon][img12])in the side-panel.

> [!TIP]
> Use standard fonts for the best legibility with any email client or web browser.

## Menu overview

Below is an overview of the various functions in the **Content** step.

### Side-panel

The side-panel contains the following main sections:

[!include[Mailing - sections in the side panel](includes/mailing-side-panel.md)]

See also [Add content][1].

### Global menu

From the global menu, you can preview, undo or repeat actions, and se how the message looks on desktop or mobile. This menu is always displayed at the lower left in the content area.

| Icon | Name | Function |
|:-:|---|---|
| ![icon][img11] | Undo/Redo | Undoes the last action or redoes an undone action. |
| ![icon][img2] | Preview | Opens a preview of the message on a desktop or mobile display. |
| ![icon][img3], ![icon][img4] | Toggle showing for desktop or mobile devices | Used to see what the appearance is like on a desktop or smart phone. |

### Context menu

When you click a section in a message, you get access to various functions for the section.

| Icon | Name | Function |
|:-:|---|---|
| ![icon][img5] | Add row | Adds a row below or above the selected section. |
| ![icon][img6] | Move | Click and drag to move the section. |
| ![icon][img7] | Delete | Deletes the section. |
| ![icon][img8] | Duplicate | Creates a copy of the section. |
| ![icon][img9] | Save block | Saves the selected section as a block. Lets you reuse content (like headers and footers) across messages. |

## <a id="variables" />Template variables

To give the message a more personal touch, you can use placeholders to insert customer-specific information such as the customer's first name. In this way, you can customize the content for each individual customer.

These placeholders are called **template variables** in the old editor and **merge tags** in the Drag and drop editor.

[!include[Note](includes/note-imported-recipients.md)]

There are several types of merge tags:

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

### Editor (old)

![Editor (old) -screenshot][img13]

## What would you like to do now?

* [Add content][1]
* [Edit content][5]
* [Include links you want to track][8]
* [Use merge tags in messages][7]
* [Insert images in the message][6]
* [Read about the old editor][2]

<!-- Referenced links -->
[1]: add-content.md
[3]: customize-for-mobile.md
[5]: edit-paragraph.md
[6]: insert-images-in-message.md
[7]: add-merge-tag.md
[8]: ../tracked-links/learn/add-tracked-link-to-msg.md
[9]: work-with-messages-and-templates.md
[2]: https://help.superoffice.com/Documentation/Help/EN/CRM/UserHelp/index.htm#t=Mailing%2FHelptopics%2Foldeditor%2FStep_3__Content_-_Formatted_e-mail.htm

<!-- Referenced images -->
[img1]: media/edit-template.png
[img2]: ../../../media/icons/marketing-and-forms/preview.png
[img3]: ../../../media/icons/marketing-and-forms/desktop.png
[img4]: ../../../media/icons/marketing-and-forms/mobile-2.png
[img5]: ../../../media/icons/marketing-and-forms/add-row.png
[img6]: ../../../media/icons/marketing-and-forms/move-2.png
[img7]: ../../../media/icons/marketing-and-forms/cancel.png
[img8]: ../../../media/icons/marketing-and-forms/copy.jpg
[img9]: ../../../media/icons/marketing-and-forms/save-block.png
[img11]: ../../../media/icons/marketing-and-forms/undo-redo.png
[img12]: ../../../media/icons/marketing-and-forms/side-panel-body-small.png
[img13]: media/template-edit-overview-old.png
