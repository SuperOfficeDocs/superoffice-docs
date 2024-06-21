---
uid: omt-migration-guide
title: Migration guide
description: Migrate to SuperOffice CRM Online
keywords: migrate, Online Migration Tool, OMT
author: Frode, Bergfrid Dias, David H
date: 03.21.2024
topic: guide
envir: onsite, online
# client:
---

# Migrate to SuperOffice CRM Online

If you want to migrate to SuperOffice CRM Online you should contact your SuperOffice sales person, who will help you start the process.

The migration process must be initiated by your SupeOffice sales representative since all migrations will involve SuperOffice Online Operations. The sales representative will enlist a responsible technical consultant (migrator) that will execute the migration.

> [!CAUTION]
> If you have customizations or integrations, these may not be working after the migration. Check with the customization or integration developer if they have this available for CRM Online too, or check if the [App Store][1] has an app you may use instead.

If you have Customer Service and want to migrate your data to our cloud, you need to [adjust email service][3].

## Downtime during migration

You will have some downtime during the migration, the time depends on how large the database and document archive is.

## Before you migrate

> [!TIP]
> Worried something might go wrong? We know that migrating to CRM Online for our more advanced customers may be a longer journey. We strongly recommend you contact your SuperOffice sales person and consider our **extended migration services**.

If you plan to use identify provider for the authentication, we recommend to [register the customer domain name][4] before doing the migration, so that users can immediately login using IDP and you don't need to do any user-transition later.

### .Net Framework version

.NET Framework 4.7.2 or higher installed (to run the SuperOffice CRM Online Migration Tool (OMT))

### Your onsite SuperOffice version

You need to be on at least SuperOffice 7.1 to migrate to CRM Online. If you run an older version of SuperOffice than 7.1, then an upgrade must be performed first.

### SuperOffice Admin check

The migrator needs access to the SuperOffice Admin client with a user with SuperOffice administrative rights.

**Before migrating you will need to go through the following steps in the administration client:**

* Make sure no users have duplicate email addresses:

![duplicate -screenshot][img2]

* Make sure all the users who should have access to SuperOffice CRM Online have a license and a valid email address
* Make sure there are no users currently on Travel
* Make sure that you do not use SuperOffice Satellite and have active satellites

### SuperOffice database check

* Make sure to remove references to 'SentryAddonNames' in the Userpreference table.

## Start Online Migration Tool

The SuperOffice CRM Online Migration Tool (OMT) is responsible for transferring a local onsite database and document archive to CRM Online. It also makes sure that a set of initial configuration steps is carried out.

 OMT needs access to SuperOffice installation - database, so_arc folder, Service folders.

> [!CAUTION]
>
> When the upload/migration is started, users are prevented from logging into SuperOffice Service and SuperOffice Windows App. This behavior is the result of OMT adding "Frozen" to Service config file and setting "no-login" System Event for SuperOffice Windows. However, it does not affect SuperOffice Web users, they can still log in. They should not update any info until the process is complete.
>
> **Do NOT change the license** (company name or serial number) after starting OMT - either a test or in production. Changing the license before the production migration process is complete will stop OMT (even between runs!), and you will be **unable to resume migration**. If this happens, you will see this message: "ApplicationException: Unable to resume migration session because company name or serialnumber has changed".

The OMT can be executed in one of 2 modes: Initial upload or Recovery mode. It will automatically determine the mode when it starts.

### Initial upload

![1-welcome.png -screenshot][img6]

The first step of the OMT is to log on to the local CRM Onsite database. The OMT will try to find a local SuperOffice Win installation. It will then use that configuration and prompt the user with a username and password. This must be the credentials of a local administrator (User or General Admin) in the CRM Database.

![2-login.png -screenshot][img7]

Contact details of the person performing the migration must be provided. These are the contact details used during the migration process.

![3-confirm.png -screenshot][img8]

All users that shall log in to the migrated customer tenant in SuperOffice CRM Online must have a valid user license. They must also have a valid email address for logging in. This email address must be unique. No other user can have the same email address as such conflict will prevent successful logins to the system.

Both user plans and user names must be validated by the migrator before the customer can be migrated to online.

