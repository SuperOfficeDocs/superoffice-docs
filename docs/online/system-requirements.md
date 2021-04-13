---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: online_system_requirements # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: System requirements for SuperOffice CRM Online # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: reference             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud                 # cloud or onsite
so.client: online            # online, web, win, pocket, or mobile
---

# System requirements for SuperOffice CRM Online

CRM Online is the same as our web client, but since our strategy is to deliver news on our Online platform first, the system requirements may change for this platform first.

## Operating systems

* Windows 10
* Windows 8.1
* Mac OS 10.15 (Catalina)
* Mac OS 10.14 (Mojave)
* Mac OS 10.13 (High Sierra)

## Browsers

* Microsoft Edge
* Internet Explorer 11
* Chrome Mac / Win
* Firefox Mac / Win
* Safari Mac

## Document handling and storage

* Microsoft Office 2019
* Microsoft Office 2016
* Microsoft Office 2013
* Microsoft Office 2010
* Support for Google and Office365 authentication and document storage

### Documents in CRM online

* File size: Max 94,4 MB
* Timeout on file upload: 5 min

This means that you need about 2,5 - 3 Mbit/sec upload speed to be able to add/edit a 94 MB file to CRM online.

### Attachments in Mailings and Request

* Max size per mailing or request: 25 MB

This is both incoming and outgoing. For example, one request (ticket) cannot have 3 attachments where each attachment is 10 MB.

## SuperOffice MailLink (Windows only)

* Outlook 365 Click-to-run
* Outlook 2019
* Outlook 2016
* Outlook 2013
* Outlook 2010

> [!NOTE]
> Lotus Notes is NOT supported as a mail client for SuperOffice MailLink in CRM Online.

## SuperOffice for Outlook

* Microsoft Outlook 365 subscription

[View in app store][2]

> [!NOTE]
> Windows only:<br>Mobile phone users must have the latest version of iOS (13) or Android (10), and use the Outlook App (The Chrome Mobile Version of OWA does not support Outlook Add-ins).<br>Outlook desktop app users must have version 2001 and newer of Outlook, to be able to use Send and Archive (due to missing APIs in older versions).

## Mobile applications

* [Pocket CMR][3]
* [SuperOffice Mobile][4]

## WebTools

> [!CAUTION]
> Since 18th September, 2019 we have closed down access for old versions of WebTools for Windows for all Online users. The minimal required version is now 11.5. Please make sure you are running the [latest WebTools][1].

* [System requirements][5]

<!-- Referenced links-->
[1]: https://www3.superoffice.com/DownloadService/
[2]: https://online.superoffice.com/appstore/superoffice-as/superoffice-for-outlook
[3]: ../mobile/pocket-crm/system-requirements.md
[4]: ../mobile/superoffice-mobile/client-requirements.md
[5]: ../webtools/system-requirements.md
