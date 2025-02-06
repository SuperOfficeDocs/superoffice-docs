---
uid: help-en-contact-dial
title: Dialling contacts
description: Dialling contacts; Phone preferences
author: SuperOffice RnD
date: 09.22.2023
keywords: diary, follow-up, phone, call, dial
topic: howto
language: en
---

# Dial contacts

If your IP phone solution is correctly configured, you can call a contact directly from SuperOffice CRM in one of the following ways:

* Click a telephone number in the Company screen
* Click <i class="ph ph-phone" aria-label="Phone icon"></i> in a dialog.
* Right-click a person in a section tab and selecting **Call *name***.
* Dial contacts.

## Dial a contact from the Follow-up and Document dialogs

You do this using the telephone button in, for example, the **Follow-up** and **Document** dialogs:

1. Open a follow-up or document.
2. Select the required contact in the **Contact** field in the dialog.
3. Click the call button next to the contact field. A list of numbers for the selected contact is displayed.
4. Select the number you want to call. The contact is then dialled.

## Call from section tabs (to contacts, selection members, stakeholders, attendees)

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

* **IP phone**: `tel:%p` (default value)
* **Skype**: `callto:%p`
* **FaceTime**: `facetime:%p`

[Template variables][2] can also be used in the phone parameters.

<!-- Referenced links -->
[2]: ../../document/templates/learn/template-variables.md
