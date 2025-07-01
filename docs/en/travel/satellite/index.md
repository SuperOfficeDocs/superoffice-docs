---
title: Satellite overview
description: Overview of the satellite function
author: SuperOffice Product and Engineering
keywords: tavel
content_type: concept
deployment: onsite
platform: win
---

# Satellite

> [!NOTE]
> Requires a separate license and [area management][1].

## Overview

![x -screenshot][img1]

Satellite is a function that enables you to create your own databases based on the central database.

These databases can either contain exactly the same information as the central database, or they can be segmented into areas so that the content reflects which users’ data are included. You will find more information about database segmentation under [Area Management][1].

One example of a situation where Satellite can be useful is if a company with a head office in Paris has subsidiaries in two other cities, for example, Hamburg and Amsterdam.

The head office and the subsidiaries communicate with each other via VPN. If two users in Hamburg wish to take the SuperOffice database with them while traveling, they must copy a prototype (this is described in [Generating an update prototype][2]). It takes too long to do this over a VPN line and therefore they need a multi-user database that functions as a home database but still has a connection with Paris. The solution is Satellite, where Paris has the central database, and Hamburg and Amsterdam each have their own satellite.

To explain what Satellite is, we can imagine a Remote Travel multiuser who never comes "home". This means that he never returns to the home office, updates the central database, and deletes his own database.
A Satellite can have a large number of users. In Satellite Management, the same type of update file (.UP and .DWN) are used as in Remote Travel. In principle, the database lives forever. It does not need to "come home", be deleted, and then "re-emerge".The update files. UP and. DWN contains all the changes made at each end.

In our example, Satellite Management the three Satellites, Hamburg and Amsterdam will all be updated against Paris. This means that if anyone makes changes in the database in Hamburg, these changes will be displayed (replicated) into the central database (which at any time contains a copy of all the data in the system) and is sent to the other Satellites. Area Management is also used in this case and works in the same way as with Travel so that the user only has sign-on rights to one place at a time. In other words, if you work with a Satellite database, you cannot sign on to the central database by default*.

Users can travel from a Satellite, but then they take the whole Satellite with them. Travel users on the central database can have as many areas as they wish. Both standard Travel and Asynkron Travel can be used from a Satellite. Like with Asynkron Travel, you can change an area for users working with a Satellite database. Read more information about this under [Area Management.][1].

A benefit of separate databases for regional offices or subsidiaries is that this new database becomes the central database for each regional office or subsidiary. This means that each regional SuperOffice employee can share the data via a local network at the regional office. To synchronize with the central database, only one "net change file" has to be transferred between the regional database and the central database.
You can create up to 114 Satellite databases from a central database.

\*There is a preference in SOAdmin - Preferences - System called **Allow central login for Travel users** which may be turned on to allow this.

## Synchronization between a satellite and central database

A Satellite database is similar to a Remote Travel user in terms of synchronizing with the central database. SuperOffice gives the Satellite database a name when it is created, for example, S1.sda if it is exported as a file (if you have access to the server where the satellite database should reside you may generate it directly into an ODBC data source).

S1 is the name of the directory that SuperOffice uses to store "net change files" between the Satellite and the central database.
In the directory/folder SO_ARC on the server, the directory/folder S1 tracks all incoming log files from the Satellite, and stores new log files from the server to be sent to the Satellite.
In the directory/folder SO_ARC on the regional server, the directory/folder S1 tracks all incoming log files from the central database, and stores new log files from the Satellite to be sent to the central database.

<!-- Referenced links -->
[1]: ../area-management/index.md
[2]: ../update-prototype.md

<!-- Referenced images -->
[img1]: media/satellites.png
