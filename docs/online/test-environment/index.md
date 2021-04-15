---
title: Introduction
uid: test_envir
description: SuperOffice test environment
author: {github-id}
keywords:
so.topic: concept
so.envir: cloud
so.client: online
---

# Test environment

Customers and partners can buy their own test tenant in production based on a copy of their production data.

The test [tenant][1] may be replaced with a [newer copy][2] of their production database after the initial setup.

To buy your own test environment, please contact your local sales representative. The initial setup is handled by SuperOffice AS/Online Operation.

> [!TIP]
> You don't need the same amount of [user plans][3] in the test environment. We assume most will have just a few test users or developers with access to the test tenant.

The test environment is a **dead end**. We will not make it possible to migrate data back into the production environment from this test environment.

> [!CAUTION]
> **The production test environment is not a backup!** We will clean up the copied production database and also remove all mailboxes used by Service there.

## Is the test environment identical to production?

Yes, almost. All the customer data, like company, contact, sale, and project are there, but when we copied your production database into the test environment we removed some personal information.

* We removed all login information and emails from email accounts set up by your users that use the SuperOffice inbox.

* We also removed all email account set up to use with Service and created a new for this environment only.

* We close any open ticket in Service.

* Any web panel referring to Service functionality using full path like *online**X**.superoffice.com/custXXX/CS/Scripts/xxxx* has been replaced with a template variable:
  * csti - URL to *ticket.fcgi*
  * csrm - URL to *rms.fcgi*
  * cscu - URL to *customer.fcgi*
  * csbl - URL to *blogic.fcgi*

![imageu533bo.png][img12]

* All scheduled tasks have been marked as disabled unless you chose to enable them in the wizard
* Also - any SuperOffice App Store app that was authorized on your production database will not work in the test environment and you will have to sign up again if you want to use it in the test environment. The authorization/approval for the app to access a specific installation is a one-to-one link.

If you have ERP sync apps in production you should log in to Settings and Maintenance and turn off automatic syncing. Since these apps are not authorized on the test tenant it will not sync, just generate errors.

![imagemvheo.png][img13]

> [!NOTE]
> Any data that was created by the app will still be in your test environment, like the web panels that were automatically set up by the app. You may hide them in the test environment admin under.

[Lists - GUI Web panel][1]

## Community users and your test database

We are aware that some use their SuperOffice production serial number on more than one database, and if you are one of those please read on.

Each SuperOffice database sends information to us, that is both Onsite from version 8.0 and CRM Online, as part of our Terms of Service. This is both statistical and user information, and by clicking **Accept** on this dialog, we regularly receive information from your database regarding users and use.

![x][img1]

When this is accepted, we will be updated if you for example retire an associate in your database. Now, if this is the production database and a real user that has been marked as retired, then this is OK. On the other hand, if you have made a copy of your production database, and as a test delete all users or several users, then this will affect you and your colleagues’ login to this community.

Also, we gather user statistics, this is information like how many rows are there in the contact table, appointment table, sale table and so on, giving us an indication on how our customers use our product (not what they store in it) and it helps us make our products even better. But for the statistics to be useful we only want it from the production database where it is in real use, and not from your test database.

> [!CAUTION]
> So, if you choose to copy your production database and this addendum is accepted, then each test installation must turn off the **Statistics OptIn - Configured** and **UserSync OptIn - Configured**.

To turn off these settings, set both preferences to **No**.

![x][img2]

<!-- Referenced links -->
[1]: https://community.superoffice.com/documentation/help/en/crm/9.2/webhelpadmin/index.htm#t=chap08%2FWebpanel.htm&rhsearch=web%20panel&rhsyns=%20
[2]: replace.md
[3]: ../../license/user-plans.md

<!-- Referenced images -->
[img1]: media/13062-28350.jpg
[img2]: media/13063-28352.jpg
[img12]: media/imageu533bo.png
[img13]: media/imagemvheo.png
