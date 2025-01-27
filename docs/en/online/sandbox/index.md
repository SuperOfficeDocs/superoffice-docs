---
title: Production sandbox (test environment)
uid: prod-sandbox
description: SuperOffice production sandbox
author: Bergfrid Dias
date: 09.19.2023
keywords: sandbox, production sandbox environment, test environment
topic: concept
envir: cloud
client: online
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

* Any web panel referring to Service functionality using full path like *online**X**.SuperOffice.com/custXXX/CS/Scripts/xxxx* was replaced with a template variable:

    ![imageu533bo.png -screenshot][img12]

  * csti - URL to *ticket.fcgi*
  * csrm - URL to *rms.fcgi*
  * cscu - URL to *customer.fcgi*
  * csbl - URL to *blogic.fcgi*

* All scheduled tasks have been marked as disabled unless you chose to enable them in the wizard.
  
* All webhooks are deleted, this means both of type HTTP POST nofitications and CRMScript.

* Any SuperOffice App Store app that was authorized on your production database will not work in the sandbox and you will have to sign up again if you want to use it here. The authorization/approval for the app to access a specific installation is a one-to-one link.

* [See all steps][5]

## Developing custom app in production sandbox

Because the tenant is in an isolated cluster, a production sandbox is suitable for custom app development and can be treated like a SOD tenant in this regard. Use it to develop and test ideas, with real data.

However, as with any custom application under development, it must be [validated][6] before it gets access to the customer's production tenant. Always keep our [best practices][7] in mind before requesting validation.

When the customer is ready to launch the approved application on their production tenant, use the [Request authorization][9] to start the process.

> [!NOTE]
> To get the app into the production sandbox, sign in to the Developer Portal and [request to publish the app's configuration to stage][8] (then we automatically also publish it to production). Also send us the customer ID of the production sandbox.

## Best practices

> [!NOTE]
> If your sandbox was cloned from an existing and running CRM Online tenant with apps authorized, then data that was created by the apps in the source will still be in your sandbox. Examples would be web panels that were automatically set up by the app. To  hide them, go to [Lists - GUI Web panel][1] in Settings and maintenance.

* If you have **ERP sync apps** in production, you should log in to Settings and maintenance and turn off automatic syncing. Since these apps are not authorized on the sandbox it will not sync, just generate errors.

    ![Turn off auto sync -screenshot][img13]

* Turn off scheduled task scripts when you're not working.

* If you plan to test a partner app, ask them ahead of time if the app supports authenticating against multiple tenants.

<!-- Referenced links -->
[1]: ../../admin/lists/learn/web-panel.md
[3]: ../../admin/license/user-plans.md
[2]: replace.md
[4]: order-sandbox.md
[5]: clone-to.md
[6]: ../../developer-portal/custom-app/validate.md
[7]: ../../developer-portal/best-practices/index.md
[8]: ../../developer-portal/create-app/request-to-publish.md
[9]: ../../developer-portal/tenants/authorization.md

<!-- Referenced images -->
[img12]: media/imageu533bo.png
[img13]: media/imagemvheo.png
