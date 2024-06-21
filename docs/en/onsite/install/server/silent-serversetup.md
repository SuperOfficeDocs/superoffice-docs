---
title: Silent install of ServerSetup
uid: silent_serversetup
description: Silent install of ServerSetup
author: {github-id}
keywords:
topic: reference
envir: onsite
# client:
---

# Silent install of ServerSetup

ServerSetup can be installed silently without using the user interface. All functionality is covered by the available arguments. Error messages or ServerSetups user interface will be displayed on error.

## Examples

**Upgrade:**

`/I UPGA /L US /A c:\so_arc /W Word2007 /E Outlook2007 /P c:\installationpath /D odbc /US dbuser /PW dbpassword /PR dbprefix`

**New installation:**

`/I NA /L US /A c:\so_arc /W Word2007 /E Outlook2007 /P c:\installationpath /D odbc /US dbuser /PW dbpassword /PR dbprefix /SN serialnumber /CN companyname /CI 826 /FN firstname /LN lastname /UN souser /UP sopassword /LP superlicense-complete /SU systemuser /SP systemuserpassword /AU C:\installationpath\Client`

## Available arguments

| Argument | Description |
|:--------:|-------------|
| /L | Main language. Used for the database and the ClientSetup's configuration files. (if an error happens the GUI may show) ex.: /L US |
| /I | Setup type. NA or UPGA (New all/Upgrade from 8.0 or 8.1 all) |
| /AU | Auto-update folder. The full path for client setup files |
| /P | Program folder. The full path for program folder |
| /A | Archive folder. The full path for archive folder |
| /T | Template folder. The full path for the template folder (optional), default is the *Templates* folder in archive path |
| /S| Source folder. The full path for the *SuperOffice CRM* folder of the CD image, usually located beside the ServerSetup directory |
| /F | Export file. The full path for database export file, only on upgrade with a database. Do export is true if /F has a value. |
| /B | Backup done. True or false, default is false |
| /D | ODBC name |
| /US | Username for database |
| /PW | Password for database |
| /PR | Prefix for database |
| /U | Database encoding, U or A. Only used if /I NA is set, default is Unicode. |
| /SN | SerialNumber for new installation |
| /CN | CompanyName for new installation |
| /CI | CountryId for new installation |
| /FN | First name for the first user |
| /LN | Last name for the first user |
| /UN | Username for the first user |
| /UP | Password for the first user |
| /LP | User plan for the first user |
| /SU | Systemuser name for SuperOffice |
| /SP | Systemuser password for SuperOffice |
| /E | Email client (Outlook2007, Notes, Other. Outlook2007 is default) |
| /W | Word processor (Word2007) |

***

[Previous][11] | [Next][12] | [Back to guide][13]

<!-- Referenced links-->
[11]: ../../../service/install/prepare.md
[12]: ../../../service/install/index.md
[13]: ../guide.md
