---
uid: dp-tenants
title: Tenant management
description: Tenant management
keywords: standard app, public app, App Store, custom app, tenant
author: Bergfrid Dias
date: 12.10.2024
version_devportal: 1.29
topic: concept
envir: cloud
client: online
---

# Tenant management

The Tenant Manager is your dedicated area for managing tenants across [development, stage, and production environments][9]. Designed for organizational efficiency, this section of the Developer Portal helps streamline management tasks related to tenants, applications, and authorizations. It empowers organizations and employees to easily list tenants by partner and manage various aspects of their environments.

## Key features

The Tenant Manager provides a set of tools and features that help you effectively manage and gain insights into your tenants. Here are some of the main functionalities available:

* **Tenant insights:** [Get an overview of your tenants][1], including environment-specific details and partner associations.

* **User and site license statistics:** Monitor [license usage][2] for both users and sites, helping track resource allocation.

* **Tenant status:** View the [current status of each site][3] to ensure environments are running smoothly.

* **Request consultant access:** For production tenants, request consultant access when necessary.

* **Request additional tenants:** [Add sandbox tenants][5] for production or [create development tenants][5] in SOD environments.

* **Authorization management:** [View, edit, and revoke authorization records][4] related to tenants.

## Navigating the Tenant Manager

* Begin by selecting an environment (SOD, Stage, Production) to view relevant tenant statistics.

* **Tenant listing:** Click on a specific tenant to open the **Tenant listing** page, which provides a detailed view of the tenant’s information, including licenses, state, and more.

* **Tenant details:** To access more granular details, select a tenant from the Insights page. Depending on your access rights, you can request authorizations, consultant access, or order a production sandbox.

The Tenant Manager simplifies tenant management, making it easier to oversee authorizations, resolve issues, and make informed decisions about your development and production environments.

## Who are my customers?

The **partner page** provides an overview of how many tenants that have authorized one or more applications developed by a specific company per environment.

![List of tenants -screenshot][img1]

1. In the Developer Portal, go to your partner page.

2. Select **Overview** and locate the **Tenants** section. The table shows the number of tenants per environment (SOD, Stage, Production).

3. Click one of the environments (SOD, Stage, Production) to open the **Tenant listing** page. This page shows the name and ID of *all* tenants in that environment, along with other related information.

4. Optional, switch environments to explore further.

<!-- Referenced links -->
[1]: info.md
[2]: info.md#license
[3]: info.md#state
[4]: authorization.md
[5]: get.md
[9]: ../getting-started/app-envir.md

<!-- Referenced images -->
[img1]: media/tenants.png
