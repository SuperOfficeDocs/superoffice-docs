---
title: silent_serversetup      
description: Silent install of ServerSetup
author: {github-id}
keywords:
so.topic: reference              # article, howto, reference, concept, guide
so.envir: onsite               # cloud or onsite
# so.client:
---

# Silent install of ServerSetup

ServerSetup can be installed silently without using the user interface. All functionality is covered by the available arguments. Error messages or ServerSetups user interface will be displayed on error.

## Examples

**Upgrade:**

`/I UPGA /L US /A c:\so_arc /W Word2007 /E Outlook2007 /P c:\installationpath  /D odbc /US dbuser /PW dbpassword /PR dbprefix`

**New installation:**

`/I NA /L US /A c:\so_arc /W Word2007 /E Outlook2007 /P c:\installationpath /D odbc /US dbuser /PW dbpassword /PR dbprefix /SN serialnumber /CN companyname /CI 826 /FN firstname /LN lastname /UN souser /UP sopassword /LP superlicense-complete /SU systemuser /SP systemuserpassword /AU C:\installationpath\Client`

## Available arguments

| Argument | Description |
|:--------:|-------------|
| /L | Main language. Used for the database and the ClientSetup's configuration files. (if an error happens the GUI may show) ex.: /L US |
| /I | Setup type. One of: NA UPGA (New all/Upgrade from 8.0 or 8.1 all) |
| /AU | Auto update folder. Full path for client setup files |
| /P | Program folder. Full path for program folder |
| /A | Archive folder. Full path for archive folder |
| /T | Template folder. Full path for template folder, this is optional, default is folder named Templates in archive path |
| /S| Source folder. Full path for the *SuperOffice CRM* folder of the CD image, usually located beside the ServerSetup directory |
| /F | Export file. Full path for database export file, only on upgrade with database. Do export is true if /F has a value. |
| /B | Backup done. True or false, default is false |
| /D | ODBC name |
| /US | Username for database |
| /PW | Password for database |
| /PR | Prefix for database |
| /U | Database encoding, U or A. Only used if /I NA is set, default is Unicode. |
| /SN | SerialNumber for new installation |
| /CN | CompanyName for new installation |
| /CI | CountryId for new installation |
| /FN | First name for first user |
| /LN | Last name for first user |
| /UN | Username for first user |
| /UP | Password for first user |
| /LP | Userplan for first user |
| /SU | Systemuser name for SuperOffice |
| /SP | Systemuser password for SuperOffice |
| /E | E-mail client (Outlook2007, Notes, Other. Outlook2007 is default) |
| /W | Word processor (Word2007) |
