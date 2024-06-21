---
title: Upgrade CRM Server
uid: upgrade_crm_server_to_8
description: Upgrade CRM Server to version 8
author: {github-id}
keywords:
topic: howto
envir: onsite
# client:
---

# Upgrade CRM Server to version 8

**SuperOffice 8.0 is a major-sized technical upgrade.** This means that:

* Database will be upgraded (not a rebuild).
* New version of web services. Note that old versions back to Services73 are available.
* Check with your 3rd party vendor if their modules are 8 ready.
* All travelers must be in.
* All Satellites must be re-generated after the upgrade.

## Prerequisites and preparations

* You must be running SuperOffice version 7.5 before upgrading to 8.0.

> [!NOTE]
> If you have used SuperOffice for a long time and renamed labels inside the product, there is a fix in SuperOffice 7.5 SR1 that will move the labels to the correct new database table.

* The CRM server must be installed before you install any one of our clients (Win, Web, Service, Pocket), this is where you set up the database and it will also create a client setup for using the Windows App.

* Since SuperOffice version 8, we now require ALL server components needed to be installed in all scenarios.

[!include[ALT](../../../includes/warn-upgrade-all-to-same-version.md)]

To complete a normal SuperOffice 8 Server installation, you need to install ALL:

1. CRM Server
2. NetServer
3. SuperOffice Web
4. Customer Service
5. SuperOffice Win

SuperOffice Web, Customer Service, and Pocket CRM can all use a single NetServer or a separate NetServer for each.

If the customer is to use Windows clients locally on one or more computers, Windows client installation is needed.

## How to upgrade SuperOffice CRM Server to 8 with travel/satellites

> [!WARNING]
> All active travel users and satellites MUST come home before you upgrade to 8. **ServerSetup will not upgrade if there are active satellites or travel users.**

1. On all satellites, tell travel users to do a homecoming.
2. On all satellites, write updates (up-file) to central.
3. STOP working on the satellite, all changes after this are lost!
4. Centrally, tell all travel users to do a homecoming.
5. Centrally, read in all update files from satellites.
6. Upgrade to CRM 8 centrally.
7. Set up clients and generate new prototypes.
8. Regenerate all satellites.

### Upgrade from SuperOffice 7 Web to SuperOffice 8 Web

1. Make sure all system requirements for all the components are met.
2. Download and unzip the Web installer package on your server.
3. Run the *Setup.exe*.

### Upgrade standard reports

When upgrading to 8.0 from 7.5, you can select if you want to upgrade all or just install new standard reports.

In the screen "Select upgrade of standard reports" you can let the default selection stay, to upgrade all existing standard reports. This will overwrite all existing standard reports and install the new ones. Any edits done to the existing standard reports will disappear. User-defined reports will not be touched.

If you uncheck the checkbox, only new standard reports will be installed, the existing standard reports will remain as they are, so no new layout or features will be available in them. User-defined reports will not be touched.

Standard reports can be imported later with the program SoRepImp.exe or StdRepImp.exe (in the folder STDReportFiles on the CD) in the All or just some reports can then be selected.

Standard reports can also be imported with DbSetup.exe, there are sections in *Sotables.ini* for Importing the new standard reports, and for importing all.

[Back to upgrade overview][1]

<!-- Referenced links -->
[1]: index.md
