---
uid: help-en-contact-dial
title: Dialling contacts
description: Dialling contacts; Phone preferences
author: SuperOffice RnD
so.date: 09.22.2023
keywords: diary, follow-up, phone, call, dial
so.topic: howto
language: en
---

# Dial contacts

If your IP phone solution is correctly configured, you can call a contact directly from SuperOffice CRM in one of the following ways:

* Click a telephone number in the Company screen
* Click ![icon][img1] in a dialog.
* Right-click a person in a section tab and selecting **Call *name***.
* Dial contacts.

## Dial a contact from the Follow-up and Document dialogs

You do this using the telephone button in, for example, the **Follow-up** and **Document** dialogs:

1. Open a follow-up or document.
2. Select the required contact in the **Contact** field in the dialog.
3. Click the button next to the contact field ![icon][img1]. A list of numbers for the selected contact is displayed.
4. Select the number you want to call. The contact is then dialled.

## Call from section tabs (to contacts, selection members, stakeholders, participants)

1. Go to a section tab containing contacts.
2. Click a phone number in a column containing phone numbers. The contact is then dialled.

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
[2]: ../../document/learn/template-variables.md

<!-- Referenced images -->
[img1]: ../../../../common/icons/phone.png
