---
title: online_migration_tool
description: Running the Online Migration Tool (OMT)
author: {github-id}
keywords:
so.topic: howto
so.envir: onsite              # cloud or onsite
# so.client:
---

# Running the Online Migration Tool

The SuperOffice CRM Online Migration Tool (OMT) is responsible for transferring a local onsite database and document archive to CRM Online. It also makes sure that a set of initial configuration steps are carried out.

The OMT can be executed in one of 2 basic modes:  Initial upload or recovery mode.

The OMT will automatically determine the mode when it starts.

![1.png][img6]

The first step of the OMT is to log on to the local CRM onsite database.  The OMT will try to find a local windows installation.  It will then use that configuration and prompt the user with a user-name and password.  This must be the credentials of a local administrator (User or General Admin) in the CRM Database.

 ![2.png][img7]

Contact details of the person performing the migration must be provided. These are the contact details used during the migration process.

 ![3.png][img8]

All users that shall log in to the migrated customer tenant in SuperOffice CRM Online must have a valid user license.  They must also have a valid email address for logging in.  This email address must be unique.  No other user can have the same email address as such conflict will prevent successful logins to the system.

Both user plans and email address user names must be validated by the migrator before the customer can be migrated to online.

 ![4.png][img9]

A new window is shown when the user clicks Check user plans. The objective of this window is to ensure that all users that should have a valid user plan for log-in, have this.

Each column represents a user plan.  The first column represents no user plan and users in this column are not allowed to log in.  At least one administrator must have a valid user plan.  Administrators are tagged with a golden crown.

 ![5.png][img10]

Drag the user to the correct column to choose user plan.  Write a filter criteria to easier find a particular user or group of users.  All fields shown on the card are used in the free-text filter.  Filtering on name of user-group or position can be an efficient way of working with many users.

 ![6.png][img11]

Click OK when licenses are assigned.  It is possible to come back to re-assign licenses after the other configuration steps are performed as well.

A valid email address must be selected as user name.  All users must have a unique email address.  Select one of the users existing email addresses or write a new address as appropriate.

 ![blobid7.png][img12]

If another user has user name email address populated on his person card at the time of migration, it will be removed.

Filtering works the same way as on the user plan assignment page.

 ![blobid8.png][img13]

Click OK when all users are assigned a valid user name email address.

![blobid9.png][img14]

Continuing the wizard will upload database and documents SuperOffice CRM Online.

It is quite common that some documents are missing during the time of migration. When the documents are found, they can be put into the document archive and uploaded again.  Restarting the OMT will initiate the recovery process uploading missing document files.

![blobid10.png][img15]

Log on to the local database in the same way as a regular migration.

![blobid11.png][img16]

Missing documents will then be uploaded.

![blobid12.png][img17]

Close the OMT when the client-side of migration has been completed.

![blobid13.png][img18]

<!-- Referenced links -->

<!-- Referenced images -->
[img6]: media/1.png
[img7]: media/2.png
[img8]: media/3.png
[img9]: media/4.png
[img10]: media/5.png
[img11]: media/6.png
[img12]: media/blobid7.png
[img13]: media/blobid8.png
[img14]: media/blobid9.png
[img15]: media/blobid10.png
[img16]: media/blobid11.png
[img17]: media/blobid12.png
[img18]: media/blobid13.png
