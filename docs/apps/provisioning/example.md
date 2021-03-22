---
title: provisioning_example
description: Example provisioning
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so.topic: article               # article, howto, reference, concept, guide
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Example: provisioning

This example was presented at Expander World 2016.

1. A customer sees your application in the App Store and would like to know more.
2. They click the **Sign up** button and is forwarded to your website where they may read more and select to either **Try** or **Buy** your application.
    * This page should explain what your application does and what will happen when the customer chooses to try or buy, that way they don't have to approve anything before they know what happens.
3. When **Try** or **Buy** is clicked, a small application (called SuperPartner Connect in this video) may be used that will ask the customer access to read contact information from their CRM Online tenant which you may use to automatically fill out the information you need to provision.
    * This way the customer does not have to fill out information like their company name, address, and so on.
4. When you have the information you need, then the **Try or buy** button will call the application's authorize dialog.
5. When the customer clicks **Approve** it should automatically set up your app for the customer. Do remember to make sure visibility of example web panels is set to **Everyone**.

![x][img1]

See also the full presentation from Expander world 2016 here: [Online Application Lifecycle presentation][1].

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/content/resources/expander-world-resources/expander-world-2016/

<!-- Referenced images -->
[img1]: media/appstoreprovisioning.png
