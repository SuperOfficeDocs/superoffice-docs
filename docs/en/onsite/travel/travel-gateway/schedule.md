---
title: Schedule
uid: schedule
description: Schedule tasks for Travel gateway
author: SuperOffice Product and Engineering
keywords: schedule, Travel Gateway, SOTrvGate.exe, Signal.dat
date: 12.17.2021
content_type: howto
deployment: onsite
platform: win
---

# Schedule tasks for Travel gateway

> [!NOTE]
> Unless you run Travel gateway as a service, you must not close the Travel gateway program. If you do, the activities will not be performed until you start the program again.

To add a new activity to be run automatically:

1. Run SuperOffice Travel Gateway - start **SOTrvGate.exe** located in the SuperOffice program files folder.

2. Click **New** to open the dialog where you specify what SuperOffice Travel Gateway should do.

3. In the **Type** field, select the activity from the list. You can choose from these options:

    * Log in (obsolete)
    * Log out (obsolete)
    * Read updates
    * Write updates
    * Generate new Prototype
    * Read updates from all users
    * Write updates to all users
    * Generate Prototypes for all areas
    * Execute program/batch file
    * Create signal file
    * Remote Travel Server
    * Regenerate all counters
    * Regenerate all statuses
    * Synchronize with ERP

    [View descriptions of each type][1]

4. Under **Scheduling**, you can choose from the following options:

    * Immediately after the preceding activity
    * Interval (all combinations of time and date)
    * When signal file exists

5. Click **OK** to return to the main Gateway window. Once an activity has been performed, the date is automatically changed to the next scheduled time.

6. If the Travel Gateway is not running as a service, once you have made the required changes, you need to reset the execution status back to **Active** so that SuperOffice Travel Gateway can perform the activities.

> [!NOTE]
> If you choose to schedule with signal files, the activity starts when it finds a signal file. Once the activity has finished running, the signal file is deleted. The *Signal.dat* file should be created in SO_Arc where the gateway is looking for it.

<!-- Referenced links -->
[1]: activity-types.md
