---
title: Check exceptions from your app's API calls
uid: dp-failures
description: How to check exceptions and failed requests from your apps API calls in the SuperOffice Developer Portal.
author: Bergfrid Dias
so.date: 11.15.2023
keywords: API call, exception, fail, request
so.topic: howto
so.envir: cloud
so.client: online
so.dp-version: 1.16
---

# Check exceptions from your app's API calls

SuperOffice logs application behavior to Application Insights. In the Developer Portal, you can monitor and analyze your application's failed requests to our APIs and exceptions thrown.

[!include[Legend](../includes/list-failure-types.md)]

## At a glance

The **app page** shows application failures for one specific application.

<!-- markdownlint-disable MD029 -->
[!include[Go to the app page](../includes/go-to-app-page.md)]
<!-- List starts in the include. Next line MUST be 2. -->

2. Select **Failures**.

3. Select an environment and a time range.

4. Explore the **Exceptions** and **Failed Inbound Requests** tabs.
<!-- markdownlint-restore -->

![API failure overview in SuperOffice developer portal -screenshot][img1]

## Drill down

### Exceptions

Exceptions are grouped by ID and the count shows how many times each exception occurred within the selected time frame.

To explore the details:

1. Click to select an exception from the list.

    ![API exception sample in SuperOffice developer portal -screenshot][img2]

1. Select one of the samples to access the full end-to-end transaction details.

    ![API exception details in SuperOffice developer portal -screenshot][img3]

## Failed requests from app to API

Requests are grouped by operation and the count shows how many times each operation failed within the selected time frame.

Explore the details as described above.

![List of inbound failed API requests in SuperOffice developer portal -screenshot][img4]

![E2E failed failed API request in SuperOffice developer portal -screenshot][img5]

## Improve app health

Leverage our [best practices for online app development][2] to both boost your application's stability and availability.

During development, following the statistics in SOD day-by-day can provide valuable insight into the impact of your improvements.

> [!NOTE]
> If you are stuck and need assistance, contact us and include the **operation ID** from the transaction.

<!-- Referenced links -->
[2]: ../best-practices/index.md

<!-- Referenced images -->
[img1]: media/failures.png
[img2]: media/exception-sample.png
[img3]: media/exception-details.png
[img4]: media/failed-inbound.png
[img5]: media/500-details.png
