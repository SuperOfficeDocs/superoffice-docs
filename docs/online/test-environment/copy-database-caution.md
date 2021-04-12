---
title: copy_database_caution
description: Community users and your test database
author: Margrethe Romnes
so.date:  10.31.2017
keywords:
so.topic: concept

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Community users and your test database

Those of you attending Expander World 2017, most likely heard our warnings about copying your production database into a test environment, but here is a short recap.

We are aware that some use their SuperOffice production serial number on more than one database, and if you are one of those please read the rest of this blog post.

Each SuperOffice database sends information to us, that is both On-site from version 8.0 and CRM Online, as part of our Terms of Service. This is both statistical and user information, and by clicking **Accept** on this dialog, we regularly receive information from your database regarding users and use.

![x][img1]

When this is accepted, we will be updated if you e.g retire an associate in your database. Now, if this is the production database and a real user that has been marked as retired, then this is ok. On the other hand, if you have made a copy of your production database, and as a test delete all users or several users, then this will affect you and your colleagues’ login to this community.

Also, we gather user statistics, this is information like how many rows are there in the contact-table, appointment-table, sale-table and so on, giving us an indication on how our customer's user our product (not what they store in it) and it helps us make our products even better. But for the statistics to be useful we only want it from the production database where it is in real use, and not from your test database.

> [!CAUTION]
> So, if you (now completely ignoring the upcoming GDPR and personal data...) choose to copy your production database and this addendum is accepted, then each test installation must turn off the **Statistics OptIn - Configured** and **UserSync OptIn - Configured****.**

To turn off these settings, set both preferences to **No**.

![x][img2]

<!-- Referenced images -->
[img1]: media/13062-28350.jpg
[img2]: media/13063-28352.jpg
