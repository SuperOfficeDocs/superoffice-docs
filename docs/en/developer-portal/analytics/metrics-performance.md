---
uid: dp-metric-performance
title: Check application performance
description: How to check the API performance for your application.
keywords: API metrics, API performance, metered services
author: Anthony Yates
date: 07.08.2024
version: 1.24
version_devportal: 1.24
content_type: howto
deployment: online
platform: web
---

# Check application API performance

[!include[API call vs. record count](includes/def-metrics.md)]

## At a glance

The **API Performance tab** shows API-level application performance for one specific application.

<!-- markdownlint-disable MD029 -->
[!include[Go to the app page](../includes/go-to-app-page.md)]
<!-- List starts in the include. Next line MUST be 2. -->

2. Select **API metrics**, then select **API Performance** tab.

3. Select a time range interval (minutes, hours, or days).

4. Click through the environment specific buttons.
<!-- markdownlint-restore -->

![API performance overview in SuperOffice developer portal -screenshot][img1]

### Columns

| Type of usage | Description |
|---|---|
| Operation Name | The API endpoint. |
| Count | The number of API invocations to the endpoint. |
| Record Count | The number of database records selected by the API invocation. |
| Duration (AVG) | The average number number of milliseconds elapsed for each of all API invocations. |
| Customer | The customer context identifier that invoked the API. |

> [!TIP]
> Click on a row to observe the samples (individual invocations) related to the endpoint.

When there are many rows, you can filter the list by typing in the search box. The list will update as you type.

## Filter by sample

* To see the request details, select one of the samples from the samples list.

    Use the **sort option** drop-down menu above the list to sort the samples according to timestamp, database rows, or duration.

    ![API performance selected row -screenshot][img2]

    Observe the sample details:

    ![API request samples -screenshot][img3]

    > [!NOTE]
    > The left side samples column contains each invocation for the endpoint. The center column contains the endpoint and the column on the right contains the invocation details.

* To return to the API Performance list, click the X in the upper-right corner.

## Disable API request sampling

Starting from SuperOffice version 10.5.1, API request sampling was introduced to reduce the volume of logged data and improve performance monitoring. By default, only a subset of API requests is recorded.
However, sampling can be temporarily disabled if you need full visibility into all API traffic. This is especially useful when:

* You're troubleshooting specific performance issues.
* You need to verify the exact timing and frequency of API calls.
* You're analyzing detailed request patterns for optimization.

To disable sampling:

1. Click the settings icon (cogwheel) to edit setting.

    ![Disable API request sampling -screenshot][img4]

2. Set the end time for the period during which sampling should be disabled for a specific app.

3. During this period, every API request will be logged and visible in, you will see itemCount = 1.

> [!NOTE]
> Disabling sampling may increase the volume of logged data, so it's recommended to use this feature only when necessary and for limited timeframes.

## Improve app performance

[!include[Best practices](includes/improve-performance.md)]

During development, following the statistics in SOD day-by-day can provide valuable insight into the impact of your improvements.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/metrics-performance-landing.png
[img2]: media/metrics-performance-selected-row.png
[img3]: media/metrics-performance-selected-sample.png
[img4]: media/metrics-disable-sampling.png

