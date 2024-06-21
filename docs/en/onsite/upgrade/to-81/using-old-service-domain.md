---
title: Upgrade to 8.1 with old Service domain
uid: upgrade_to_81_sevice
description: Upgrade to 8.1 when using the old Service domain
author: Martin Pavlas
date: 12.17.2021
keywords: upgrade, Service, SetupExe.exe, SuperOffice.CustomerService.exe, Setup.exe, SuperOffice Product Configuration, nsEndPoint
topic: howto
version: 8.1
envir: onsite
# client:
---

# Upgrade to 8.1 or newer when using the old Service domain

![Move Sales web client to Service domain -screenshot][img4]

1. Run the **SuperOffice SM.win** **SetupExe.exe** installer to upgrade the server and the database.

2. Run **SuperOffice.CustomerService.exe** to upgrade Service software.

3. Run the **SuperOffice Web client** **Setup.exe** to install the SuperOffice Sales web client on the existing Service domain.

4. Run the **SuperOffice Product Configuration** to connect to the database upgraded in step 1. If you choose to not run separate NetServer web services, make sure you tick the option to expose NetServer web services.

    ![x -screenshot][img5]

5. Start Web client to verify it runs correctly. Go to Settings and Maintenance and set the new preference **System - Base URL for Web client**.

6. Edit config file found in the Service root folder and point `nsEndPoint` to the **new Web client services URL**.

7. Run **Upgrade.exe** (as administrator) located in *Service programfolder\bin*. The upgrade.exe will among other things also update the config file found in the Service program folder with the new Services endpoint, **Services84**.

<!-- Referenced links -->

<!-- Referenced images -->
[img4]: media/salestoservice.png
[img5]: media/exposenetserverwebservices.png
