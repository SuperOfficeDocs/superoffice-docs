---
title: Set up Satellite
uid: set_up_satellite
description: How to set up Satellite
author: SuperOffice Product and Engineering
keywords: travel, satellite
content_type: howto
deployment: onsite
platform: win
---

# Set up Satellite

Satellite is accessed via the Replication screen.

## Pre-requisites

* Decide if the Satellite database should contain the same data as the central database, or be segmented

* Consider how many Satellite companies you need. Each Satellite is owned by a company in the central database. Such companies are called **Satellite Companies**.

* Decide which users belong in each Satellite by assigning them log-in rights in the area that defines the Satellite. Users who are not assigned login rights for any Satellite continue to be users on the central database

## Steps

1. Enter a company in SuperOffice Sales & Marketing client.

2. Define the company as a satellite company. Do this in the **Options** screen in the Maintenance Client in the same way as you add other companies.

3. Enter the satellite company’s employees as contacts of the satellite company. Do this in the **Users** screen in the Maintenance Client in the same way as you add other contacts.

    > [!NOTE]
    > This is not necessary to use the satellite, but it will make it easier to maintain an overview.

4. Activate the satellite company’s contacts as associates in the central database by assigning them IDs, passwords, a user group, login rights, and where appropriate, Travel rights. Do this in the **Users** screen in the same way as you activate other users.

5. Define an area for the satellite company to determine which Sales & Marketing users’ data will be included in the satellite database, and which users will have login rights to it. Do this in the **Replication** screen, as described under Using Area Management.

6. Generate the satellite using Satellite.

## Generate a satellite

1. Open the **Replication** screen in SOAdmin.

2. Click the **Define satellites** button on the right of the screen.

3. In the **Generate Satellite** dialog, click **Add**.

4. In the **New satellite** dialog, set the following values:

    * Select the correct area from the **Area name** list (see [Area Management][1]).

    * Select the Satellite that owns the satellite employees from the **Company** list.

    * Select database type: Built-in or ODBC.

5. Click **Save** to start generating the satellite. A message box displays the progress of the task.

    Depending on how large the selected database is, this process can take anything from about a minute to several hours.

6. When the satellite is regenerated, a message is displayed indicating that the generation was successful. Click **OK**.

<!-- Referenced links -->
[1]: ../area-management/index.md

<!-- Referenced images -->
