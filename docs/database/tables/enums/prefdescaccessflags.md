---
uid: enum-prefdescaccessflags
title: Enum values for PrefDescAccessFlags
description: Lists the enum values for PrefDescAccessFlags.
so.generated: true
keywords:
  - "database"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# PrefDescAccessFlags Enum

1=wizard mode, 2=level 0, 4=admin gui, 8=crm gui

* Unknown = 0
* WizardMode = 1
* Level0 = 2
* adminGUI = 4
* CRMGUI = 8

## Usage

* [PrefDesc](../prefdesc.md).accessFlags - Preference description, drives the Preference GUI. Maintenance client - controls all preferences in SuperOffice. You find an overview off all standard preference on http://techdoc.superoffice.com.  May be used by third-party developers to add system preferences to be updated from SuperOffice Maintenance client, instead of ini-files. 
