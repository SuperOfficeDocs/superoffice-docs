---
title: Sybase as Travel database
uid: set_up_sybase_travel
description:  Sybase as Travel database
author: SuperOffice Product and Engineering
keywords: travel
date:
content_type: howto
deployment: onsite
platform: win
redirect_from: /en/onsite/travel/sybase/index
---

# Sybase as Travel database

## Prerequisites

* Client computers must install Sybase

## Automatic setup

As long as the central database has set up Sybase as the Local datatype, everything is automatically set up for the user who has been [assigned travel rights in SOAdmin][1]. The central *SuperOffice.ini* file has the information, so SOLoader.exe sets up the local datasource.

[!include[ALT](../includes/local-update.md)]

## Manual setup

Default paths set up automatically are:

```text
local_archivepath=c:\Documents and Settings\USER\Local Settings\Application Data\SuperOffice\SO_LOCAL
Local_Datapath=ODBC:SuperOfficeLocal
```

The ODBC datasource will by default put the local database file in:

`C:\Documents and Settings\USER\Local Settings\Application Data\SuperOffice\SO_LOCAL\DATA\SoTravel.db`

If you want to change the location of the local document archive or the travel database, you need to edit the users' *SuperOffice.ini* file and the users ODBC datasource SuperOfficeLocal. You may change the name of the datasource as long as you also change the `Local_Datapath=ODBC:XXX` where XXX needs to be the new name of the local datasource.

### Change the local datasource

![1 -screenshot][img1]

![2 -screenshot][img2]

Make sure the local *SuperOffice.ini* now says `Local_Datapath=ODBC:MYTravelDB`

<!-- Referenced links -->
[1]: ../activate.md

<!-- Referenced images -->
[img1]: media/sixsybasetraveldb.jpg
[img2]: media/sixsybasetraveldb2.jpg
