---
title: create_update_prototype
description:                 
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto             # article, howto, reference, concept, guide
so.envir: onsite                # cloud or onsite
so.client: win               # online, web, win, pocket, or mobile
---

# Create an update prototype

The local update is based on an update prototype, which is a copy of the central database and contains the same information that the central database contained when the update prototype was generated. It is much quicker and more efficient to copy a single file than to copy data from a complex database (by a factor of 50 or more). With the prototype as an intermediary, the local update is performed more rapidly.

The computer used to generate a prototype must have a full SQL server or SQL Express installed. The SuperOffice.ini file in the program folder must have two additional configuration settings to generate a prototype. The SuperOffice.ini file for the users going on travel in addition needs the `Local_datasource` setting.

Make sure you start SOAdmin.exe elevated (as administrator) the first time you try to generate a prototype.

## Configuration

### Paths and configuration variables

The prototype is generated on a database server, and the actual database file must reside on the same server. If the archivepath file store and the database server run on different computers, the prototype will have to be created on the database server and not the archivepath file server – this is how SQL Server works.

Two new variables have to be added to *superoffice.ini* in the `SuperOffice` section for this purpose, note that both should point to the same location on the same computer as the SQL prototype is generated:

```text
ProtoServerPath=c:\SOProto
ProtoClientPath=c:\SOProto
```

These 2 items have to be inserted into the *Superoffice.INI* manually, and they are read at start-up, so you need to restart SOAdmin.exe if you just added it and it's still complaining that the ProtoServerPath is missing.

When the prototype has finished, the database files will be automatically zipped and copied to the `ARCHIVEPATH`, like *\\\\SERVER\\SO\_Arc\\Template\\travel*.

> [!NOTE]
> These are ONLY necessary for clients who are going to generate prototypes. The normal travel user does not need any of these paths to do a local update.

## ProtoServerPath

The full path (without filename) to the place you want the prototypes to be created, _as viewed from the server._ So this should always be a local path, like c:\\so\_proto or something similar. This path is going to be used when SOAdmin or the travel gateway service tells the SQL Server to create a new database; the statement will be processed by the database server and must therefore refer to a file path local to the server machine.

## ProtoClientPath

Originally this was the full path (without filename) to the central *SO\_arc\\template\\travel* folder where the prototype will be zipped and copied too so the client finds it late. Since we now always zip down the prototype to central *so\_arc\\template\\travel*, you specify the same path as in ProtoServerPath and the application will automatically copy the prototype to so\_arc\\template\\travel at the end of the prototype generation.

From SR1 these are only required on clients who are also going to generate prototypes.

## AREA data source

The AREA odbc data source must be configured on the machine(s) used for generating prototypes. It does not need to be configured on normal Travel clients. This is just as usual.

When creating the AREA data source, you only need to go through the first page of the Wizard.

On the first page, fill in the name AREA and choose the correct SQL Server.

![x][img1]

<!-- Referenced links -->

<!-- Referenced links -->
[img1]: media/areaodbc.png
