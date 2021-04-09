---
title: set_up_sql_express_travel
description: MSDE / SQL express as travel database
author: {github-id}
keywords: travel
so.date:
so.topic: howto
so.envir: onsite
so.client: win
---

# MSDE / SQL express as travel database

## Prerequisites

Client computers must install either MSDE or SQL Express depending on what kind of [central database][1]. Run it, reboot, and observe the small SQL Server icon with a small green triangle in the taskbar.

> [!NOTE]
> MSDE is NOT supported as a travel database if your central SuperOffice database is running on MS SQL Server 2005.

## Automatic setup

As long as the central database has set up MSDE as the Local datatype, everything is automatically set up for the user who has been [assigned travel rights in SOAdmin][2]. The central *SuperOffice.ini* file has the information so SOLoader.exe sets up the local datasource and adds the **ProtoServerPath** and **ProtoClientPath** to the local *SuperOffice.ini*.

[!include[ALT](../includes/local-update.md)]

## Manual setup

Default paths set up automatically are:

```text
local_archivepath=c:\Documents and Settings\\Local Settings\Application Data\SuperOffice\SO_LOCAL
Local_Datapath=ODBC:SuperOfficeLocal
```

If you want to change the location of the local document archive, you need to edit the users' *SuperOffice.ini* file. You may change the name of the datasource as long as you also change the `Local_Datapath=ODBC:XXX` where XXX needs to be the new name of the local datasource.

MSDE (both MSDE and SQL Express) require `ProtoClientPath` (and `ProtoServerPath`) set. If the client is not going to make a prototype, you only need to add `ProtoClientPath=` under the **SuperOffice** section in *SuperOffice.ini*.

<!-- Referenced links -->
[1]: ../overview.md
[2]: ../activate.md
