---
title: How to add a new tab
uid: pb_add_tab_contact_card
description: How to add a new tab to the contact card
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: howto
so.client: web
so.envir: onsite
---

# How to add a new tab to the contact card

We are going to add a new tab to the **Contact** page. We can add a new tab for any card on the contact page.

The contact panel consists of 3 cards:

* ContactMainCard
* ContactMiniCard
* ContactArchives

## ContactMainCard

For ContactMainCard we can add a new tab called **MyView**. Normally, the contact panel main card has 4 tabs. In *SoContactPanel* those tabs are represented by 4 views. To add another tab, we have to add another view to the main card.

We can create a new view as shown in the *SoContactPanel.config*.

[!code-xml[XML](includes/socontactpanel-main.xml)]

* View id is set to "test" for the new view.
* The type is set as "SoView" because it is a view.

SO Protocol is an important attribute in a view. For one page there can be a lot of views, but the SO Protocol of each view should be unique. By calling the SO Protocol of a particular view, we can directly open the page by activating the tab (view) which we need to activate.

`http://localhost/SuperOfficeWeb/default.aspx?contact.udef2`

This link opens the contact page displaying the view we just created.

In the above link, "contact" is the SO Protocol value set in the panel and udef2 is the SO Protocol value set in the view.

If we use duplicate SO Protocol values for views in the same config file, the pagebuilder will give us a conflict error message.

In the above view, control ContactHeader is added to the controlgroup. ContactHeader is another UserControl, which is basically used to show the company name. In the above code we have to set the datasource as "ContactEntityDataHandler.ContactEntity". ContactEntityDataHandler.ContactEntity contains a lot of data but once we sent all the data to that ContactHeader user control it takes the ContactEntityDataHandler.ContactEntity.Name. This is done in the coding part of ContactHeader.ascx.cs

## ContactArchive

In CRM.web we now see another tab is added to the ContactArchive card called "My View". In that view, SoLabel and SoTextBox are used to bind the data. The SO Protocol value is set to "udef1". There are two controls called "SoLabel" and "SoTextBox" bounded to the controlgroup. The "SoLabel" caption is set by the "SR\_COMPANY\_NAME". To fetch the real value for this label the pagebuilder will use the resource manager.

<!-- TODO link to the strings internationalization doc -->

"SoTextBox" is bounded to the ContactEntityDataHandler.ContactEntity.Name. It shows the current company name fetched from the database.

[!code-xml[XML](includes/socontactpanel-archive.xml)]

This is the output of the contact page after adding two views (tabs) for maincard and archivecard.

![01][img1]

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: media/image001.jpg
