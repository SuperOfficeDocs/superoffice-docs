---
uid: enum-prefdescaccessflags
title: Enum values for PrefDescAccessFlags
description: Lists the enum values for PrefDescAccessFlags.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# PrefDescAccessFlags Enum

1=wizard mode, 2=level 0, 4=admin gui, 8=crm gui

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|Unknown - used when initializing|
|WizardMode|1|Wizard mode is password-protected and only accessible to SuperOffice personnel.|
|Level0|2|Preference settable only by CRM5 superuser|
|adminGUI|4|Show preference in SOADMIN GUI|
|CRMGUI|8|Show preference in CRM5 GUI|

## Usage

* [PrefDesc](../prefdesc.md).accessFlags - Preference description, drives the Preference GUI. Maintenance client - controls all preferences in SuperOffice. You find an overview off all standard preference on http://techdoc.superoffice.com.  May be used by third-party developers to add system preferences to be updated from SuperOffice Maintenance client, instead of ini-files. 
