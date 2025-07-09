---
title: Set up
uid: set_up_sql_express_travel
description: MSDE / SQL express as travel database
author: SuperOffice Product and Engineering
keywords: travel
date:
content_type: howto
deployment: onsite
platform: win
redirect_from: /en/onsite/travel/sql-express/index
---

# MS SQL Express as Travel database

## Prerequisites

Client computers must install MS SQL Express depending on what kind of [central database][1]. Run it, reboot, and observe the small SQL Server icon with a small green triangle in the taskbar.

## Automatic setup

As long as the Central database has set up MS SQL Express as the Local datatype, everything is automatically set up for the user who has been [assigned travel rights in SOAdmin][2]. The central *SuperOffice.ini* file has the information so SOLoader.exe sets up the local datasource and adds the **ProtoServerPath** and **ProtoClientPath** to the local *SuperOffice.ini*.

[!include[ALT](../includes/local-update.md)]

## Manual setup

Default paths set up automatically are:

```text
local_archivepath=C:\Documents and Settings\USER\Local Settings\Application Data\SuperOffice\SO_LOCAL
Local_Datapath=ODBC:SuperOfficeLocal
```

If you want to change the location of the local document archive, you need to edit the users' *SuperOffice.ini* file. You may change the name of the datasource as long as you also change the `Local_Datapath=ODBC:XXX` where XXX needs to be the new name of the local datasource.

MS SQL Express requires `ProtoClientPath` (and `ProtoServerPath`) set. If the client is not going to make a prototype, you only need to add `ProtoClientPath=` under the **SuperOffice** section in *SuperOffice.ini*.

<!-- Referenced links -->
[1]: ../index.md
[2]: ../activate.md
