---
title: Requirements
uid: online_system_requirements
description: System requirements for SuperOffice CRM Online
author: {github-id}
keywords:
so.topic: reference
so.envir: cloud
so.client: online
---

# System requirements for SuperOffice CRM Online

CRM Online is the same as our Web client, but since our strategy is to deliver news on our Online platform first, the System requirements may change for this platform first.

## Operating systems

* Windows 11
* Windows 10
* MacOS Ventura
* MacOS Monterey
* MacOS Big Sur

## Browsers

* Microsoft Edge
* Chrome Mac / Win
* Firefox Mac / Win
* Safari Mac

## Document handling and storage

* Microsoft Office 2021
* Microsoft Office 2019
* Microsoft Office 2016
* Support for Google and Microsoft 365 authentication and document storage

### Documents in CRM online

* File size: Max 94,4 MB
* Timeout on file upload: 5 min

This means that you need about 2,5 - 3 Mbit/sec upload speed to be able to add/edit a 94 MB file to CRM Online.

### Attachments in Mailings and Request

* Max size per mailing or request: 25 MB

This is both incoming and outgoing. For example, one request (ticket) cannot have 3 attachments where each attachment is 10 MB.

## SuperOffice MailLink (Intel-based Windows only)

* Outlook 365 Click-to-run
* Outlook 2021
* Outlook 2019
* Outlook 2016

> [!NOTE]
> Lotus Notes is NOT supported as a mail client for SuperOffice MailLink in CRM Online.

## SuperOffice for Outlook

* Microsoft Outlook 365 subscription

[View in app store][2]

> [!NOTE]
> Windows only:
>
> Mobile phone users must have the latest version of iOS (13) or Android (10) and use the Outlook App (the Chrome Mobile Version of OWA does not support Outlook Add-ins).
>
> Outlook desktop app users must have version 2001 and newer of Outlook, to be able to use Send and Archive (due to missing APIs in older versions).

## Built-in mail client

For the built-in mail client, the following ports must be opened between the Online web server and the mail server:

[!include[Mail client ports](../onsite/includes/mail-client-ports.md)]

## Mobile applications

* [SuperOffice Mobile][4]

## WebTools

> [!CAUTION]
> Since 18th September 2019 we have closed down access for old versions of WebTools for Windows for all Online users. The minimal required version is now 11.5. Please make sure you are running the [latest WebTools][1].

* [System requirements][5]

<!-- Referenced links-->
[1]: https://www3.superoffice.com/DownloadService/
[2]: https://online.superoffice.com/appstore/superoffice-as/superoffice-for-outlook
[4]: ../mobile/superoffice-mobile/client-requirements.md
[5]: ../webtools/system-requirements.md
