---
title: travel       
description:                    
author: {github-id}             # Your GitHub alias.
keywords:
---

# Travel

The local update is based on an update prototype, which is a copy of the central database and contains the same information that the central database contains when the update prototype is generated. Changes since the prototype is generated will be transferred bit by bit, so the prototype should be regularly generated.

Before you may use travel an administrator must active it and assign rights to your user and created a prototype

There are 3 different types of databases that may be used as a travel database:

## Build-in database

If you choose the built-in database then we set it all up for you automatically.

## SQL Express

To use SQL Express you must first download and installed SQL Express from [www.microsoft.com][1].

Please note - the version installed on the computer generating the [prototype][2] must be compatible with the version the travel users are running locally.

The travel client needs a ODBC datasource, could be called **SOTravel**. You just need to add `Name = SOTravel` and `Servername = .\SQLExpress`

Add `Local_datapath=ODBC:SOTravel` to the *SuperOffice.ini* file in *c:\\program files\\superoffice\\superoffice* windows.

If you have any problems going on travel after the prototype is generated, make sure you start SOCRM.exe once elevated (as administrator) and do the local update. This is to make sure SuperOffice have sufficient rights to make the changes needed to use SQL Express.

## Sybase SQL Anywhere 12

Our built-in database is Sybase 12 but is locked to the SuperOffice CRM client and requires both the application and database file to use special keys, preventing updates from other applications. If you have Sybase 12 you may use this instead as the travel database.

<!-- Referenced links -->
[1]: http://www.microsoft.com/
[2]: create-update-prototype.md
