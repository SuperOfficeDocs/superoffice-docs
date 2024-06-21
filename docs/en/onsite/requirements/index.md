---
title: Requirements
uid: onsite_system_requirements
description: System requirements - onsite
author: {github-id}
keywords:
topic: reference
envir: onsite
# client:
---

# System requirements - Onsite

Use this overview to get to the specific requirements.

> [!TIP]
> Also consider info in the [Security and deployment][12] sections when installing or upgrading to SuperOffice CRM 8 and newer.

## Requirements

* [CRM Server][1]
* [IIS web server][3]
* [Web client][2]
* [Win client][2]
* [Pocket CRM host][4] and [device][5]
* [SuperOffice mobile][6]

[!include[Warning legacy](../includes/warn-web-client-https.md)]

## Microsoft .NET

### Microsoft .NET 4.8 from SuperOffice 8.5 R05

The installer will handle the installation of .NET 4.8 for you, but some clients may like to pre-install it themselves.

Windows 10 May 2019 Update comes with .NET 4.8 included.

### Microsoft .NET 4.7.1 required from SuperOffice 8.3 R04

This requirement applies to:

* All client computers that will run our Windows client
* All servers running our web-based software (Sales & Marketing Web, NetServer, Service)
* The server hosting SuperOffice CRM Server (ServerSetup) to be able to run ServerSetup and *DBSetup.exe*

SuperOffice WebTools (Web Extensions and MailLink) will not have this requirement yet. They will continue to run on .Net 4.5.1. This means that our CRM Online customers are not affected by this change for now.

There are 2 main reasons for this change:

* Security patches are no longer shipped by Microsoft on .NET 4.5.x.
* New versions of our developing tools need this to enable us to be more productive.

Please note:

* .NET 4.7.1 has already been pushed with Windows Update for a while and is preinstalled from Windows 10 Fall Creators Update (version 1709) and newer.
* .NET 4.7.1 is supported by Windows 7 SP1 or newer as Client OS, except Windows 8.0. Windows 8.0 is no longer supported by Microsoft. Windows 10 is supported from Windows 10 Anniversary Update (version 1607).
* .NET 4.7.1 is supported by Windows Server 2008 R2 SP1 or newer as Server OS.

See: [.NET system requirements][13]

## Which services endpoint to use?

| Versions | Web client | Service client |
|----------|------------|----------------|
| 10 | services88 | services88 |
| 9 | services88 | services88 |
| 8.5 R09 - R15 | services88 | services88 |
| 8.5 R01 - R08 | services87 | services87 |
| 8.4 R07 - R08 | services87 | services87 |
| 8.4 R01 - R06 | services86 | services86 |
| 8.3 R02 - R04 | services86 | services86 |
| 8.3 R01       | services85 | services85 |
| 8.2           | services84 | services84 |
| 8.1           | services84 | services84 |
| 8.0 SR3 - SR6 | services82 | services82 |
| 8.0 SR1 - SR2 | services80 | services80 |

## Compatibility

* [Server OS][7]
* [Client OS][8]
* [Browser][9]
* [Microsoft Office][10]
* [Database][11]

<!-- Referenced links -->
[1]: crm-server.md
[2]: web-client.md
[3]: iis.md
[4]: ../../mobile/pocket-crm/system-requirements.md
[5]: ../../mobile/pocket-crm/client-requirements.md
[6]: ../../mobile/superoffice-mobile/client-requirements.md
[7]: ../compatibility/server-os.md
[8]: ../compatibility/client-os.md
[9]: ../compatibility/browser.md
[10]: ../compatibility/ms-office.md
[11]: ../compatibility/database.md
[12]: ../security/secure-deployment-guide.md
[13]: https://docs.microsoft.com/en-us/dotnet/framework/get-started/system-requirements
