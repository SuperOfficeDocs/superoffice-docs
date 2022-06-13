---
title: Tenant status
description: "SuperOffice offers both a pull and a push approach to get tenant status."
author: Bergfrid Dias
so.date: 02.02.2022
keywords: status, monitor, tenant, State Change URL
so.topic: concept
so.envir: cloud
so.client: online
---

# Tenant status

[!include[Intro to tenant status](includes/tenant-status-intro.md)]

When a tenant installation experience state changes, the application should pause and resume according to the tenant's availability.

## Status page (pull)

Each tenant has a [status page][2] where you can [check its state][1] to ensure your application remains stable and responds accordingly. The URL is environment-specific and contains the context identifier. For example:

`https://**sod**.superoffice.com/api/state/**Cust00000**`

## Notifications (push)

When a tenant installation changes, SuperOffice sends a [notification][3] to each approved application.

To [receive notifications][4], application vendors must provide a **State Change URL** that specifies where SuperOffice sends notifications. For example:

`https://www.awesomeapp.com/NotifyCustomerStateChange`

> [!TIP]
> Notifications offer the ability to mitigate any potential errors that might occur due to state changes.

<!-- Referenced links -->
[1]: check-status.md
[2]: status-page.md
[3]: notifications.md
[4]: get-notifications.md
