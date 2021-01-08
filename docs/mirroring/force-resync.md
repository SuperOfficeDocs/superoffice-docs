---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: force_mirroring_resync       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Force mirroring re-sync in production database # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Force mirroring re-sync in a production database

You have set up database mirroring and data was synchronizing as expected, but now it seems to have stopped. What do you do?

There is no GUI to check data in a mirror, so you must use SQL Server Management Studio to inspect the tables. Generally, it should be possible to do `select * from <sometable>` in both the customer table and the mirror, and get the same result.

If you notice that some tables are not updating as expected, it might be time to force a resynchronization.

This procedure is intended for a live system. If you want to debug mirroring in SOD, you can [mock a user installing the application to trigger the Mirroring Task][1].

## Pre-requisites

* your application is registered and has been deployed to the production environment
* you have a publicly available working service
* your application has been [approved by the customer's tenant][2] administrator

## Restart synchronization

1. Using **SQL Server Management Studio**, go to the `<context identifier>_mirroring` database table
2. For each table that you have identified as having a problem, **set LSN  to `-1`** within the mirroring table.
3. Shortly thereafter, the [Mirroring Task][3] will send an authentication request, which your client must respond to. After successful authentication, SuperOffice will begin to deliver periodic updates to your mirroring service.

## Hard reset the mirror

1. Using **SQL Server Management Studio**, drop the `<context identifier>_mirroring` database table.
2. Shortly thereafter (the next mirroring cycle), the [Mirroring Task][3] will send an authentication request, which your client must respond to. After successful authentication, SuperOffice will begin to deliver periodic updates to your mirroring service.

<!-- Referenced links -->
[1]: sync-manually.md
[2]: ../tenants/get-consent.md
[3]: mirroring-task.md
