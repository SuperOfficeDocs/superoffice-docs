---
title: Service configuration
uid: service_configuration
description: Description of Service configuration
author: Bergfrid Dias
date: 12.12.2021
keywords: service, config, nsEndPoint
topic: concept
envir: onsite
# client:
---

# Core configuration of Service

Used for connecting to NetServer, the database, and putting your service installation in maintenance mode.

## Example service.config file

```text
dbHost = localhost
dbUsername = crm7
dbPassword = password
dbDatabase = SuperOffice
dbType = mssql
nsUser = ejSysUser
nsPass = cpbtrzdo
nsAnonUser = ejSysUser
nsAnonPass = cpbtrzdo
nsEndPoint = http://localhost/NetServer/Services88
defaultContact = 2
#frozen
```

## Configuration settings

If a configuration setting is prefixed by a #, it means it is commented out and will not be read by the system. This is mostly used for the frozen setting.

| Name | Description |
|---|---|
| dbHost | IP address or resolvable hostname of your database server. |
| dbUsername | Username for connecting to the SuperOffice database. |
| dbPassword | Password for the username used when connecting to the SuperOffice database. |
| dbDatabase | Name of the ODBC source for database connection. |
| dbType | Type of database, for example, MSSQL or Oracle. |
| nsUser | Username for connecting to NetServer. This username defaults to ejSysUser and has a randomly generated password upon installation. |
| nsPass | Password for nsUser. |
| nsAnonUSer | Same as above, but used for anonymous access |
| nsAnonPass | Same as above, but used for anonymous access |
| nsEndPoint | Resolvable URL for your NetServer installation. |
| defaultContact | Should always be the ID of the company owner card in your crm7.contact table. In most scenarios, 2 (SuperOffice has ID 1), but in some older installations, the owner card can be 1. |
| frozen | Takes no parameters, but when not commented out it sets Service in maintenance. |

### nsUser

The nsUser needs to have the type "System user" and an "Active" login under **Users > Other users** in your admin client. The "Other users" type is accessible only when logging into the web admin client with a system user (crm7).

You might want to change this password if you had to recreate your Service installation and the newly randomized password in the config file is not identical to the one stored in the database.

### nsEndPoint

Running [upgrade.exe][1] will automatically set the correct Services version.

> [!NOTE]
> Service still does not support running HTTPS on the NetServer it uses. See our [recommended scenario #2][2] on how to use a reverse proxy to secure the installation but make sure the endpoint for Service inside is using HTTP.

### frozen

This setting is valuable when you want to avoid having users logging/being logged in when you have scheduled/announced an update/maintenance.

Always remember to remove this or comment it out after you have completed your maintenance.

<!-- Referenced links -->
[1]: ../upgrade/index.md
[2]: ../../onsite/security/deployment-scenarios.md
