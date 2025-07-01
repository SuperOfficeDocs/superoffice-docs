---
title: Travel
uid: travel
description: Travel
author: SuperOffice Product and Engineering
keywords:
date:
content_type: concept
deployment: onsite
platform: win
---

# Travel

SuperOffice Travel is a sub-system of SuperOffice Win client that enables you to take the CRM database with you and run it locally on a computer, without being connected to the network and the main database.

![1 -screenshot][img1]

When you have used the Travel version and made changes in the local database, you can update the main database so that these changes become available to other users.

To be able to use Travel you need to prepare the database and set up the client.

Remote travel has two features to make it even simpler for remote travel users to get the information they need:

* SuperOffice Remote Travel
* SuperOffice Remote Travel Server (SORTS)

To use SuperOffice without being connected to the network, associates must first perform a local update to transfer information from the central database to a local database. The local update is based on an **update prototype**, which is a copy of the central database and contains the same information that the central database contains when the update prototype is generated. Changes after the prototype was generated will be transferred bit by bit, so the prototype should be regularly generated.

> [!NOTE]
> Before you may use travel, an administrator must activate it and assign rights to your user and create a Travel prototype.

## Database types

There are 3 different types of databases that may be used as a travel database:

* Built-in database
* SQL Express
* Sybase SQL Anywhere 12

From CRM 7 SR1, you may choose the type of travel database independent of what type of database your central database is running.
If you're running an earlier version, your central database type determines the kind of travel database type you may use:

| Central database type | MS SQL Express travel database | Sybase travel database (requires a Sybase license) | Built-in travel database |
|---|---|---|---|
| MS SQL 2008 R2 and newer | X | X | X |
| Oracle | | X | X |

### Built-in database

If you choose the built-in database then we set it all up for you automatically. Sybase 12 is used as the built-in Travel database.

### SQL Express

To use MS SQL Express you must first download and install MS SQL Express from [www.microsoft.com][1].

> [!NOTE]
> The version installed on the computer generating the [prototype][2] must be compatible with the version the travel users are running locally.

The Travel client needs an ODBC datasource, which could be called **SOTravel**. You just need to add `Name = SOTravel` and `Servername = .\SQLExpress`

Add `Local_datapath=ODBC:SOTravel` to the *SuperOffice.ini* file in *c:\program files\SuperOffice\SuperOffice* windows.

If you have any problems going on Travel after the prototype is generated, make sure you start SOCRM.exe once elevated (as administrator) and do the local update. This is to make sure SuperOffice has sufficient rights to make the changes needed to use SQL Express.

### Sybase SQL Anywhere 12

Our built-in database is Sybase 12 but is locked to the SuperOffice CRM client and requires both the application and database file to use special keys, preventing updates from other applications. If you have Sybase 12, you may use this instead as the travel database.

To use Sybase 12 owned license you need to follow [these steps][3].

<!-- Referenced links -->
[1]: http://www.microsoft.com/
[2]: update-prototype.md
[3]: sybase/set-up.md

<!-- Referenced images -->
[img1]: media/travel.png
