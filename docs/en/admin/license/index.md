---
uid: help-en-licenses
title: CRM and licences
description: CRM and licences
keywords: license, licence, user plan, metered service, database owner, status tab
author: digitaldiina, xt1
date: 10.22.2025
version: 11.5
content_type: concept
category: Settings and maintenance
topic: licenses
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: 
  - /en/admin/license/learn/screen/index
  - /en/admin/license/learn/index
  - /en/admin/overview
  - /en/learn/administration
language: en
---

# SuperOffice and licences

To log in to SuperOffice CRM from a web client, you need login rights to SuperOffice CRM and an Essential or a Premium user plan.

## View licence information

1. In Settings and maintenance, go to the Licences screen.
1. Select the **SuperOffice** tab.
1. The list shows the licences you have [purchased and activated][1]. Click a licence name to view more information about it.

## The Licences screen

### The SuperOffice tab

In the **SuperOffice** tab in the Licences screen, you can view and update the license information for your version of SuperOffice CRM and associated modules.

> [!NOTE]
> If a third-party add-on is installed, several tabs are displayed here.

#### Owner information

At the top is the company name (your company/organization) and serial number. If the license is time-limited, the expiry date is displayed below the serial number.

#### License list

The list at the bottom shows which licenses are in use and how many are available. Click a license name to view information about a license.

### The Status tab

Updated information about the system is displayed in the **Status** tab in the Licences screen. The **Status** screen is divided into the following main sections:

#### Database

Shows the database owner, serial number, and type, which are specified on installation. It also shows if it is a central database or a satellite database. You can see the next expiry date and the name of the user currently logged in.

#### Metered services

Click this button to open the dashboard for your metered services.

Metered services are services that are invoiced after you exceed a certain level/number of

* Storage space used
* Emails sent via Mailings
* Customer center logins
* Chat sessions started
* Form submissions

Administrators can keep track of exactly how much each service is used per month. Whenever your company exceeds the threshold, you are automatically invoiced for these services on your next monthly invoice. The threshold depends on the number of users. The more users you have, the higher the threshold will be.

#### System notifications

This list shows status messages from the system and added [events][3]. Notifications of active imports, SAINT or freetext indexing, and so on. Select a notification in the list to display a description. You can keep track of events that are active in the system.

The **System events** tab consists of two parts:

* **Events**.
* **Description**, shows detailed information about the event currently selected under **Events**.

Under **System notifications** you will find the following columns:

| Column | Description |
|---|---|
| Event | Shows the name of the event. |
| Status | Shows the status of the event. |
| Message | Shows the description of the event. |
| Activated | Shows when the event was initiated. |
| Activated by | Shows who initiated the event (user ID and portrait). |
| Finished | Shows when the event is expected to finish. |
| Type | Shows if the event applies to the whole system. |

## <a id="types"></a>License types

### System licences

| Licence | Description |
|---|---|
| System | Specifies which systems you have access to. |
| SuperOffice Server | Required to use SuperOffice CRM. |
| Online Web Services | Required to access SuperOffice CRM from a web client. |
| Sales Intelligence | Allows [SAINT status monitors][2]. |
| Exchange Synchronizer | Allows use of SuperOffice Synchronizer. |
| SuperOffice Expander Services | Allows functionality for anonymous and external users via SuperOffice Audience or third-party applications, among other things. |
| Customer Centre | Allows use of the Customer Centre. |
| Sales Quote Management | Allows use of quotes. |

### User licences (plans)

Finally, there are user licences for SuperOffice CRM, which are purchased for a specific number of users. This applies amongst others to the following products:

* Sales-Essentials
* Sales-Premium
* Service-Essentials
* Service-Premium
* Marketing-Essentials
* Marketing-Premium

### Site and User licences (Windows - End of Life)

Licences for SuperOffice CRM for Windows (last release [SuperOffice G8 8.5 R17][6]) are purchased for a specific number of users.

## <a id="dev"></a>Behind the scenes - the license system

The license system has its own set of database tables:

* [ModuleOwner][11] – an issuer of licenses
  * Initially only one row (SuperOffice).
  * Contains global expiration dates.

* [ModuleLicense][12] – one row per license
  * More than you see, some licenses are hidden from the GUI.
  * Several types: System, site, associate; on/off or a defined number of licenses.
  * Visible licenses (like user plans) show in the Admin UI. User plans have `ExtraFlags = 1`.
  * Hidden licenses (like the **user** log-in right, or the **web** web-client license) don't show in the UI but are
    checked in the code to verify that a feature is available to a given user.

| License type | ModuleLicense.Type | Description |
|---|---|---|
| **System licenses** | 1 | Define which features are available system-wide. <br />Example: The **saint** license is present if Sales Intelligence is enabled. This license is hidden (not on the price list) and implicitly activated. The SuperOffice client checks for it and enables SAINT features if present. |
| **Site licenses** | 2 | Rarely used today. Historically used in satellite setups, where certain licenses were assigned to specific sites instead of being globally available. |
| **User licenses** | 3 | Licenses assigned directly to users. The number of assigned users cannot exceed the number of available licenses. <br />Some user licenses may be hidden to simplify the UI. These are activated through user plans. <br />User plans have `ModuleLicense.ExtraFlags = 1` and define implied licenses via the `ExtraInfo` field, for example:<br>`"set=user,web,chat-cal"` assigns the **user**, **web**, and **chat-cal** licenses automatically. |

### User-license assignment

[LicenseAssocLink][13] – assigns one particular `moduleLicense` to a certain associate. That is how John becomes a User and a Windows client user; this would be 2 records.

The sum of licenses assigned to any particular module is limited to the number in `moduleLicense`. A new license set from SuperLicense will not be accepted if more than the acquired number is already assigned.

### License signing

Licenses are signed using public/private keys.

The private key is a closely guarded secret and without it, you cannot make a keycode generator.

Individual `moduleLicense` rows are also signed and all rows are also hash-checked to make tampering harder.

**Summary:** You touch them, they stop working. SoAdmin and NetServer can edit them, no one else.
Hackers can hack the DLLs, but not make a keycode generator that works with un-hacked code.

### Counting Users

There are two approaches:

#### 1: Get the license and read the number of user or web licenses

Users must have both **user** and **web** to log in to the SuperOffice web application. This number is the upper bound. It does not tell you how many are in use.

For some customers, the number of licenses is huge, because they are paying by use, using SCIM. To handle this, count the number of user licenses in use, rather than the total number of licenses available.

#### 2: Get the license and sum the number of ExtraFlags=1 licenses in use

User plans are what the user is paying for. They define multiple implied, hidden licenses.

The same SCIM caveat applies: count the number of user plans in use, rather than the total number available.

## Related content

* [SuperOffice user plans and subscriptions][4]
* [Buy and activate licences][1]
* [Licences in earlier versions of SuperOffice][7]
* [System events][3]

<!-- Referenced links -->
[1]: activate.md
[2]: ../../saint/learn/index.md
[3]: ../onsite/add-system-event.md
[4]: user-plans.md
[6]: https://community.superoffice.com/en/product-releases/release-notes/release-details/?release=SuperOffice_8.5_-_R17
[7]: https://help.superoffice.com/Documentation/Help/EN/CRM/WebHelpAdmin/index.htm#t=chap03%2FCRM_and_licences.htm
[11]: ../../database/tables/ModuleOwner.md
[12]: ../../database/tables/ModuleLicense.md
[13]: ../../database/tables/LicenseAssocLink.md

<!-- Referenced images -->
