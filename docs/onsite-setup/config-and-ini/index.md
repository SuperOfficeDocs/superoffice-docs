---
title: Config and INI files
uid: config_and_ini
description: Config and INI files
author: {github-id}
keywords:
so.topic: concept
so.envir: onsite
---

# Config and ini files

## .ini versus .config

The SuperOffice web client uses **web.config** to specify database connection details. SuperOffice windows client uses **superoffice.config**, in addition to **superoffice.ini**.

**superoffice.config** is a NetServer config file in the same place as *superoffice.ini* (also found in the same way, if you come in via COM).

The database user and password are stored in *superoffice.config* - encrypted and set by the MSI installer.

**ODBC data source** and **archive path** are taken from *superoffice.ini* automatically. The *superoffice.config* file doesn't need to specify the database server/type unless the ODBC source is non-standard.

The SERVER and DATABASE are dictated by the ODBC source in the *superoffice.ini* file. We look up in the Registry and transfer database and server settings to NetServer (not *superoffice.config*, but directly to NetServer without writing to the .config file).

The database user and password go the other way, from superoffice.config to both NetServer and the C++ code.

## SuperOffice Web

[Enable debug log (Web)][5]

[Web.config][6]

[Web Tools Diagnostics][7]

## SuperOffice Win

[Enable debug log (Win)][1]

[SOUser.ini][2] Used by SOCRM.exe, SOAdmin.exe, and ReporterStudio.exe

[SuperOffice.config][3] Used by SOCRM.exe, SOAdmin.exe and ReporterStudio.exe

[Command line][4] switches for SOCRM.exe, SOAdmin.exe

## Service

[Web.config][6]

[Service log files][10]

[Service config][11]

[Debug service tasks failing or not running][12]

## Outlook Mail Link

[Enable debug for Outlook Mail Link][8]

## Notes link

[Enable debug for Notes Mail Link][8]

## Ribbons

[Enable debug for Ribbons][9]

## Security considerations

1. **ServerSetup** encrypts and saves the database credentials in an MST file.
2. Client setup extracts the credentials and stores them in the local .config file
3. NetServer decrypts these credentials on behalf of the Windows client.
4. ServerSetup also creates a system user with the same credentials, giving that username a dual role.

The same credentials are used to access NetServer Web Services.

The following steps are recommended to increase security:

* Deactivate the default system user in the SoAdmin client.
* Create a new pair of database- and system users specifically for Sales and Marketing Web and Customer Service.

<!-- Referenced links -->
[1]: ../win-client/debug.md
[2]: souser-ini.md
[3]: superoffice-config.md
[4]: ../win-client/command-line-switches.md
[5]: ../web-client/debug.md
[6]: web-config.md
[7]: ../../webtools/debug.md
[8]: ../../email/maillink/debug.md
[9]: ../../document/ribbons/enable-debug.md
[10]: ../../service/log-files.md
[11]: service-config.md
[12]: ../../service/debug-automated-tasks.md
