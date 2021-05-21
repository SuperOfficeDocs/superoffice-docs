---
title: Navigation points (where)
uid: so_protocol_nav
description: SoProtocol navigation points
author:
so.date:
keywords:
so.topic: reference
---

# Navigation points (where)

Entity-specific sub-modes are listed for the screen or dialog they apply to. Generic sub-modes are listed in the table.

* Company (contact)
  * Interest
  * PersonArchive
  * RelationArchive
  * ProjectArchive
  * ActivityArchive
* Contact (person)
  * Interest
* Diary
  * Day
  * Week
  * Month
  * ReferenceView
* Sale
* Project
  * MemberArchive
  * ActivityArchive
* Selection
  * Task
* Inbox (mail)
* Appointment (dialog)
* Document (dialog)
* Invitations (dialog)

| Sub-mode | Contact | Project | Person | Selection |
|:---------|:-------:|:-------:|:------:|:---------:|
| Main     | x       | x       | x      | x         |
| Udef     | x       | x       | x      |           |
| WWW      | x       | x       |        |           |
| Info     | x       | x       | x      |           |

## Examples

* To go to the contact screen, `superoffice:contact`

* To go to the *day* view of the diary: `superoffice:diary.day`

<!-- Referenced links -->
