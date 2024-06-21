---
title: Navigation points (where)
uid: so_protocol_nav
description: SoProtocol navigation points
author:
date:
keywords: soprotocol, deeplinking
topic: reference
---

# SoProtocol entity targets

Entity-specific navigation points are used to navigate to a specific entity in the SuperOffice CRM client. The following table lists the entity-specific navigation points.

| Entity | target name | Upper Tab Views | Lower Tab Views |
|--------|------------|-----------------|-----------------|
| Chat | chat | main | - |
| Company | contact | main, udef, interest, info | personarchive, relationarchive, projectarchive, activityarchive, salearchive, ticketarchive |
| Contact | person | main, details, udef, interest, info | projectarchive, relationarchive, activityarchive, salearchive, ticketarchive |
| Diary | diary | day, week, month, view | activityarchive, diarysalearchive |
| Inbox | newinbox | main | - |
| Marketing | emarketing | mailings, mmlisttemplates, mmlistlinks, mmlistimages, mmlistbounces, mmlistforms, mmlistformtemplates, mmlistformsubmissions | - |
| Project | project | main, udef, info, image, links | guide, projectmembersarchive, activityarchive, salearchive, ticketarchive |
| Reports | report | reporterfavorites, reportercontact, reporterproject, reportersale, reporteractivity | reportarchive |
| Requests | ticket | main, findticket | - |
| Sale | sale | main, details, udef, links, info | guide, quote, saleactivityarchive, stakeholderarchive, ticketarchive |
| Selection | selectionsearch | main, findpane, detailspane, newchartspane, selmailingspane, webpanelpane | - |
| Appointment Dialog | appointment | main, details, status, links, udef | - |
| Document Dialog | document | main, links, more | - |
| Invitations Dialog | invitations | archive, main | - |

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
