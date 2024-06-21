---
title: Technical requirements
uid: app-technical-requirements
description: "Technical requirements for certifying standard applications."
author: Margrethe Romnes
date: 02.02.2022
keywords: certification, apps, availability, performance
topic: reference
envir: cloud
client: online
---

# Technical requirements

Many problems with applications are caused by incorrect configuration.

User experience must not degrade on large sites.

Customers' data must be available when they need it, or they should be made aware when it will be expected available to the best of our capabilities.

The setup is the first experience your customer has with your application. **Easy and robust** configuration will ensure customers are given a pleasant first impression.

## Requirements

* You must have a **running application** at a specified [redirect URL][1] that can process a request containing one or more security tokens. The supported security token format is JWT.
  * Must be done before you attempt to authenticate.
* The application must have at least 1 callback URL to orchestrate user management when SuperOffice redirects a successfully authenticated user installing, or setting up your application.
* Application management: Customers need to be able to manage their applications, including access to **uninstall**.

### Availability

* SuperOffice AS and our hosting center guarantee a 99.8% percent availability, your systems need to be up and running according to **SLA**.
* The amount of **load** is our biggest concern. Don't enforce so much load on the system so the system becomes unavailable for other users.
  * We will be monitoring traffic
* Ensure that all system data is automatically backed up regularly.
  * Ensure that **backups** are properly protected via physical security or encryption when they are stored, as well as when they are moved across the network. This includes remote backups and cloud services.

### Performance

* All operations must finish within a reasonable amount of time.
* **Navigation** in the user interface must not be slowed down by running reports or similar requests that take a long time
* You may be **throttled** by SuperOffice and the user should not experience this as a hang.
  * Our Operations Center manages applications to avoid any application consuming too much power and speed.
  * We reserve the right to stop your application if it causes performance problems or adverse effects for all customers. You will be notified when this happens.
  * We may introduce some boundaries/limitations per app/partner.
* You must consent to **monitoring**: Our Operation Center monitors all applications' throughput.
  * Throughput is the amount of data and stress on the hardware.
* Accounting: Track Data usage is tracked for throttling and optimization of the services to ensure uptime and performance.

### Provisioning/de-provisioning (deployment)

* You need to provide us with a **list of what is provisioned** for a customer when installed.
* The installation process must be straightforward and easy to perform by the customer administrator.
  * Once set up the application should be visible or the customer administrator should get information about what needs to be done to get it visible. (See grouping and filtering)
* Create a complete **uninstall** feature that ensures complete removal of your application and all settings associated with it:
  * SuperOffice-related (user-defined fields, web panels, buttons, and preferences).
  * Make sure the application will clean up all configuration data in the database when the application is uninstalled.

### Release strategy

* Continuous delivery.
* Any new release of your application is **your responsibility** to verify that it still works.
* Before major upgrades of CRM Online, you will be notified and given access to a beta of our new release in our [SOD][2] updated environment. You must verify your application in this new environment.

## Guidance

You don't have to synch your version number to SuperOffice.

We recommend that you also run three parallel installations:

* One against our development environment (SOD)
* One against our staging environment (Stage)
* One against our production environment (`online.superoffice.com`)

These require different [installation URLs][1] and [client ID/secrets][3] (tokens).

You may continue to use web services from an earlier release until we announce EOL.

<!-- Referenced links -->
[1]: ../../create-app/config/redirects.md
[2]: ../../getting-started/app-envir.md
[3]: ../../getting-started/index.md#terminology
