---
title: First-time activation
uid: custom-app-first-time-activation
description: Description of the process of activating a valid custom application for the first-time.
author: Margrethe
date: 12.20.2023
keywords: activate, consent
topic: howto
envir: cloud
client: online
---

# First-time activation

Congratulations, your custom application is ready!

By activating a custom application, the owner of the tenant agrees to [subscribe to Development Tools][2] (formerly Expander Services).

## First-time activation

The first-time activation starts after your [application passes validation][1]. You don't need to trigger this step.

1. We will publish your application from SOD to the production environment.
2. The user currently signed in to the Developer Portal will receive an automatic email asking for the customer name and customer ID in CRM Online. This is found under **Help** > **About** when signed in to `online.superoffice.com`.
    If you as the application developer is not an employee of the customer, please forward this email to the customer and have them confirm to us that they want us to activate this application on their tenant (SuperOffice installation).
3. Wait for confirmation from the SuperOffice app manager that the application has consent to access the tenant.
4. You contact the customer to initiate the [application setup][3].

## Production sandbox

If you use a [production sandbox][6] to develop and test a custom app, with real data, the app must be **activated twice** - once per production environment.

1. Request to publish the app's configuration to stage (first-time activation) and **send us the customer ID of the production sandbox**.
1. When the customer is ready to launch the approved application on their production tenant, **reply to the ticket** received when the request to publish was submitted. The customer's administrator must confirm they want us to activate this application on their live tenant too.

## Request application changes

You can [change the application configuration][5] in the Developer Portal.

<!-- Referenced links -->
[1]: validate.md
[2]: ../../admin/license/expander-services/index.md
[3]: ../provisioning/index.md
[5]: ../faq/update-app.md
[6]: ../../online/sandbox/index.md
