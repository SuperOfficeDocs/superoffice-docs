---
uid: help-en-phone-preferences
title: Phone preferences
description: Phone preferences
author: SuperOffice RnD
so.date: 06.29.2022
keywords: diary, follow-up, phone, call, dial
so.topic: howto
language: en
---

# Phone preferences

You can dial out from SuperOffice CRM in one of the following ways:

* Click a telephone number in the Company screen
* Click ![icon][img1] in a dialog.
* Right-click a person in a section tab and selecting **Call *name***.
* [Dial contacts][1].

Phone preferences are handled differently in the Windows and Web clients. Learn about phone preferences for Windows and Web below.

## Technical requirements

To use the telephone functions in SuperOffice you may need to install TAPI software.

### Suggested suppliers

* Standard Windows dialing software
* Panasonic TSP
* PBX Dial

## Preferences

If IP phone, Skype or FaceTime is installed, you can make phone calls from SuperOffice CRM. The **Phone-link format** preference must be set correctly, either in **Preferences** > **Default values** or in Settings and maintenance. In Settings and maintenance the phone preferences can be set for individual users, user groups or system-wide.

### Available parameters

**IP phone**: tel:%p (default value)
**Skype**: callto:%p
**FaceTime**: facetime:%p

[Template variables][2] can also be used in the phone parameters.

<!-- Referenced links -->
[1]: dial.md
[2]: ../../../document/learn/template-variables.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/phone.png
