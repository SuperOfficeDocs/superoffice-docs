---
title: How to show a list of persons from a contact
uid: sop_list_contact_persons
description: How to show a list of persons from a contact
author: Tony Yates
so.date: 06.24.2016
keywords: soprotocol
so.topic: howto
so.client: web
so.envir: onsite
---

# How to show a list of persons from a contact

In SuperOffice, a place where a list of persons is shown using the PersonArchive is the Company page’s Contact tab in the Archive Card. For us to retrieve this information using the SoProtocol, we should use a URL similar to the one shown below.

`http://localhost/SuperOfficeWeb/Default.aspx?contact.main.minimonth.personarchive?contact_id=2&person_id=10`

* **http://localhost/SuperOfficeWeb/Default.aspx** - This is the default URL for all SuperOffice pages.

* **contact.main.minimoth.personarchive** – This indicates that the page consists of 4 panels. Since the Contact Card consists of four views we have identified the main view to be shown. `udef`, `interest`, and `www` can be used to replace main since these are the other views available on the Contact page. Similarly, minimonth indicates the card to the right of the Contact card and there also we can call the page using the different views available under this card. "personarchive" refers to the card below the Contact card and the minimonth card. Here also we could replace the personarchive with the names of the other views available under this card.

* **contact\_id=2&person\_id=10** – `contact_id=10` indicates which Contact’s details should be shown on the page. person\_id that the person whose person\_id is 10 of the Contact whose Id is 10 will be highlighted.

Following is a screenshot of the web page that will be shown when the above URL is passed on the address bar.

![12][img1]

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: media/image001.jpg
