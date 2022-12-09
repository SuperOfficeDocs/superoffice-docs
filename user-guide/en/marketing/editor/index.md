---
title: Editors
uid: help-en-marketing-editors
description: Editors
author: Bergfrid Dias
so.date: 09.07.2022
keywords: Editor, template variable, merge tag
so.topic: concept
so.version: 10
so.lang: en
so.envir:
so.client:
---

# Editors

In early 2021 SuperOffice added a new message editor (the "Drag & drop editor") to replace the old one (the "Editor"). The message editor is used when creating email mailings and form responses. The old message editor will still be available to edit messages and templates created in the old version. All new mailings and templates use the new message editor.

## Are you using the new Drag & drop editor or the previous version of the editor?

**Drag & drop editor (new):**

![Drag and drop editor (new) -screenshot][img1]
![Drag and drop editor (new) -screenshot][img2]

**Editor (old):**

![Editor (old) -screenshot][img3]

## Template variables

To give the message a more personal touch, you can use placeholders to insert customer-specific information such as the customer's first name. In this way, you can customize the content for each individual customer.

These placeholders are called **template variables** in the old editor and **merge tags** in the Drag and drop editor.

[!include[Note](../includes/note-imported-recipients.md)]

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

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/templateeditoverview.png
[img2]: media/editor-sidepanel.png
[img3]: old/media/templateeditoverview-old.png
