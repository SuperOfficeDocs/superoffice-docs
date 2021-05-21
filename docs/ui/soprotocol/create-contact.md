---
title: How to create contact
uid: sop_create_contact
description: How to create a contact
author: Tony Yates
so.date: 06.24.2016
keywords: soprotocol
so.topic: howto
so.client: web
so.envir: onsite
---

# How to create contact

Users create new contacts by clicking the **New** button in the GUI. Programs can’t click buttons for the user. Instead, they use SoProtocol to tell SuperOffice to act as if the button was clicked:

```html
contact.main[mode=edit&new=true
```

NEW mode is just editing a blank contact, so this is equivalent to

```html
contact.main[mode=edit]?contact_id=0
```

There are 2 direct ways to open a new contact by using the URLs containing SOProtocol:

`http://localhost/SuperOfficeWeb/default.aspx?contact.main[mode=edit&new=true]?contact_id=0`

or

`http://localhost/SuperOfficeWeb/default.aspx?contact.main[mode=edit&new=true]`

Users need to fill required data fields such as company name, department, street address, postal address, country, before clicking the **OK** button to save the data to the database.

![10][img2]

The following example shows how we can create a new Contact using the URL. `contact_id=0` on the end is used to clear the person archive.

`http://localhost/SuperOfficeWeb/default.aspx?main[mode=edit&new=true]?contact_id=0`

![07][img1]

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: media/image007.jpg
[img2]: media/image010.jpg
