---
title: Check application usage
uid: dp-metered-services
description: How to check the API call statistics for your application and monitor metered services.
author: Bergfrid Dias
so.date: 04.27.2023
keywords: metered services, API usage
so.topic: howto
so.envir: cloud
so.client: online
so.version: 1.11
---

# Check application usage (API calls)

Metered API calls come from applications that are not part of the SuperOffice standard products.

## At a glance

The **app page** shows application usage for one specific application.

<!-- markdownlint-disable MD029 -->
[!include[Go to the app page](../includes/go-to-app-page.md)]
<!-- List starts in the include. Next line MUST be 2. -->

2. Select **API metrics**, then select **API Usage** tab.

3. Select a time range interval (days, weeks, or months).

4. Click through the environment specific buttons.
<!-- markdownlint-restore -->

![API usage overview in SuperOffice developer portal -screenshot][img1]

### Legend

| Type of usage | Description |
|---|---|
| MeteredApps | The number of API calls this app does for custom and standard apps. |
| Customizations | The number of API calls from CRMScripts or screens that are custom (non-standard Service functionality) |
| IncludedApps | The number of API calls from SuperOffice's own apps with **Exclude from invoice**. Standard functionality |

> [!TIP]
> Click on the individual items in the legend to filter what is shown in the graph.

![API usage filtering -screenshot][img4]

## Filter by customer

* To see the impact of your app on one specific customer (tenant), select a customer from the drop-down list.

    > [!NOTE]
    > The list contains only the [customers that have authorized the app][1] for a specific environment. For example, a SOD tenant appears only in the SOD environment. If you don't see a customer you think should be in the list, check that you have selected the correct environment.

* To clear the filter, click the red cross.

## Improve app performance

Leverage our [best practices for online app development][2] to both boost your application's performance and reduce its API usage. Both [cashing][3] and [search][4] have a huge impact.

The default time period when you look at API calls is **Months**, but you can change the resolution on the horizontal axis to **Weeks** or **Days**.

![API usage per week -screenshot][img2]

![API usage per day -screenshot][img3]

During development, following the statistics in SOD day-by-day can provide valuable insight into the impact of your improvements.

<!-- Referenced links -->
[1]: customers.md
[2]: ../../apps/best-practices.md
[3]: ../../apps/best-practices.md#caching
[4]: ../../apps/best-practices.md#searching

<!-- Referenced images -->
[img1]: media/usage.png
[img2]: media/usage-days.png
[img3]: media/usage-weeks.png
[img4]: media/usage-filter.png
