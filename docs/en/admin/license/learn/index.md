---
uid: help-en-licenses
title: CRM and licences
description: CRM and licences
keywords: license, licence, user plan, metered service, database owner, status tab
author: SuperOffice Product and Engineering
date: 07.10.2025
version: 10.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: en
redirect_from: /en/admin/license/learn/screen/index
---

# SuperOffice and licences

To log in to SuperOffice CRM from a web client, you need login rights to SuperOffice CRM and an Essential or a Premium user plan.

## View licence information

1. In Settings and maintenance, go to the Licences screen.
1. Select the **SuperOffice** tab.
1. The list shows the licences you have [purchased and activated][1]. Click a licence name to view more information about it.

[!include[Tip](includes/tip-user-licenses.md)]

## The Licences screen

### The SuperOffice tab

In the **SuperOffice** tab in the Licences screen, you can view and update the license information for your version of SuperOffice CRM and associated modules.

> [!NOTE]
> If a third-party add-on is installed, several tabs are displayed here.

#### Owner information

At the top is the company name (your company/organization) and serial number. If the license is time-limited, the expiry date is displayed below the serial number.

The list at the bottom shows which licenses are in use and how many are available. Click a license name to view information about a license.

#### License list

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

Read more about [SuperOffice user plans and subscriptions][6].

### Site and User licences (Windows - End of Life)

Licences for SuperOffice CRM for Windows (last release [SuperOffice G8 8.5 R17][5]) are purchased for a specific number of users.

Read more about licences in [earlier versions of SuperOffice][7].

## Related content

* [Buy and activate licences][1]
* [System events][3]

<!-- Referenced links -->
[1]: activate.md
[2]: ../../../saint/learn/index.md
[3]: ../../learn/system-events.md
[5]: https://community.superoffice.com/en/product-releases/release-notes/release-details/?release=SuperOffice_8.5_-_R17
[6]: ../../../../en/admin/license/user-plans.md
[7]: https://help.superoffice.com/Documentation/Help/EN/CRM/WebHelpAdmin/index.htm#t=chap03%2FCRM_and_licences.htm

<!-- Referenced images -->
