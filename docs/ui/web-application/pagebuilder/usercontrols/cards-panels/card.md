---
title: pb_usercontrols_card
description: UserControls - cards
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: concept
so.client: web
so.envir: onsite
---

# Cards

The card section contains one or more views. The views can be displayed one by one or all at once, this is decided by the implementation of the card. In SuperOffice, the card will display a tab control or a dropdown control telling the user which view is active and what other views are available.

You can use [SoProtocol][1] strings in the URL to force a switch to a particular view:

* Open the contact page displaying the interest tab

  `http://localhost/SuperOfficeWeb/default.aspx?contact.interest`

* Open the **Contact** page displaying the **Interest** tab in the main card and displaying the month calendar in the minicard.

  `http://localhost/SuperOfficeWeb/default.aspx?contact.interest.minimonth`

* Open the **Contact** page displaying the **Interest** tab in the main card and displaying the **Activity** tab in the archive card and displaying the month calendar from the minicard.

  `http://localhost/SuperOfficeWeb/default.aspx?contact.interest.minimonth.activityarchive`

These links show us a direct way to open a page with wanted tabs. The SoProtocol name is declared on the view using an element in the config file. Otherwise, we can log in to the contact page, and then by clicking or by selecting the wanted views, we can get the same result.

![02][img1]

<!-- Referenced links -->
[1]:../../../../soprotocol/index.md

<!-- Referenced images -->
[img1]: media/image002.jpg
