---
uid: travel_number_allocation
title: Travel number allocation
description: Travel number allocation
author: SuperOffice Product and Engineering
keywords:
date:
content_type: concept
deployment: onsite
platform: win
---

# Travel number allocation

This article explains how number allocations increment when a user goes on travel.

Let's assume we are using a new database where no one has been on travel.

When the first person goes on travel, that person will be assigned the base travel number allocation series, 250000.

The second person that goes on travel, assuming the first person is still on travel, will be assigned the base number allocation series plus the increment amount set in the number allocation tab in admin (default 50000). For those who are keeping track, that would be 300000.

The third person that goes on travel, again assuming that both the first and second person are still on travel, will be assigned the base number, plus the previously allocated number slot, plus the increment amount defined in the number allocation tab in admin.  For those who are keeping track, that would be 350000.

This cycle of allocation continues until one person on travel returns.

For example, lets’ say just before the fourth person going on travel the first person returns and completes a central update. In that case, the 250000 allocation series is available again and assigned to the fourth person.

To summarize: when someone goes on travel, the number allocation series assigned to that person depends on if there was a previously assigned, but now available, number allocation series or not. If there was a previously assigned series but has since become available due to a central update, then the next person going on travel will get that previously assigned but now available series.

Now, lets’ look at it more closely.

When a user on travel has been assigned the 250000 number allocation series and uses it to create a contact, where does SuperOffice store the value? How does SuperOffice know what the next number for that number allocation series will be when a new user takes over that range? Oh yes, in the `NUserpreference` table!

Among others, the `UserPreference` table contains the `prefsection`, `prefkey`, and `prefvalue` columns.

| Column | | Number allocation | Description |
|---|---|---|
| prefsection | System | used to store related information, like groups |
| prefkey | Counter-XXXXX-X-XXXXXXX | points to a specific place or item |
| prefvalue | XXXXXXX | used to actually store the next value |

The most interesting column is `prefkey`. It can be split up and defined as 4 parts separated by hyphens:

* **Counter-**XXXXX-X-XXXXXXX

  The first field part is appropriately named, it keeps count.

* Counter-**XXXXX**-X-XXXXXXX

  Defines what table number column the counter is used. For example, the contact number1 or number2 column. Each entity number column has a unique number that correlates to the column field ID. Mathematically, that is: ((table number \* 256) + column index).

* Counter-XXXXX-**X**-XXXXXXX

  Only used for documents, and defines the template ID. Documents can have the same number allocation for all document templates or can have a different number allocation for each document template.

  Represents the `doctmpl_id` (document tempate table ID), otherwise, it is 0, for all document templates.

* Counter-XXXXX -X-**XXXXXXX**

  Here is where the fun part begins. The forth and final field part is the travel number allocation series this entry belongs to. The lowest number you'll find here is 250000.

So now you’re probably wondering where the next number for the number allocation series used on travel is, right?

Scroll back and look at the table again. PREFVALUE, OK, so there you have it! Here’s an actual value example.

* `Prefsection` = System
* `PrefKey`= Counter-1285-0-250000
* `Prefvalue` = 250025

The above is the counter for a contact with the number allocation series 250000. The next contact ID assigned from this number allocation series, by a person on travel, will be 250025.
