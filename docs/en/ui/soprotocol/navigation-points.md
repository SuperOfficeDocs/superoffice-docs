---
title: Navigation points (where)
uid: so_protocol_nav
description: SoProtocol navigation points
author:
so.date:
keywords:
so.topic: reference
---

# SoProtocol entity targets

Entity-specific navigation points are used to navigate to a specific entity in the SuperOffice CRM client. The following table lists the entity-specific navigation points.

* Chat (**chat**)
  * Upper tab views:
    * main

* Company (**contact**)
  * Upper tab views:
    * main
    * udef
    * interest
    * info
  * Lower tab views:
    * personarchive
    * relationarchive
    * projectarchive
    * activityarchive
    * salearchive,
    * ticketarchive

* Contact (**person**)
  * Upper tab views:
    * main
    * details
    * udef
    * interest
    * info
  * Lower tab views:
    * projectarchive
    * relationarchive
    * activityarchive
    * salearchive,
    * ticketarchive

* Diary (**diary**)
  * Upper tab views:
    * day
    * week
    * month
    * view
  * Lower tab views:
    * activityarchive
    * diarysalearchive

* Inbox (**newinbox**)
  * Upper tab views:
    * main

* Marketing (**emarketing**)
  * Upper tab views:
    * mailings
    * mmlisttemplates
    * mmlistlinks
    * mmlistimages
    * mmlistbounces
    * mmlistforms
    * mmlistformtemplates
    * mmlistformsubmissions

* Project (**project**)
  * Upper tab views:
    * main
    * udef
    * info
    * image
    * links
  * Lower tab views:
    * guide
    * projectmembersarchive
    * activityarchive
    * salearchive
    * ticketarchive

* Reports (**report**)
  * Upper tab views:
    * reporterfavorites
    * reportercontact
    * reporterproject
    * reportersale
    * reporteractivity
  * Lower tab views:
    * reportarchive

* Requests (**ticket**)
  * Upper tab views:
    * main
    * findticket

* Sale (**sale**)
  * Upper tab views:
    * main
    * details
    * udef
    * links
    * info
  * Lower tab views:
    * guide
    * quote
    * saleactivityarchive
    * stakeholderarchive
    * ticketarchive

* Selection (**selectionsearch**)
  * Upper tab views:
    * main
    * findpane
    * detailspane
    * newchartspane
    * selmailingspane
    * webpanelpane

* Appointment Dialog (**appointment**)
  * Upper tab views:
    * main
    * details
    * status
    * links
    * udef

* Document Dialog (**document**)
  * Upper tab views:
    * main
    * links
    * more

* Invitations Dialog (**invitations**)
  * Upper tab views:
    * archive
    * main

## Minicard addresses

The following minicard addresses are available:

* minicontact
* miniperson
* miniday
* minimonth
* minifavourites
* mininextday
* mininotepad
* minipreview
* miniproject
* miniprojectmembers
* minisale
* miniselection
* miniselectionmembers
* miniweek

## Examples

* To go to the contact screen, select the main details and select the person grid
  * `contact.main.personarchive`

* To go to the contact screen, select the interests tab, and select the project grid in the lower tab view, and view the company information in the minicard view.
  * `contact.interest.projectarchive.minicontact`

* To go to the diary and view the *day* tab: `diary.day`

<!-- Referenced links -->
