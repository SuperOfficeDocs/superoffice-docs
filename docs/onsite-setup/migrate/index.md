---
title: migration_guide
description: Migrate to SuperOffice CRM Online
author: {github-id}
keywords:
so.topic: guide 
so.envir: onsite              # cloud or onsite
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

The migrator needs access to SuperOffice administration client with a user with SuperOffice administrative rights.

Before migrating you will need to go through the following steps in the administration client:

* Make sure no users have duplicate email addresses:

![duplicate][img2]

* Make sure all the users who should have access to SuperOffice Online have a license & a valid email address
* Make sure there are no users currently on Travel
* Make sure that you do not use SuperOffice Satellite and have active satellites

## Start

When you are ready, [run the SuperOffice CRM Online Migration Tool (OMT)][2].

<!-- Referenced links -->
[1]: http://online.superoffice.com/appstore
[2]: run-omt.md

<!-- Referenced images -->
[img2]: media/mig-proc-duplicate.jpg
