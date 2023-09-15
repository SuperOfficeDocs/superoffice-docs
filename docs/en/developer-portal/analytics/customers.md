---
title: Customers
uid: dp-customers
description: Find out who your customers are in the SuperOffice Developer Portal.
author: Bergfrid Dias
so.date: 09.15.2023
keywords: Developer Portal, app, customer
so.topic: howto
so.dp-version: 1.11
so.envir: cloud
---

# Find out who your customers are

You can check which customers that have [authorized][1] a specific app and get a list of all customers for your company. The information is shown the Developer Portal per environment (SOD, Stage, Production). We do not yet show you if they are actively using the app.

![List of customers -screenshot][img1]

## Who has authorized this app?

The **app page** shows customers for one specific application.

<!-- markdownlint-disable MD029 -->
[!include[Go to the app page](../includes/go-to-app-page.md)]
<!-- List starts in the include. Next line MUST be 2. -->

2. Select **Overview** and locate the **Customers** section.

3. Click through the environment specific tabs.
<!-- markdownlint-restore -->

## Who are my customers?

The **partner page** shows customers for all applications developed by a specific company.

1. In the Developer Portal, go to your partner page.

2. Select **Overview** and locate the **Customers** section.

3. Click through the environment specific tabs.

## Related content

* [Provisioning][2]
* [About consent][3]
* [How to get consent][4]

<!-- Referenced links -->
[1]: ../getting-started/what-api-to-use.md#authentication-scenarios
[2]: ../provisioning/index.md
[3]: ../provisioning/consent.md
[4]: ../provisioning/get-consent.md

<!-- Referenced images -->
[img1]: media/customers.png
