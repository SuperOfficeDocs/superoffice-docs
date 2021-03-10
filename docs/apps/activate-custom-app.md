---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: activate_custom_app       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Activate custom application # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Activate a custom application

Congratulations, your custom application is ready!

## Pre-requisites

* Your custom application has [passed validation][1].

By activating a custom application, the owner of the tenant agrees to [subscribe to Expander Services][2].

## First-time activation

The first-time activation is usually initiated by the application developer.

1. We will move your application from SOD to the production environment.
2. You contact the customer to initiate the [application setup][3].
3. The customer's administrator must sign in to SuperOffice and [give their consent][4] to allow your application to access their database tenant.

## Activate on additional tenants

In some special cases, we allow one-off applications to be used by multiple production tenants. For example:

* The application was developed on a test-tenant in the production environment and is ready to go live
* The application will be used by multiple subsidiaries within the same company

This is usually initiated by the customer.

**Process:**

1. [Submit an activation request][5] (form).
2. Repeat [application set-up][3] on the new tenant.
3. As an administrator, sign in to SuperOffice and [give consent][4] to this specific tenant.

<!-- Referenced links -->
[1]: validation/validate-app.md
[2]: ../license/expander-services/index.md
[3]: provisioning.md
[4]: consent.md
[5]: https://community.superoffice.com/en/developer/create-apps/resources/activate-custom-application/
