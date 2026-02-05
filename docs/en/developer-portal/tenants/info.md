---
uid: dp-tenant-info
title: Look up tenant info
description: Look up tenant info
keywords: Developer Portal, app, customer, tenant
author: digitaldiina, MargretheR
date: 02.05.2026
version_devportal: 2.10.20
content_type: howto
deployment: online
---

# Look up tenant info

The starting point for all these look-ups is the **Tenant listing** page.

> [!TIP]
> Use the search boxes to quickly locate a specific tenant by ID or name. The list loads more tenants as you scroll. You can also click the **Load all** button to display all tenants at once.

![Tenants page in SuperOffice Developer portal -screenshot][img1]

The **Excel Export** button on the tenant list page allows you to download the tenants currently shown in the list. If you filter the list by application or by one or more columns, the export will contain only the filtered results.

## <a id="state" ></a>Tenant status

The [state of a tenant][5] (running, stopped) indicates if it's available to receive requests from an API and whether users can log in.

1. Locate the tenant in the list on the **Tenant listing** page.
1. Observe the value in the **Status** column.

To check which endpoint the tenant is currently using (root path of customer installation) and see which SuperOffice version it'is running, click the tenant to open the **Tenant details** page and select the **Overview** tab.

![Tenant details page in SuperOffice Developer portal -screenshot][img2]

## <a id="license"></a>User license statistics

The license information is presented in two columns on the **Tenant listing** page.

1. Locate the tenant in the list on the **Tenant listing** page.
1. Observe the column values values to determine the total number of licenses and how many are currently in use.

| Column | Description |
|---|---|
| Available Licenses | The total number of licenses. |
| Used Licenses | How many of those license that are assigned to a user. |

## Site licenses

The list of [platform features][6] available to a tenant is shown in the **Tenant details** page.

1. From the **Tenant listing** page, click on a specific tenant to open the **Tenant details** page.

1. Select the **Overview** tab.

1. Review the **Site licenses** section to see the platform features available to the tenant.

1. Observe the **License Expiry Date** above the list to understand how long the licenses are valid.

## Related content

* [Check tenant status via State API][4]
* [Licences in Settings and maintenance][6]

<!-- Referenced links -->
[4]: ../best-practices/tenant-status/check-status.md
[5]: ../best-practices/tenant-status/index.md
[6]: ../../admin/license/index.md

<!-- Referenced images -->
[img1]: media/tenants-page.png
[img2]: media/tenant-details-overview.png
