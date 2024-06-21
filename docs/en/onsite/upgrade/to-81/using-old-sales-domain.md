---
title: Upgrade to 8.1 with old Sales domain
uid: upgrade_to_81_sales
description: Upgrade to 8.1 when using the old Sales domain
author: Martin Pavlas
date: 12.08.2021
keywords: upgrade
topic: howto
envir: onsite
# client:
---

# Upgrade to 8.1 or newer when using the old Sales domain

![Move Service to Sales web client domain -screenshot][img6]

1. Run **SuperOffice SM.win** **SetupExe.exe** installer to upgrade the server and the database.

2. Run **SuperOffice Web client** **Setup.exe** to upgrade SuperOffice Sales web client. Remember to tick **Expose NetServer web services** if Service should use the same web services as the Web client.

3. Start the Web client and set the new Web Base URL preference in Settings and Maintenance client.

4. Run **SuperOffice.CustomerService.exe** to install Service software on the same server as Web. You must **untick** the "Create IIS website" or you will get an error since it already exists.

    ![x -screenshot][img7]

5. Under [Move to new server][2], there are some steps explained to update the database to see the new domain used.
    * Stop the current service and add "frozen" to the config file located in the old Service program folder.
    * Update database table Config and Registry with the new paths.
    * Copy/move attachments/templates and customer center folders from the old installation to the new.
    * Run queries to update the absolute URLs that will be found in the database.
    * Consider if a redirect should be added so customers using old URLs will be redirected correctly to the new.
    * Run `upgrade.exe -d newdomain` to make sure Service is upgraded as well.

<!-- Referenced links -->
[2]: move-crm-server.md

<!-- Referenced images -->
[img6]: media/servicetosales.png
[img7]: media/servicenoiis.png
