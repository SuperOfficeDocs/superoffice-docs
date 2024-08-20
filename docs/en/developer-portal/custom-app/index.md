---
title: Custom applications
uid: custom-app
description: About custom apps for SuperOffice CRM Online
author: Margrethe Romnes
date: 09.07.2023
keywords: private app, custom app
topic: concept
envir: cloud
client: online
---

# Custom apps for SuperOffice CRM Online

Custom applications are one-off customizations for your company or a customer's company only. These are not available in the SuperOffice App Store.

A custom application can be the solution when your needs as a SuperOffice CRM Online customer are not met using either:

* The standard configurations available in SuperOffice Settings and maintenance
* Or, a standard application available in the App Store.

As long as the application is specific to you, unique to your business, we call it a custom application. In contrast to [standard applications][2], each custom application is mapped to a specific [database tenant][3].

All applications begin in our [sandbox environment][4]. We require all custom applications to pass a set of validation tests before they are activated. Specifically, that things work the way they should and don't affect other customers in any way. After that, the application is activated on your production environment tenant.

## Your options with custom applications

Custom applications require a subscription to [Development Tools][7] (formerly Expander Services) to get access to the necessary tools and APIs. With this toolbox, you can:

* Add extra tables to customize Service
* Create custom screens to fit your specific processes
* Create tailored workflows and automation with CRMScript
* Create custom integrations that link your SuperOffice CRM Online solution with another system
  * Either a **new** integration to a solution you currently use and that is specific to you.
  * Or, a **customized version** of a standard application available in the App Store.

Also, you can make extra tables and custom screens available to users of the Sales and Marketing [user plans][8] through web panels.

When it is time to develop your application idea, you have 3 options:

* Build the application yourself
* Ask a SuperOffice partner for help to create a customization
* Ask a vendor to create a tailored version of a standard application for you

## <a id="validate"></a>About our validation process for custom apps

Unlike standard applications, custom applications don't have to go through certification and Watchcom security testing. Instead, we do light-weight testing called **validation**.

We run the validation tests in [SOD][4] before we deploy your application to a production environment. These tests are **free of charge**.

## Why do you test my one-off customization?

The purpose of our validation tests is to ensure that the application can be safely activated in SuperOffice CRM Online.

## What are you checking?

We install your application and want to see that it runs smoothly and [adheres to our requirements][1]. **Security** and **performance** are particularly important.

We are checking logs in Application Insight and our Operation Center.

## I'm ready - what do I do?

Follow our [step-by-step guide][5], started by sending a request to publish in the Developer Portal.

<!-- Referenced links -->
[2]: ../standard-app/index.md
[1]: ../standard-app/requirements/index.md
[3]: ../getting-started/index.md#tenant
[4]: ../getting-started/app-envir.md
[5]: validate.md
[7]: ../../admin/license/expander-services/index.md
[8]: ../../admin/license/user-plans.md
