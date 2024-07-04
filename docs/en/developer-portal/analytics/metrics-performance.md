---
title: Check application performance
uid: dp-metric-performance
description: How to check the API performance for your application.
author: Anthony Yates
date: 01.02.2024
keywords: API metrics, API performance, metered services
topic: howto
envir: cloud
client: online
version: 1.16
---

# Check application API performance

[!include[API call vs. record count](includes/def-metrics.md)]

## At a glance

The **API Performance tab** shows API-level application performance for one specific application.

<!-- markdownlint-disable MD029 -->
[!include[Go to the app page](../includes/go-to-app-page.md)]
<!-- List starts in the include. Next line MUST be 2. -->

2. Select **API metrics**, then select **API Performance** tab.

3. Select a time range interval (minutes, hours or days).

4. Click through the environment specific buttons.
<!-- markdownlint-restore -->

![API performance overview in SuperOffice developer portal -screenshot][img1]

### Columns

| Type of usage | Description |
|---|---|
| Operation Name | The URL endpoint. |
| Count | The number of API invocations to the endpoint. |
| Record Count | The number of database records selected by the API invocation. |
| Duration (AVG) | The average number number of milliseconds elapsed for each of all API invocations. |
| Customer | The customer context identifier that invoked the API. |

> [!TIP]
> Click on a row to observe the samples (individual invocations) related to the endpoint.

When there are many rows, you can filter the list by typing in the search box. The list will update as you type.

## Filter by sample

* To see the request details, select one of the samples from the samples list.

    Observe the *sort by* dropdown menu above the samples. Use the sort option to sort the samples according to timestamp, database rows and duration.

    ![API performance selected row -screenshot][img2]

    Observe the sample details:

    ![API request samples -screenshot][img3]

    > [!NOTE]
    > The left side samples column contains each invocation for the endpoint. The center column contains the endpoint and the column on the right contains the invocation details.

* To return to the API Performance list, click the X in the upper right-hand corner.

## Improve app performance

[!include[Best practices](includes/improve-performance.md)]

During development, following the statistics in SOD day-by-day can provide valuable insight into the impact of your improvements.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/metrics-performance-landing.png
[img2]: media/metrics-performance-selected-row.png
[img3]: media/metrics-performance-selected-sample.png
