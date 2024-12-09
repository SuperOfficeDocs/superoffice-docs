---
title: Open Company
uid: sop-open-company
description: How to create a Company using the soprotocol
keywords: soprotocol, company, open
author: Eivind Fasting
date: 11.26.2024
topic: howto
---

# Open company

The soprotocol should be on the format: ```soprotocol:contact.main?contact_id={{id}}```

## Open company with ID = 2

On the Company page, showing the main tab above and the contacts grid below, with the company details on the right, where the `contact_id` equals 2, use the following SoProtocol URL:

```soprotocol:contact.main.personarchive.minicontact?contact_id=2```

![08 -screenshot][img1]

## How to edit a specific contact (obsolete from 10.0)

You can switch to the edit mode and edit a specific contact with SoProtocol like this: `contact.main[mode=edit]`

The example below shows how we can retrieve the Contact with contact\_id = 10 and edit the Contacts details. The other mode available is the "mode=view" which is the view mode for the page and restricts any modifications.

Another parameter associated with the mode is the new parameter, i.e. \[mode=edit&new=true\]. This opens a new record such a new Contact page which allows us to create a new Contact.

```https://www.example.com/Default.aspx?contact.main[mode=edit]?contact_id=10```

![06][img2]

## How to show a list of persons from a contact

In SuperOffice, a place where a list of persons is shown using the PersonArchive is the Company page’s Contact tab in the Archive Card. For us to retrieve this information using the SoProtocol, we should use a URL similar to the one shown below.

```http://localhost/SuperOfficeWeb/Default.aspx?contact.main.minimonth.personarchive?contact_id=2&person_id=10```

* **`http://localhost/SuperOfficeWeb/Default.aspx`** - This is the default URL for all SuperOffice pages.

* **contact.main.minimoth.personarchive** – This indicates that the page consists of 4 panels. Since the Contact Card consists of four views we have identified the main view to be shown. `udef`, `interest`, and `www` can be used to replace main since these are the other views available on the Contact page. Similarly, minimonth indicates the card to the right of the Contact card and there also we can call the page using the different views available under this card. "personarchive" refers to the card below the Contact card and the minimonth card. Here also we could replace the personarchive with the names of the other views available under this card.

* **contact\_id=2&person\_id=10** – `contact_id=10` indicates which Contact’s details should be shown on the page. person\_id that the person whose person\_id is 10 of the Contact whose Id is 10 will be highlighted.

Following is a screenshot of the web page that will be shown when the above URL is passed on the address bar.

![12][img3]

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../media/contact-contact_id.png
[img2]: ../media/contact-edit-mode.png
[img3]: ../media/contact.png
