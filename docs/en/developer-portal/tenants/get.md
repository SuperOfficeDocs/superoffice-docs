---
uid: dp-tenant-new
title: Request additional tenants
description: Add sandbox tenants for production or create development tenants in SOD environments.
keywords: new tenant, create SOD tenant, order production sandbox
author: Bergfrid Dias
date: 12.10.2024
version_devportal: 1.29
topic: concept
envir: cloud
client: online
---
<!-- markdownlint-disable-file MD051 -->

# Request additional tenants

Add sandbox tenants for production or create development tenants in SOD environments.

## [Request new SOD tenant](#tab/sod)

1. Navigate to your partner page in the Developer Portal and select **Tenants**.

1. On the **Tenant listing** page, go to the **SOD** tab and click **Request New Tenant**.

1. Update the required info if applicable.

1. Optionally, enter a custom name for the new tenant. If left blank, the tenant's name will default to *company*-SOD.

1. Add additional info, and click **Send**.

![Request new tenant in SuperOffice Developer Portal -screenshot][img1]

## [Order production sandbox tenant](#tab/sandbox)

A [production sandbox environment][6] (test environment/test tenant) is a clone of the CRM Online production tenant. It allows you or your partner to develop [custom applications][4] using your own configurations without affecting the production environment. [Pricing applies as for a normal tenant][9].

**Steps:**

1. Navigate to your partner page in the Developer Portal and select **Tenants**.

1. On the **Tenant listing** page, go to the **Production** tab and locate the tenant you wish to clone in the list.

1. Click **Order Production Sandbox**.

1. Specify the required licenses:
    * [User plan][8] and quantity
    * [Development tools][7]
    * [Database mirroring subscription][5]

1. Enter the username of a production tenant user to be assigned as the administrator for the new sandbox.

1. Confirm acceptance of costs and the privacy statement, then click **OK**.

![Order production sandbox in SuperOffice Developer Portal -screenshot][img2]

***

## Related content

* [User plans (licenses)][8]

<!-- Referenced links -->
[4]: ../custom-app/index.md
[5]: ../../mirroring/overview.md
[6]: ../../online/sandbox/index.md
[7]: ../../admin/license/expander-services/tool-box.md
[8]: ../../admin/license/user-plans.md
[9]: https://www.superoffice.com/pricing

<!-- Referenced images -->
[img1]: media/request-new-tenant.png
[img2]: media/order-sandbox.png