#### Test Migration

Ticking the **Test Migration** checkbox will have the following consequences:

* Your onsite installation will not be touched (stopped for logging) and its license will not be changed. Users will be able to log in to Onsite while performing test migrations.
* It does not create a [production sandbox environment][2], this has to be ordered separately.
* Tenant will be left in *offlinemaintenance* mode. It can be cloned in to a production sandbox for log in and testing.
* Users cannot log in to it.
* It will leave the tenant in a state that allows you to perform the test migration several times without involvement from Online Operations. With the sandbox you can verify that changes made Onsite are correctly transferred to Online.
* Each test migration will completely delete the current migrated database, all SuperId users and any app authorizations on the tenant. This is why we do not allow users to log in to this tenant before it is actually a live migration.

> [!WARNING]
> Once you run OMT with the **Test Migration** checkbox unticked (live migration), the tenant will be set to a *running* mode after a migration is completed and accepted.
>
> After live migration where users have been allowed to log in and the migration is marked as complete, you **cannot** run the OMT again on this tenant.

![4-checklist-start.png -screenshot][img9]

A new window is shown when the migrator clicks **Check user plans**. The objective of this window is to ensure that all users that should have a valid user plan for log-in, have this.

Each column represents a user plan. The first column represents no user plan and users in this column are not allowed to log in. At least one administrator must have a valid user plan. Administrators are tagged with a golden crown.

![5-user-plans.png -screenshot][img10]

Drag the user to the correct column to choose a user plan. Write a filter-criteria to easier find a particular user or group of users. All fields shown on the card are used in the free-text filter. Filtering on the name of user-group or position can be an efficient way of working with many users.

Click OK when licenses are assigned. It is possible to come back to re-assign licenses after the other configuration steps are performed as well.

A valid email address must be selected as a user name. All users must have a unique email address. Select one of the user's existing email addresses or write a new address as appropriate.

![6-usernames.png -screenshot][img11]

In case there are duplicated usernames, the duplications need to be resolved before you are allowed to continue.

![6a-usernames-duplication.png -screenshot][img12]

Filtering works the same way as on the user plan assignment page.

Click OK when all users are assigned a valid user name email address.

The last step of the checklist is to choose if users should get a welcome email and if you want to receive user summary.

![7-welcome-email.png -screenshot][img13]

After the checklist is completed, you can proceed to the data upload.

![8-checklist-completed.png -screenshot][img14]

Continuing the wizard will upload database and documents to SuperOffice CRM Online.

![9-upload-progress.png -screenshot][img15]

![10-upload-progress2.png -screenshot][img16]

Close the OMT when the client-side of migration has been completed.

![11-complete.png -screenshot][img17]

### Recovery upload

It is quite common that some documents are missing during the time of migration. When the documents are found, they can be put into the document archive and uploaded again. Restarting the OMT will initiate the recovery process.

You can choose from 2 options:

* **Upload missing files** - this option will upload missing or changed documents only. The CRM Online database will be intact.

* **Overwrite existing test migration** - if you ticked the **Test Migration** checkbox on the **Confirm** page, this option will upload a fresh copy of the database and new or updated documents. Existing unchanged documents will not be overwritten saving the migration time.

![22-recovery.png -screenshot][img18]

## Migration log file

A log file of the migration is written to *%temp%\SoMigration* folder.

<!-- Referenced links -->
[1]: http://online.superoffice.com/appstore
[2]: ../sandbox/index.md
[3]: ../../email/service/migrate.md
[4]: ../../identity-management/superid/howto/register-idp.md

<!-- Referenced images -->
[img2]: media/mig-proc-duplicate.jpg
[img6]: media/1-welcome.png
[img7]: media/2-login.png
[img8]: media/3-confirm.png
[img9]: media/4-checklist-start.png
[img10]: media/5-user-plans.png
[img11]: media/6-usernames.png
[img12]: media/6a-usernames-duplication.png
[img13]: media/7-welcome-email.png
[img14]: media/8-checklist-completed.png
[img15]: media/9-upload-progress.png
[img16]: media/10-upload-progress2.png
[img17]: media/11-complete.png
[img18]: media/22-recovery.png
