---
title: How to edit a specific contact
uid: sop_edit_contact
description: How to edit a contact
author: Tony Yates
date: 06.24.2016
keywords: soprotocol, deeplinking
topic: howto
client: web
envir: onsite
---

# How to edit a specific contact (obsolete from 10.0)

You can switch to the edit mode and edit a specific contact with SoProtocol like this: `contact.main[mode=edit]`

The example below shows how we can retrieve the Contact with contact\_id = 10 and edit the Contacts details. The other mode available is the "mode=view" which is the view mode for the page and restricts any modifications.jeg

Another parameter associated with the mode is the new parameter, i.e. \[mode=edit&new=true\]. This opens a new record such a new Contact page which allows us to create a new Contact.

`www.example.com/Default.aspx?contact.main[mode=edit]?contact_id=10`

![06][img1]

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/contact-edit-mode.png
