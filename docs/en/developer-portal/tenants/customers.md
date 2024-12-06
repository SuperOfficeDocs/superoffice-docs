---
uid: dp-customers
title: Customers
description: Find out who your customers are in the SuperOffice Developer Portal.
keywords: Developer Portal, app, customer
author: Bergfrid Dias
date: 12.06.2024
version_devportal: 1.29
topic: howto
envir: cloud
---

# Find out who your customers are

The Tenant Manager in the Developer Portal provides you with an overview of all customers who have authorized one or more of your applications. You can check which customers that have [authorized][1] a specific app and see a list of all tenants linked to your company. The information is organized per environment (SOD, Stage, Production). We do not yet show you if they are actively using the app.

![List of customers -screenshot][img1]

## Who has authorized this app?

The **app page** shows how many customers (tenants) that have authorized one specific application in each environment.

<!-- markdownlint-disable MD029 -->
[!include[Go to the app page](../includes/go-to-app-page.md)]
<!-- List starts in the include. Next line MUST be 2. -->

2. Select **Overview** and locate the **Customers** section. The table shows the number of tenants per environment.

3. Click one of the environments (SOD, Stage, Production) to open the **Tenant insights** page. This page will show detailed tenant names and IDs for each environment.To know who authorized the app and when the authorization is valid, you need to select a specific tenant to open the **Tenant details** page.

    > [!NOTE]
    > The tenants listed are filtered to show only those associated with the specific application if you accessed the Tenant insights from the app page.

4. Optional, switch environments to explore further.

<!-- markdownlint-restore -->

## Who are my customers?

The **partner page** provides an overview of how many customers (tenants) that have authorized one or more applications developed by a specific company per environment.

1. In the Developer Portal, go to your partner page.

2. Select **Overview** and locate the **Customers** section. The table shows the number of tenants per environment (SOD, Stage, Production).

3. Click one of the environments (SOD, Stage, Production) to open the **Tenant insights** page. This page shows the name and ID of *all* tenants in that environment, along with other related information.

4. Optional, switch environments to explore further.

## Look up tenant info

The starting point for all these look-ups is the **Tenant insights** page.

> [!TIP]
> Use the search boxes to quickly locate a specific tenant by ID or name, especially when you have many tenants listed.

### <a id="state" ></a>Tenant status

The [state of a tenant][5] (running, stopped) indicates if it's available to receive requests from an API and whether users can log in.

1. Locate the tenant in the list on the **Tenant insights** page.
1. Observe the value in the **Status** column.

To check which endpoint the tenant is currently using and see which SuperOffice version it'is running, click the tenant to open the **Tenant details** page and select the **Overview** tab.

### <a id="license"></a>User license statistics

The license information is presented in two columns on the **Tenant Insights** page.

1. Locate the tenant in the list on the **Tenant insights** page.
1. Observe the column values values to determine the total number of licenses and how many are currently in use.

| Column | Description |
|---|---|
| Available Licenses | The total number of licenses. |
| Used Licenses | How many of those license that are assigned to a user. |

### Site licenses

The list of platform features available to a tenant is shown in the **Tenant details** page.

1. From the **Tenant insights** page, click on a specific tenant to open the **Tenant details** page.

1. Select the **Overview** tab.

1. Review the **Site licenses** section to see the platform features available to the tenant.

1. Observe the **License Expiry Date** above the list  to understand how long the licenses are valid.

## Related content

* [Provisioning][2]
* [About consent][3]
* [How to get consent][4]

<!-- Referenced links -->
[1]: ../getting-started/what-api-to-use.md#authentication-scenarios
[2]: ../provisioning/index.md
[3]: ../provisioning/consent.md
[4]: ../provisioning/get-consent.md
[5]: ../best-practices/tenant-status/index.md

<!-- Referenced images -->
[img1]: media/customers.png
