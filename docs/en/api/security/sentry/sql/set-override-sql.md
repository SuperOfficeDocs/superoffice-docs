---
title: Setting data-rights with sentry and user-preferences - SQL
uid: override_sentry_sql
description: Setting data-rights with sentry and userpreferences SQL
author: {github-id}
so.date: 02.06.2007
keywords:
so.topic: howto
so.envir: onsite
# so.client:
---

# Setting data-rights with sentry and user-preferences - SQL

When you override sentry, you add new records to the [UserPreference table][1]. This example will override the sentry so the SuperOffice user with `associate_id=42` is no longer able to edit the address of existing contacts:

`Maxlevel` and `deflevel` are set to 5 and `owner_id` to the `associate_id`

> [!NOTE]
> The user can still enter addresses on new contacts since the preference only restricts **existing** contact records.

```SQL
insert into userpreference (userpreference_id,deflevel,maxlevel,owner_id,prefsection,prefkey,prefvalue,registered,
registered_associate_id,updated,updated_associate_id,updatedCount) values (2,5,5,42,'Rights-contact-Existing','Address.Address1','1,Tooltip',0,0,0,0,0)

insert into userpreference (userpreference_id,deflevel,maxlevel,owner_id,prefsection,prefkey,prefvalue,registered,
registered_associate_id,updated,updated_associate_id,updatedCount) values (3,5,5,42,'Rights-contact-Existing','Address.Address2','1,Tooltip',0,0,0,0,0)

insert into userpreference (userpreference_id,deflevel,maxlevel,owner_id,prefsection,prefkey,prefvalue,registered,
registered_associate_id,updated,updated_associate_id,updatedCount) values (4,5,5,42,'Rights-contact-Existing','Address.Address3','1,Tooltip',0,0,0,0,0)

insert into userpreference (userpreference_id,deflevel,maxlevel,owner_id,prefsection,prefkey,prefvalue,registered,
registered_associate_id,updated,updated_associate_id,updatedCount) values (5,5,5,42,'Rights-contact-Existing','Address.City','1,Tooltip',0,0,0,0,0)

insert into userpreference (userpreference_id,deflevel,maxlevel,owner_id,prefsection,prefkey,prefvalue,registered,
registered_associate_id,updated,updated_associate_id,updatedCount) values (6,5,5,42,'Rights-contact-Existing','Address.ZipCode','1,Tooltip',0,0,0,0,0)

insert into userpreference (userpreference_id,deflevel,maxlevel,owner_id,prefsection,prefkey,prefvalue,registered,
registered_associate_id,updated,updated_associate_id,updatedCount) values (7,5,5,42,'Rights-contact-Existing','Address.State','1,Tooltip',0,0,0,0,0)

insert into userpreference (userpreference_id,deflevel,maxlevel,owner_id,prefsection,prefkey,prefvalue,registered,
registered_associate_id,updated,updated_associate_id,updatedCount) values (8,5,5,42,'Rights-contact-Existing','Address.County','1,Tooltip',0,0,0,0,0)
```

> [!NOTE]
> The number in red (`userpreference_id`) has to be updated to a free number in the next unallocated number in the `userpreference` table.

<!-- Referenced links -->
[1]: ../../../../database/tables/userpreference.md
