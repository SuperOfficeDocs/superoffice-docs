---
uid: sop-create-contact
title: How to create contact
description: How to create a contact
keywords: soprotocol, deeplinking
author: Tony Yates
date: 06.20.2024
version: 10.3.4
topic: howto
client: web
envir: onsite
---

# How to create contact

Users create new contacts by clicking the **New** button in the GUI. Programs can’t click buttons for the user. Instead, they use SoProtocol to tell SuperOffice to act as if the button was clicked:

```html
contact.main?contact_id=0
```

NEW mode is just editing a blank contact, so this is equivalent to

```html
contact.main[mode=edit]?contact_id=0
```

> [!NOTE]
> `contact.main` is not supported in onsite versions 10.0.x-10.2.x.

There are 2 direct ways to open a new contact by using the URLs containing SOProtocol:

`http://localhost/SuperOfficeWeb/default.aspx?contact.main[mode=edit&new=true]?contact_id=0`

or

`http://localhost/SuperOfficeWeb/default.aspx?contact.main[mode=edit&new=true]`

Users need to fill required data fields such as company name, department, street address, postal address, country, before clicking the **OK** button to save the data to the database.

![Soprotocol contact.main -screenshot][img2]

The following example shows how we can create a new Contact using the URL. `contact_id=0` on the end is used to clear the person archive.

`http://localhost/SuperOfficeWeb/default.aspx?contact.main[mode=edit&new=true]?contact_id=0`

<!-- Referenced links -->

<!-- Referenced images -->
[img2]: media/contact-new.png
