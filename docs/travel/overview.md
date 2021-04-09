---
title: travel       
description: Travel
author: {github-id}             # Your GitHub alias.
keywords:
so.date:
so.topic: concept
so.envir: onsite
so.client: win
---

# Travel

SuperOffice Travel is a sub-system of SuperOffice CRM that enables you to take the CRM database with you and run it locally on a computer, without being connected to the network and the main database.

![1][img1]

When you have used the Travel version and made changes in the local database, you can update the main database so that these changes become available to other users.

To be able to use travel you need to prepare the database and set up the client.

Remote travel now has 2 new features to make it even simpler for you remote travel users to get the information they need:

* SuperOffice Remote Travel
* SuperOffice Remote Travel Server (SORTS)

To use SuperOffice without being connected to the network, associates must first perform a local update to transfer information from the central database to a local database. The local update is based on an **update prototype**, which is a copy of the central database and contains the same information that the central database contains when the update prototype is generated. Changes after the prototype was generated will be transferred bit by bit, so the prototype should be regularly generated.

> [!NOTE]
> Before you may use travel, an administrator must activate it and assign rights to your user and create a prototype.

## Database types

There are 3 different types of databases that may be used as a travel database:

* Built-in database
* SQL Express
* Sybase SQL Anywhere 12

From CRM 7 SR1, you may choose type of travel database independent on what type of database your central database is running.
If you're running an earlier version, your central database type determines the kind of travel database type you may use:

| Central database type | MS SQL Express travel database | Sybase travel database (requires a Sybase license) | Built-in travel database |
|---|---|---|---|
| Microsoft SQL 2008 Server | | X | X |
| Microsoft SQL 2005 Server | From 6.2 we support SQL Express 2005 only | X | X |
| Oracle | | X | X |

If you're not running 6.2 or higher you have to use the default built-in database engine or Sybase Adaptive Server Anywhere as your travel database.

### Built-in database

If you choose the built-in database then we set it all up for you automatically. Sybase 12 is used as built-in from 7.0 SR1.

### SQL Express

To use SQL Express you must first download and installed SQL Express from [www.microsoft.com][1].

* SQL Express 2012 is supported from 7.0 SR3
* SQL Express 2008 is supported from 7.0 SR1

> [!NOTE]
> The version installed on the computer generating the [prototype][2] must be compatible with the version the travel users are running locally.

The travel client needs an ODBC datasource, which could be called **SOTravel**. You just need to add `Name = SOTravel` and `Servername = .\SQLExpress`

Add `Local_datapath=ODBC:SOTravel` to the *SuperOffice.ini* file in *c:\\program files\\superoffice\\superoffice* windows.

If you have any problems going on travel after the prototype is generated, make sure you start SOCRM.exe once elevated (as administrator) and do the local update. This is to make sure SuperOffice has sufficient rights to make the changes needed to use SQL Express.

### Sybase SQL Anywhere 12

Our built-in database is Sybase 12 but is locked to the SuperOffice CRM client and requires both the application and database file to use special keys, preventing updates from other applications. If you have Sybase 12, you may use this instead as the travel database.

To use Sybase 12 owned license you need to follow [these steps][3].

<!-- Referenced links -->
[1]: http://www.microsoft.com/
[2]: update-prototype.md
[3]: sybase/set-up.md

<!-- Referenced images -->
[img1]: media/travel.png
