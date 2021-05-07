---
title: Migration guide
uid: migration_guide
description: Migrate to SuperOffice CRM Online
author: {github-id}
keywords: migrate
so.topic: guide
so.envir: onsite, online
# so.client:
---

# Migrate to Online

If you want to migrate to CRM Online you should contact your SuperOffice sales person, who will help you start the process.

The migration process must be initiated by your SupeOffice sales representative since all migrations will involve SuperOffice Online Operations. The sales representative will enlist a responsible technical consultant that will execute the migration (Migrator).

> [!CAUTION]
> If you have customizations or integrations, these may not be working after the migration. Check with the customization or integration developer if they have this available for CRM Online too, or check if the [App Store][1] has an app you may use instead.

If you have Customer Service and want to migrate your data to our cloud, you need to [adjust email service][3].

## Downtime during migration

You will have some downtime during the migration, the time depends on how large the database and document archive is.

## Before you migrate

### Your onsite SuperOffice version

You need to be on at least version 7.1 to migrate to CRM Online. If you run an older version of SuperOffice than 7.1, then an upgrade must be performed first.

### SuperOffice Admin check

The migrator needs access to the SuperOffice admin client with a user with SuperOffice administrative rights.

Before migrating you will need to go through the following steps in the administration client:

* Make sure no users have duplicate email addresses:

![duplicate -screenshot][img2]

* Make sure all the users who should have access to SuperOffice Online have a license & a valid email address
* Make sure there are no users currently on Travel
* Make sure that you do not use SuperOffice Satellite and have active satellites

## Start OMT

The SuperOffice CRM Online Migration Tool (OMT) is responsible for transferring a local onsite database and document archive to CRM Online. It also makes sure that a set of initial configuration steps are carried out.

The OMT can be executed in one of 2 basic modes:  Initial upload or recovery mode.

The OMT will automatically determine the mode when it starts.

![1.png -screenshot][img6]

The first step of the OMT is to log on to the local CRM onsite database.  The OMT will try to find a local windows installation.  It will then use that configuration and prompt the user with a username and password.  This must be the credentials of a local administrator (User or General Admin) in the CRM Database.

 ![2.png -screenshot][img7]

Contact details of the person performing the migration must be provided. These are the contact details used during the migration process.

 ![3.png -screenshot][img8]

All users that shall log in to the migrated customer tenant in SuperOffice CRM Online must have a valid user license.  They must also have a valid email address for logging in.  This email address must be unique. No other user can have the same email address as such conflict will prevent successful logins to the system.

Both user plans and email address user names must be validated by the migrator before the customer can be migrated to online.

 ![4.png -screenshot][img9]

A new window is shown when the user clicks Check user plans. The objective of this window is to ensure that all users that should have a valid user plan for log-in, have this.

Each column represents a user plan.  The first column represents no user plan and users in this column are not allowed to log in.  At least one administrator must have a valid user plan.  Administrators are tagged with a golden crown.

 ![5.png -screenshot][img10]

Drag the user to the correct column to choose a user plan.  Write a filter-criteria to easier find a particular user or group of users.  All fields shown on the card are used in the free-text filter.  Filtering on the name of user-group or position can be an efficient way of working with many users.

 ![6.png -screenshot][img11]

Click OK when licenses are assigned.  It is possible to come back to re-assign licenses after the other configuration steps are performed as well.

A valid email address must be selected as a user name.  All users must have a unique email address.  Select one of the users existing email addresses or write a new address as appropriate.

 ![blobid7.png -screenshot][img12]

If another user has a username email address populated on their person card at the time of migration, it will be removed.

Filtering works the same way as on the user plan assignment page.

 ![blobid8.png -screenshot][img13]

Click OK when all users are assigned a valid user name email address.

![blobid9.png -screenshot][img14]

Continuing the wizard will upload database and documents SuperOffice CRM Online.

It is quite common that some documents are missing during the time of migration. When the documents are found, they can be put into the document archive and uploaded again.  Restarting the OMT will initiate the recovery process, uploading missing document files.

![blobid10.png -screenshot][img15]

Log on to the local database in the same way as a regular migration.

![blobid11.png -screenshot][img16]

Missing documents will then be uploaded.

![blobid12.png -screenshot][img17]

Close the OMT when the client-side of migration has been completed.

![blobid13.png -screenshot][img18]

<!-- Referenced links -->
[1]: http://online.superoffice.com/appstore
[3]: ../../service/mailboxes/migrate.md

<!-- Referenced images -->
[img2]: media/mig-proc-duplicate.jpg
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
