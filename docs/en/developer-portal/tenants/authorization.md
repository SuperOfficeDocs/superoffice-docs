---
uid: dp-tenant-authorization
title: Tenant authorization
description: The Tenant Manager makes it easier to oversee and edit authorization records related to employees and tenants.
keywords: tenant, authorization, authorize app
author: Bergfrid Dias
date: 07.10.2026
version_devportal: 2.16
content_type: concept
deployment: online
platform: web
---

# Tenant authorization

The Tenant Manager makes it easier to oversee and update authorization records related to employees and tenants. The information is organized per environment. We do not yet show you if they are actively using the app.

## Who has authorized this app?

The **app page** shows how many tenants that have authorized one specific application in each environment.

<!-- markdownlint-disable MD029 -->
[!include[Go to the app page](../includes/go-to-app-page.md)]
<!-- List starts in the include. Next line MUST be 2. -->

2. Select **Overview** and locate the **Tenants** section. The table shows the number of tenants per environment.

3. Click one of the environments (SOD, Stage, Production) to open the **Tenant listing** page. This page will show detailed tenant names and IDs for each environment. To know who authorized the app and when the authorization is valid, you need to select a specific tenant to open the **Tenant details** page.

    > [!NOTE]
    > The tenants listed are filtered to show only those associated with the specific application if you accessed the tenant overview from the app page.

4. Optional, switch environments to explore further.

<!-- markdownlint-restore -->

## Authorization status

Each authorization on the **Tenant details** page has a **Status** that tells you whether the app can still access that tenant:

| Status | Meaning |
|---|---|
| **Active** | The authorization is in place and the app can access the tenant. |
| **Revoked** | The authorization has been revoked. The connection between the app and the tenant's database is severed and the app can no longer access it. Data in the database is not removed. [Contact us][5] if you are unsure why the authorization was revoked. |

To review authorization status for a tenant:

1. On the **Tenant listing** page, open a tenant to see its **Tenant details** page.

1. Select the **Authorizations** tab.

1. Check the **Status** column. Use the **Status** filter above the column to show only **Revoked** or **Active** authorizations.

![Tenant details Authorizations tab showing Revoked and Active status -screenshot][img4]

### Spot revoked authorizations on the Tenant listing

You don't have to open each tenant to find revoked authorizations. The **Tenant listing** indicates any tenant that has one or more revoked app authorizations in its **Status** column, so you can spot affected customers across all your apps at a glance.

Open a flagged tenant and go to the **Authorizations** tab to see which authorization is revoked.

![Tenant listing indicating tenants that have one or more revoked authorizations -screenshot][img5]

## Request authorization

Apps require [customer consent][3] to access customer data.

1. Navigate to your partner page in the Developer Portal and select **Tenants**.

1. On the **Tenant listing** page, go to the **Production** tab and click **Request Authorization**.

1. Select an application from the list.

1. Enter customer name and Cust ID in production.

1. Provide the email address of the customer's contact person.

1. Optionally, add additional info.

1. Click **Send**. An email will be sent to the customer for confirmation. Access is granted upon approval.

![Request tenant authorization dialog in SuperOffice Developer portal -screenshot][img1]

## Edit tenant authorization

1. Go to the **Tenant listing** page.

1. Select an environment tab (SOD, Stage, Production) and choose the tenant you wish to update.

1. On the **Tenant details** page, open the **Authorizations** tab.

1. Locate the application in the list and click **Edit**.

1. Enter who you submit this request on behalf of.

1. Complete the form and click **Send**.

![Request edit tenant authorization in SuperOffice Developer portal -screenshot][img2]

## Remove tenant authorization

Revoking access severs the connection between the application and the tenant's database but does not remove data from the database.

1. On the **Tenant details** page, go to the **Authorizations** tab.

1. Locate the application in the list and click **Remove**.

1. Enter the customer contact's email address.

1. Provide a reason for removing the authorization.

1. Click **Send**.

![Request remove tenant authorization in SuperOffice Developer portal -screenshot][img3]

## Related content

* [Provisioning][2]
* [About consent][3]
* [How to get consent][4]

<!-- Referenced links -->
[5]: https://dev.superoffice.com/contact-us
[2]: ../provisioning/index.md
[3]: ../provisioning/consent.md
[4]: ../provisioning/get-consent.md

<!-- Referenced images -->
[img1]: media/request-authorization.png
[img2]: media/edit-authorization.png
[img3]: media/remove-authorization.png
[img4]: media/tenant-details-authorization-revoked.png
[img5]: media/tenants-revoked-indication.png
