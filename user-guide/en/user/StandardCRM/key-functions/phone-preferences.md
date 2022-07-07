---
uid: help-en-phone-preferences
title: Phone preferences
description: Phone preferences
author: SuperOffice RnD
so.date: 06.29.2022
keywords: CRM
so.topic: help
language: en
---

# Phone preferences

You can dial out from SuperOffice CRM in one of the following ways:

* Clicking a telephone number in the **Company** screen
* Clicking ![icon](../media/Dialogboksknapper-Telefon.bmp) in a dialog.
* Right-clicking a person in a section tab and selecting **Call *****name***.

See also [Dial contacts](../diary/Dialling-Contacts.md).

Phone preferences are handled differently in the Windows and Web clients. Learn about phone preferences for Windows and Web below.

<!-- Fix reuse ID=a1 -->

To use the telephone functions in SuperOffice you may need to install TAPI software.

Suggested suppliers include:

* Standard Windows dialing software
* Panasonic TSP
* PBX Dial

## Preferences

If you have installed IP phone, Skype or Facetime, you can make phone calls from SuperOffice CRM. The **Phone-link format** preference must be set correctly, either in **Preferences &gt; Default values** or in SuperOffice Settings and maintenance. In SuperOffice Settings and maintenance the phone preferences can be set for individual users, user groups or system-wide.

The available parameters are as follows:

**IP phone**: tel:%p (this is the default value)

**Skype**: callto:%p

**Facetime**: facetime:%p

[Template variables](../diary/Template-variables.md) can also be used in the phone parameters.
