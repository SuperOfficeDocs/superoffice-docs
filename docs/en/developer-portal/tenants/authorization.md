---
uid: dp-tenant-authorization
title: Tenant authorization
description: The Tenant Manager makes it easier to oversee and edit authorization records related to employees and tenants.
keywords: tenant, authorization, authorize app
author: Bergfrid Dias
date: 12.10.2024
version_devportal: 1.29
topic: concept
envir: cloud
client: online
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
[2]: ../provisioning/index.md
[3]: ../provisioning/consent.md
[4]: ../provisioning/get-consent.md

<!-- Referenced images -->
[img1]: media/request-authorization.png
[img2]: media/edit-authorization.png
[img3]: media/remove-authorization.png
