---
uid: dp-tenant-authorization
title: Tenant authorization
description: The Tenant Manager makes it easier to oversee and edit authorization records related to employees and tenants.
keywords: tenant, authorization, authorize app
author: Bergfrid Dias
date: 12.09.2024
version_devportal: 1.29
topic: concept
envir: cloud
client: online
---

# Tenant authorization

The Tenant Manager makes it easier to oversee and edit authorization records related to employees and tenants. The information is organized per environment (SOD, Stage, Production). We do not yet show you if they are actively using the app.

## Who has authorized this app?

The **app page** shows how many tenants that have authorized one specific application in each environment.

<!-- markdownlint-disable MD029 -->
[!include[Go to the app page](../includes/go-to-app-page.md)]
<!-- List starts in the include. Next line MUST be 2. -->

2. Select **Overview** and locate the **Tenants** section. The table shows the number of tenants per environment.

3. Click one of the environments (SOD, Stage, Production) to open the **Tenant insights** page. This page will show detailed tenant names and IDs for each environment. To know who authorized the app and when the authorization is valid, you need to select a specific tenant to open the **Tenant details** page.

    > [!NOTE]
    > The tenants listed are filtered to show only those associated with the specific application if you accessed the Tenant insights from the app page.

4. Optional, switch environments to explore further.

<!-- markdownlint-restore -->

## Request authorization

To access customer data, all apps require the [customer's consent][3].

1. In the Developer Portal, go to your partner page and select **Tenants**.

1. On the **Tenant insights** page, select the **Production** tab and click **Request Authorization**.

1. Select an application from the list.

    ![Request tenant authorization dialog in SuperOffice Developer portal -screenshot][img1]

1. Enter customer name and Cust ID in production.

1. Enter the email address of the contact person at the customer.

1. Optionally, add additional info.

1. Click **Send** to initiate the process. An email will then be sent to the specified customer contact for confirmation, and access will be granted once SuperOffice receives their approval.

## Edit tenant authorization

1. Go to the **Tenant insights** page.

1. Select one of the environment tabs (SOD, Stage, Production) and choose the tenant you wish to update from the list.

1. On the **Tenant details** page, select the **Authorizations** tab.

1. Locate the application in the list and click the **Edit** button on that row.

1. Enter who you submit this request on behalf of.

    ![Request edit tenant authorization in SuperOffice Developer portal -screenshot][img2]

1. Complete the form and click **Send**.

## Remove tenant authorization (employees only)

Revoking access to an application will sever the connection between the application and a database tenant. It will not remove any data from the database.

1. On the **Tenant details** page, select the **Authorizations** tab.

1. Locate the application in the list and click the **Remove** button on that row.

1. Enter the email address of the contact person at the customer.

    ![Request remove tenant authorization in SuperOffice Developer portal -screenshot][img3]

1. State *why* authorization should be removed.

1. Click **Send**.

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
