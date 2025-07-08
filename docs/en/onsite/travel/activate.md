---
title: Activate travel
uid: activate_travel
description: How to activate travel function
author: SuperOffice Product and Engineering
keywords:
date:
content_type: howto
deployment: onsite
platform: win
---

# Activate travel

Before you can start using the Travel function, the database must be enabled for Travel use. Do as follows:

1. Open the **Replication** screen in the Admin client.

2. Check **Travel and satellite configurations are possible** (transaction logging is active).

    > [!NOTE]
    > **Do not uncheck this option if anyone is currently using Travel.** If you do, Travel users will not be able to update the central database. Active Travel users are shown in the list in the middle of the **Replication** screen.

3. Under **Local DB Type** select the type of database to use locally: Built-in database, Sybase Anywhere, or MS SQL Server Express.

4. Click **OK**. The database is now enabled for Travel use.

5. Restart the Admin client.

## User rights

To enable associates to use SuperOffice Travel, you must specify Travel rights for them. Do as follows:

1. Open the **Users** screen in the Admin client, which is run from SOADMIN.EXE.

2. Select the required company from the **Company** list. This contains your organization (defined as a database owner) and any other organizations that have login rights for the SuperOffice database, such as subsidiaries.

3. Select the required user in the list in the middle of the screen.

4. Check **Allow travel** to enable this person to use the SuperOffice Travel functions.

5. Click **OK** to save your changes.

Before users can go on travel, you need to create an [update prototype][1], either from the admin client or by setting up the [travel gateway][2].

<!-- Referenced links -->
[1]: update-prototype.md
[2]: travel-gateway/index.md
