---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: service_config # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Service config # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id} # Your GitHub alias.
keywords:
so.topic: reference # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite # cloud or onsite
# so.client: # online, web, win, pocket, or mobile
---

# Service config

Core configuration of Service.

Used for connecting to NetServer, the database, and putting your service installation in maintenance mode.

## Example of a config file

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
nsEndPoint = http://localhost/NetServer/Services8x
defaultContact = 2
#frozen
```

## Configuration settings

If a configuration setting is prefixed by a #, it means it is commented out and will not be read by the system. This is mostly used for the frozen setting.

### dbHost

IP address or resolvable hostname of your database server.

### dbUsername

Username for connecting to the SuperOffice database.

### dbPassword

Password for the username used when connecting to the SuperOffice database.

### dbType

Type of database, for example, MSSQL or Oracle.

### nsUser

Username for connecting to NetServer. This username defaults to ejSysUser and has a randomly generated password upon installation.

The user needs to have the type "System user" and an "Active" login under "Users"->"Other users" in your admin client. Be aware that the "Other users" type is only accessible when logging into the web admin client with a system user (crm7).

You might want to change this password if you had to recreate your Service installation and the newly randomized password in the config file is not identical to the one stored in the database.

### nsPass

Password for the username used when connecting to the NetServer. For more information see above.

### nsAnonUSer

Same as above, but used for anonymous access

### nsAnonPass

Same as above, but used for anonymous access

### nsEndPoint

Resolvable URL for your NetServer installation. Running [upgrade.exe][1] will automatically set the correct Services version, but below is an overview.
Please note that Service still does not support running HTTPS on the NetServer it uses. See our [recommended scenario #2][2] on how to use a reverse proxy to secure the installation but make sure the endpoint for Service inside is using HTTP.

### defaultContact

Should always be an integer with the ID of the company owner card in your crm7.contact table.
In most scenarios, this should be 2 (SuperOffice having ID 1), but in some older installations, the owner card can be 1.

### frozen

Takes no parameters, but when not commented out it sets Service in maintenance. Valuable when you want to avoid having users logging/being logged in when you have scheduled/announced an update/maintenance. Always remember to remove this or comment it out after you have completed your maintenance.

<!-- Referenced links -->
[1]: ../service/upgrade.md
[2]: ../security/deployment-scenarios.md
