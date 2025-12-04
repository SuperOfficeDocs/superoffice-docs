---
uid: install-crm-server
title: Install SuperOffice Win Server
description: Install SuperOffice Win Server
keywords: install, server
author: SuperOffice Product and Engineering
date: 12.01.2025
version: 11
content_type: howto
deployment: onsite
---

# Install CRM Server 11 and newer

## Prerequisites

The server where you install SuperOffice CRM Server needs to have an internet connection and access to our License server on [https://license.superoffice.com][4].

## Install

From SuperOffice 11, the SuperOffice server and database are installed with [CrmSetup][2] utility.

Run **CrmSetup.exe** with the `new-installation` option and supply the corresponding argument file, see an example below. This will prime the database with all necessary data and the license.

```dos
D:\SO Onsite 11.6\CrmSetup>CrmSetup.exe --arg-file CRMSetupNew.txt
2025-11-07 15:02:45 [Info] Downloading license from server https://license.superoffice.com/LicenseSvc/LicenseService.svc
2025-11-07 15:02:46 [Info] Creating database with options (Online = False, Language = NO, MailClient = Outlook2007)
2025-11-07 15:02:58 [Warn] Not running as administrator - skipping creating ODBC DSN.
2025-11-07 15:02:58 [Info] Initializing database
2025-11-07 15:02:58 [Info] Creating owner contact Super ASA
2025-11-07 15:02:58 [Info] Creating company Super ASA with serial number 161xxxxxxx
2025-11-07 15:02:58 [Info] Saving license for Software License: Super ASA, 161xxxxxxx Expires: 10/27/2026 00:00:00
2025-11-07 15:02:58 [Info] Creating system user crm8
2025-11-07 15:02:58 [Info] Creating user AU (Admin User)
2025-11-07 15:02:58 [Info] Accepting license
2025-11-07 15:02:59 [Info] Copying embedded document template resources
2025-11-07 15:03:09 [Info] Starting NetServer
2025-11-07 15:03:10 [Info] Perform tasks after upgrade
Installation completed successfully
```

Example argument file for new installation:

```dos
# crmsetup --arg-file CRMSetupNew.txt
# replace the values
new-installation
--database-server SQL-server
--database-name SOnew11.6 
--db-user crm7 
--db-password xxx 
--table-prefix crm7 
--odbc-dsn SO116
--so-arc C:\soserver\SO_ARC
--email-client Outlook2007
--company-name Super ASA
--serial-number 161xxxxxxx
--license-url https://license.superoffice.com/LicenseSvc/LicenseService.svc 
#--license-from-file c:\temp\license.xml 
--first-name Admin 
--last-name User 
--user-id au 
--user-name SOadmin@socrm.mailinator.com
--password au 
--user-plan ten-salesservicemarketing 
--system-user crm8 
--system-password xxx 
--language NO
--country NO  
```

***

[Previous][11] | [Next (Web)][12] | [Next (Win)][14] | [Back to guide][13]

<!-- Referenced links -->
[2]: ../../install/database/crmsetup-and-crmtask.md
[4]: https://license.superoffice.com
[11]: ../service/prepare.md
[12]: ../service/index.md
[13]: ../guide.md
[14]: ../win-client/index.md
