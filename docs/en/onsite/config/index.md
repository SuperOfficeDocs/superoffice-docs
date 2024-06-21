---
title: Config and INI files
uid: config_and_ini
description: "Introduction to the SuperOffice config and INI files."
author: Bergfrid Dias
date: 12.10.2021
keywords: NetServer config, INI, web.config, superoffice.config, superoffice.ini
topic: concept
envir: onsite
---

# Config and INI files

The SuperOffice Web client (as well as remote web services and Service) uses **web.config** to specify database connection details.

SuperOffice Windows client uses **SuperOffice.config**, in addition to **SuperOffice.ini**.

> [!NOTE]
> The *web.config* file is an XML file that can be changed as needed, but we recommend [running the SuperOffice Web Configurator][5]. Administrators can use configuration files to set policies that affect how applications run on their computers.

## SuperOffice Web

* [Enable debug log (Web)][5]
* [Web.config][6]
* [Web Tools Diagnostics][7]

## Service

* [Web.config][6]
* [Service log files][10]
* [Service config][11]
* [Debug service tasks failing or not running][12]

## SuperOffice Win

* [Enable debug log (Win)][1]
* [SOUser.ini][2] Used by SOCRM.exe, SOAdmin.exe, and ReporterStudio.exe
* [SuperOffice.config][3] Used by SOCRM.exe, SOAdmin.exe and ReporterStudio.exe
* [Command line][4] switches for SOCRM.exe, SOAdmin.exe

### .ini versus .config (Windows)

**SuperOffice.config** is a NetServer config file in the same place as *SuperOffice.ini* (also found in the same way, if you come in via COM).

The database user and password are stored in *SuperOffice.config* - encrypted and set by the MSI installer.

**ODBC data source** and **archive path** are taken from *SuperOffice.ini* automatically. The *SuperOffice.config* file doesn't need to specify the database server/type unless the ODBC source is non-standard.

The SERVER and DATABASE are dictated by the ODBC source in the *SuperOffice.ini* file. We look up in the Registry and transfer database and server settings to NetServer (not *SuperOffice.config*, but directly to NetServer without writing to the .config file).

The database user and password go the other way, from SuperOffice.config to both NetServer and the C++ code.

### How to find SuperOffice.ini

1. To find the configuration file for SuperOffice (*SuperOffice.ini*), right-click the SuperOffice icon on the desktop or in the start-menu, and choose **Properties**.

2. In the window that opens up click **Open File Location**. A file explorer window will open and you will see the SuperOffice program files.

3. Find the file *SuperOffice.ini*, and open this file.

## Security considerations

1. **ServerSetup** encrypts and saves the database credentials in an MST file.
2. Client setup extracts the credentials and stores them in the local .config file
3. NetServer decrypts these credentials on behalf of the Windows client.
4. ServerSetup also creates a system user with the same credentials, giving that username a dual role.

The same credentials are used to access NetServer Web Services.

The following steps are recommended to increase security:

* Deactivate the default system user in the SoAdmin client.
* Create a new pair of database and system users specifically for Sales and Marketing Web and Service.

<!-- Referenced links -->
[1]: ../debug/win-client.md
[2]: ../install/win-client/souser-ini.md
[3]: ../install/win-client/superoffice-config.md
[4]: ../command-line-switches.md
[5]: ../debug/web-client.md
[6]: ../../api/config/index.md
[7]: ../../webtools/debug.md
[10]: ../../service/log-files.md
[11]: ../../service/config/index.md
[12]: ../../service/automated-tasks/index.md

<!-- Referenced images -->
