---
title: Production sandbox (test environment)
uid: prod-sandbox
description: SuperOffice production sandbox
author: Bergfrid Dias
so.date: 12.06.2021
keywords: sandbox, production sandbox environment, test environment
so.topic: concept
so.envir: cloud
so.client: online
---

# CRM Online production sandbox (test environment)

Customers and partners can buy their own **CRM Online sandbox (test) tenant in production based on a copy** of their production data.

## What is a production sandbox?

This **sandbox** provides you with a copy of your company’s database, including configuration and data, which you can then test, explore new configurations, new apps, and integrations as well as use for training purposes without the risk of disturbing your current use of SuperOffice CRM. It gives you a controlled environment to ensure that your CRM strategy and plans can be optimized before you onboard your users.

The production sandbox is a **dead end**. No round-tripping. We will not make it possible to migrate data back into the production environment from the sandbox.

> [!CAUTION]
> **The production sandbox is not a backup!** We will clean up the copied production database and also remove all mailboxes used by Service there. [See all steps][5].

## How do I get one?

To buy your own CRM Online production sandbox, please contact your local sales representative or fill in [this form][4]. The initial setup is handled by SuperOffice AS/Online Operation.

> [!TIP]
> You don't need the same amount of [user plans][3] in the sandbox. It is entirely up to you how many and the type of plans you add. We assume most will have just a few test users or developers with access to it.

The sandbox can be [overwritten with a newer copy][2] after the initial setup. Regular updates of your data are included in the subscription.

## Is the sandbox identical to production?

Yes, almost. All the customer data, such as company, contact, sale, and project are there. However, when we copied your production database we removed some personal information.

* We removed all login information and emails from email accounts set up by your users that use the SuperOffice inbox.

* We also removed all email account set up to use with Service and created a new one for this environment only.

* We closed any open ticket in Service.

* Any web panel referring to Service functionality using full path like *online**X**.superoffice.com/custXXX/CS/Scripts/xxxx* was replaced with a template variable:

    ![imageu533bo.png -screenshot][img12]

  * csti - URL to *ticket.fcgi*
  * csrm - URL to *rms.fcgi*
  * cscu - URL to *customer.fcgi*
  * csbl - URL to *blogic.fcgi*

* All scheduled tasks have been marked as disabled unless you chose to enable them in the wizard.

* Any SuperOffice App Store app that was authorized on your production database will not work in the sandbox and you will have to sign up again if you want to use it here. The authorization/approval for the app to access a specific installation is a one-to-one link.

* [See all steps][5]

## Best practices

> [!NOTE]
> Any data that was created by the app will still be in your sandbox, like the web panels that were automatically set up by the app. To  hide them, go to [Lists - GUI Web panel][1] in Settings and Maintenance.

* Turn off **Statistics OptIn - Configured** and **UserSync OptIn - Configured** (see below).

* If you have **ERP sync apps** in production, you should log in to Settings and Maintenance and turn off automatic syncing. Since these apps are not authorized on the sandbox it will not sync, just generate errors.

    ![Turn off auto sync -screenshot][img13]

* Turn off scheduled task scripts when you're not working.

* If you plan to test a partner app, ask them ahead of time if the app supports authenticating against multiple tenants.

## Community users and your test database (Onsite installation only)

> [!NOTE]
> This section only applies to Onsite installations.

We are aware that some Onsite installations use their SuperOffice production serial number on more than one database, and if you are one of those please read on.

Each SuperOffice database sends information to us, that is both Onsite from version 8.0 and CRM Online, as part of our Terms of Service. This is both statistical and user information, and by clicking **Accept** on this dialog, we regularly receive information from your database regarding users and use.

![Terms of service -screenshot][img1]

When this is accepted, we will be updated if you for example retire an associate in your database. Now, if this is the production database and a real user that has been marked as retired, then this is OK. On the other hand, if you have made a copy of your production database, and as a test delete all users or several users, then this will affect you and your colleagues’ login to this community.

Also, we gather user statistics, this is information like how many rows are there in the contact table, appointment table, sale table, and so on, giving us an indication of how our customers use our product (not what they store in it) and it helps us make our products even better. But for the statistics to be useful we only want it from the production database where it is in real use, and not from your test database.

> [!CAUTION]
> So, if you choose to copy your production database and this addendum is accepted, then each sandbox must turn off the **Statistics OptIn - Configured** and **UserSync OptIn - Configured**.

To turn off these settings, set both preferences to **No**.

![Turn off opt-in -screenshot][img2]

<!-- Referenced links -->
[1]: https://help.superoffice.com/Documentation/Help/EN/CRM/WebHelpAdmin/index.htm#t=chap08%2FWebpanel.htm
[2]: replace.md
[3]: ../../admin/license/user-plans.md
[4]: order-sandbox.md
[5]: clone-to.md

<!-- Referenced images -->
[img1]: media/13062-28350.jpg
[img2]: media/13063-28352.jpg
[img12]: media/imageu533bo.png
[img13]: media/imagemvheo.png
