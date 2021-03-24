---
title: add_user_preferences
description: Add your own user preferences
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: howto

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Add your own preferences

It's possible to add your own preferences to the database so they appear as they were built in. See the [PrefDesc table][1] info for values needed.

| ValueType | Description |
|-----------|-------------|
| 4 | It would find a list of the allowed values in `PrefDescLine` with the `prefdescline.prefdesc_id=prefdesc.prefdesc_id`|
| 5 | maxvalue points to the table number of the list in question. Like 2 for associate |
| 0 | A heading, like if you want to add your own preference section named "My own preference" preferences, you add the following (use HakonClient to insert) |

```SQL
insert into prefdesc (prefsection, prefkey, name, valuetype, maxlevel, sysmaxlevel, accessflags, description) values ('My_own_preference','.', 'US:"My own preference";NO:"Min egen preferanse"', 0, 5, 5, 15, 'US:"The heading only translated to English and Norwegian";NO:"Overskriften - kun oversatt til engelsk og norsk"') 

insert into prefdesc (prefsection, prefkey, name, valuetype, maxlevel, sysmaxlevel, accessflags, description) values ('My_own_preference', 'My system preference', 'US:"My system preference";NO:"My system preferanse"', 7, 2, 2, 7, 'US:"Preference only visible in admin and only possible to set for system(contact_id)";NO:"Preferanse som kun er synlig i admin og kun kan settes for hele systemet (contact_id)"') 

insert into prefdesc (prefsection, prefkey, name, valuetype, maxlevel, sysmaxlevel, accessflags, description) values ('My_own_preference', 'My client preference', 'US:"My client preference";NO:"Min klient preferanse"', 1, 5, 5, 15, 'US:"Preference visible in GUI, may be set by each user (number)";NO:"Synlig i klienten og kan settes pr bruker(nummer)"') 
```

![x][img1]

**Accessflags** here is what makes it appear in the different clients.

So, if `accessflags = 15`, then it should appear in (wizardmode)1 + (General admin) 2 +  (admin client) 4 + (CRM client) 8

These are the preferences in SOAdmin:

![x][img2]

And in the client:

![x][img3]

<!-- Referenced links -->
[1]: https://github.com/SuperOfficeDocs/database/blob/main/docs/tables/prefdesc.md

<!-- Referenced images -->
[img1]: media/prefdesc.jpg
[img2]: media/prefadmin.jpg
[img3]: media/prefclient.jpg
