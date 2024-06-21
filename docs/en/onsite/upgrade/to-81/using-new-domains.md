---
title: Upgrade to 8.1 with new domains
uid: upgrade_to_81_new
description: Upgrade to 8.1 when using new domains
author: Martin Pavlas
date: 12.08.2021
keywords: upgrade
topic: howto
envir: onsite
# client:
version: 8.1
---

# Upgrade to 8.1 or newer when choosing a brand new domain for both clients

![Move both Sales web client and Service to a new domain -screenshot][img8]

1. Run **SuperOffice SM.win** **SetupExe.exe** installer to upgrade the server and the database.

2. Run **SuperOffice.CustomerService.exe** to Install Service and choose to let the installer create the IIS website.

3. Run **SuperOffice Web client** **Setup.exe** to install SuperOffice Sales web client on the newly created Service domain.

4. Start the Web client and set the new **Web Base URL** preference in Settings and Maintenance client.

5. Under [Move to new server][2] there are some steps explained to update the database to see the new domain used.
    * Stop the current service and add "frozen" to the config file located in the old Service program folder.
    * Update database table Config and Registry with the new paths.
    * Copy/move attachments/templates and customer center folders from the old installation to the new.
    * Run queries to update the absolute that will be found in the database.
    * Consider if a redirect should be added so customers using old URLs will be redirected correctly to the new.
    * Run `upgrade.exe -d newdomain` to make sure Service is upgraded as well.

<!-- Referenced links -->
[2]: move-crm-server.md

<!-- Referenced images -->
[img8]: media/moveboth.png
