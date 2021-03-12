---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: custom_app       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: About custom apps for SuperOffice CRM Online # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: private app
so.topic: concept          # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud               # cloud or onsite
so.client: online             # online, web, win, pocket, or mobile
---

# Custom apps for SuperOffice CRM Online

Custom applications are one-off customizations for your company or a customer's company only. These are not available in the SuperOffice App Store.

A custom application can be the solution when your needs as a SuperOffice CRM Online customer are not met using either:

* the standard configurations available in SuperOffice Settings and maintenance, or
* a standard application available in the App Store

As long as the application is specific to you, unique to your business, we call it a custom application. In contrast to [standard applications][2], each custom application is mapped to a specific [database tenant][3].

All applications begin in our [sandbox environment][4]. Custom applications must [pass our validation process][5]. We test that things work the way they should and don't affect other customers in any way. After that, you may [activate][6] your application on your production environment tenant.

## Your options with custom applications

Custom applications require a subscription to [Expander Services][7] to get access to the necessary tools and APIs. With this toolbox, you can:

* Add extra tables to customize Service
* Create custom screens to fit your specific processes
* Create tailored workflows and automation with CRMScript
* Create custom integrations that link your SuperOffice CRM Online solution with another system
  * either a totally new integration to a solution you currently use and that is specific to you
  * or a customized version of a standard application available in the App Store

Also, you can make extra tables and custom screens available to users of the Sales and Marketing [user plans][8] through web panels.

When it is time to develop your application idea, you have 3 options:

* Build the application yourself
* Ask a SuperOffice partner for help to create a customization
* Ask a vendor to create a tailored version of a standard application for you

<!-- Referenced links -->
[2]: standard.md
[3]: tenant-status/index.md
[4]: app-envir.md
[5]: validation/index.md
[6]: activate-custom-app.md
[7]: ../license/expander-services/index.md
[8]: ../license/user-plans.md
