---
uid: upgrade-to-11
title: Upgrade to 11
description: Upgrade to 11
keywords: upgrade
author: pavlas
date: 12.01.2025
version: 11
content_type: howto
deployment: onsite
---

# Upgrade to SuperOffice 11

# TO BE FINISHED

You can upgrade to SuperOffice 11 from SuperOffice 8.0 or newer. The recommended installation scenarios and setup requirements are the same as from SuperOffice 8.1.

[!include[ALT](../../includes/warn-win-client-discontinued.md)]

> [!NOTE]
> Microsoft .NET 4.8 is required for SuperOffice 9 or newer.
>
> The installer will handle the installation of .NET 4.8 for you, but some clients may like to pre-install it themselves.

## Upgrade from SuperOffice 8.0

If you are running SuperOffice 8.0 you need to make sure the full stack of SuperOffice applications (SuperOffice Server, SuperOffice Web, and SuperOffice Service) is installed. You also need to [move all products under one domain][1], as seen from the browser. It might be beneficial to [upgrade to SuperOffice 8.1][1] first and follow the corresponding guides for different installation scenarios.

## Upgrade from SuperOffice 8.1 or newer

SuperOffice 8.1 or newer installation has already the full stack of SuperOffice applications installed and it is running under one domain which makes it easier to upgrade.

### 1. Upgrade SuperOffice Server
```
D:\SO Onsite 11.6\CrmSetup>CrmSetup.exe upgrade-existing --arg-file CRMSetupUpgrade.txt
2025-11-18 12:40:44 [Info] Found a SuperOfficeCdd database
2025-11-18 12:40:44 [Info] Validating license for KalleOnsite with serial number 1010000006
2025-11-18 12:40:45 [Info] No pending upgrades
2025-11-18 12:40:45 [Info] Copying embedded document template resources
2025-11-18 12:40:45 [Info] Starting NetServer
2025-11-18 12:40:48 [Info] Perform tasks after upgrade
Upgrade completed successfully
```
```
# crmsetup --arg-file CRMSetupUpgrade.txt
# replace the values
upgrade-existing
--database-server SQL-server
--database-name SO10
--db-user crm7
--db-password xxx
--table-prefix crm7
--so-arc D:\server\so_arc
--email-client Outlook2007
--company-name SO_for_upgrade
--serial-number 151xxxxxxx
--license-url https://license.superoffice.com/LicenseSvc/LicenseService.svc
--system-user sysuser
--system-password xxx
--language NO
--country NO
```

### 2. Upgrade SuperOffice Web

SuperOffice Web is upgraded by running *Setup.exe* from the *SnMWeb* installation file. The setup can upgrade both NetServer and SuperOffice Web files.

[!include[Remote NetServer](../../includes/remote-netserver-web.md)]

### 3. Upgrade SuperOffice Service

SuperOffice Service is upgraded by running the *SuperOffice.CustomerService.exe* file from the *CS* installation folder. After the Service program files are upgraded, you need to run *upgrade.exe* to upgrade Service's database values.



### 4. Uninstall SuperOffice 8 Win clients

The SuperOffice Win app has been discontinued since SuperOffice 9. If you used the SuperOffice 8 Win app, it needs to be uninstalled from all clients.

<!-- Referenced links -->
[1]: ../to-81/index.md
