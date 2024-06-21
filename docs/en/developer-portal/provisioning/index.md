---
uid: app-provisioning
title: provisioning
description: "Learn what app provisioning is and the benefits of automating it."
author: Margrethe Romnes
date: 02.02.2022
keywords: provisioning, set-up, apps
topic: concept
envir: cloud
client: online
---

# Provisioning

Applications that compliment SuperOffice with additional functionality generally need to (automatically) set up a presence inside SuperOffice. This initialization step is referred to as provisioning your application in SuperOffice.

## What is provisioning?

When the customer clicks **I approve,** it should automatically set up your application. This is accomplished by a tenant administrator user installing the application and interacting with its provisioning routines:

1. The user successfully signs into SuperID, is then forwarded to the application's installation pages, and the application begins to use the administrative credentials it received from SuperID to access and set up the tenant via the APIs.
2. The application creates whatever it needs to exist and function inside SuperOffice (such as web panels, buttons, lists, and list items).

Provisioning a partner application may involve configuration or settings in both SuperOffice and the other partner service depending on what the application actually does.

## Example (standard app)

1. A customer sees your application in the App Store and would like to know more.

2. They click the **Sign up** button and are forwarded to your website where they may read more and select to either **Try** or **Buy** your application.
    * This page should explain what your application does and what will happen when the customer chooses to try or buy, that way they don't have to approve anything before they know what happens.

3. When **Try** or **Buy** is clicked, a small application (called SuperPartner Connect in this video) may be used that will ask the customer access to read contact information from their CRM Online tenant that you may use to automatically fill out the information you need to provision.
    * This way the customer does not have to fill out information like their company name, address, and so on.

4. When you have the information you need, then the **Try or buy** button will call the application's authorize dialog.

5. When the customer clicks **Approve** it should automatically set up your app for the customer. Do remember to make sure visibility of example web panels is set to **Everyone**.

![x -screenshot][img1]

This example was presented at Expander World 2016.

<!-- See also the full presentation from Expander world 2016 here: [Online Application Lifecycle presentation][1]. -->

## Automatic or manual provisioning?

Provisioning must be as automatic as possible. In some cases, it can include manual instructions with the intent of automating this later.

For example, if the application requires new web panels in the SuperOffice solution, it should ideally create the web panels for the customer during provisioning. The alternative is for the customer to manually follow a set of instructions for how to create these themselves, which will open up for errors.

### Benefits of automation

> [!TIP]
> Automating provisioning improves the customer's experience and is more scalable.

If and when you include instructions, make sure they are as clear and fail-proof as possible (simple recipes that non-technical people can follow).

If you don't offer automatic provisioning from day 1, be prepared to do so soon after.

### Risk when provisioning manually

Manual provisioning might introduce potential errors. You also run the risk of the customer never getting the application going.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/appstoreprovisioning.png
