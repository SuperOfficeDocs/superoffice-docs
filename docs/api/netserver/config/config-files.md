---
title: netserver-authentication-configuration
description: NetServer authentication configuration files
author: {github-id}             # Your GitHub alias.
so.date: 05.08.2018
keywords: web.config
so.topic: concept
---

# Configuration files

## .ini versus .config

The SuperOffice web client uses **web.config** to specify database connection details. SuperOffice windows client uses **superoffice.config**, in addition to **superoffice.ini**.

**superoffice.config** is a NetServer config file in the same place as *superoffice.ini* (also found in the same way, if you come in via COM).

The database user and password are stored in *superoffice.config* - encrypted and set by the MSI installer.

**ODBC data source** and **archive path** are taken from *superoffice.ini* automatically. The *superoffice.config* file doesn't need to specify the database server/type unless the ODBC source is non-standard.

The SERVER and DATABASE are dictated by the ODBC source in the *superoffice.ini* file. We look up in the Registry and transfer database and server settings to NetServer (not *superoffice.config*, but directly to NetServer without writing to the .config file).

The database user and password go the other way, from superoffice.config to both NetServer and the C++ code.

## Security considerations

1. **ServerSetup** encrypts and saves the database credentials in an MST file.
2. Client setup extracts the credentials and stores them in the local .config file
3. NetServer decrypts these credentials on behalf of the Windows client.
4. ServerSetup also creates a system user with the same credentials, giving that username a dual role.

The same credentials are used to access NetServer Web Services.

The following steps are recommended to increase security:

* Deactivate the default system user in the SoAdmin client.
* Create a new pair of database- and system users specifically for Sales and Marketing Web and Customer Service.
