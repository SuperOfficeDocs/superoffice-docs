---
title: Force resync in prod
uid: force_mirroring_resync
description: Force mirroring re-synchronization in a production database
author: SuperOffice Product and Engineering
keywords:
content_type: howto
deployment: online
platform: web
---

# Force mirroring re-sync in a production database

You have set up database mirroring and data was synchronizing as expected, but now it seems to have stopped. What do you do?

There is no GUI to check data in a mirror, so you must use SQL Server Management Studio to inspect the tables. Generally, it should be possible to do `select * from <sometable>` in both the customer table and the mirror and get the same result.

If you notice that some tables are not updating as expected, it might be time to force a resynchronization.

This procedure is intended for a live system.

## Pre-requisites

* your application is registered and has been deployed to the production environment
* you have a publicly available working service
* your application has been [approved by the customer's tenant][2] administrator

## Restart synchronization

1. Using **SQL Server Management Studio**, go to the `<context identifier>_mirroring` database table
2. For each table that you have identified as having a problem, **set LSN  to -1** within the mirroring table.
3. Then truncate the data in the table(s) you set LSN to -1:

    ```sql
    truncate table <tablename>
    ```
4. Shortly thereafter, the [Mirroring Task][3] will send an authentication request, which your client must respond to. After successful authentication, SuperOffice will begin to deliver periodic updates to your mirroring service.

## Hard reset the mirror

1. Using **SQL Server Management Studio**, go to the `<context identifier>_mirroring` database table.
2. For each table you have identified as having problems, let us use contact in this example:

    ```sql
    delete from <context_identifier>_mirroring where tablename = 'contact'
    ```
3. Then **drop table contact**
4. Shortly thereafter (the next mirroring cycle), the [Mirroring Task][3] will send an authentication request, which your client must respond to. After successful authentication, SuperOffice will recreate the database table(s) and begin to deliver periodic updates to your mirroring service.

<!-- Referenced links -->
[2]: ../../developer-portal/provisioning/get-consent.md
[3]: mirroring-task.md
