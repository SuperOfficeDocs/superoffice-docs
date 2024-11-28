---
uid: tenant-status
title: Tenant status
description: "SuperOffice offers both a pull and a push approach to get tenant status."
keywords: status, monitor, tenant, State Change URL, state API, availability
author: Bergfrid Dias, Margrethe Romnes, Eivind Fasting
date: 03.22.2024
topic: concept
envir: cloud
client: online
---

# Tenant status

The state of the tenant indicates if a tenant is available to receive requests, and it is recommended you always know the state of the tenant before sending any requests to the API.
There are two ways to know the tenant status, either by [checking its status through the API (Pull)][1] or [receive notifications when a tenant changes status (Push)][2].
These options are fundamentally different, proactive vs reactive, and its up to the developer to decide which option(s) makes the most sense for the application.

## Checking tenant status (Pull)

This is a proactive means to determine the current status of a tenant. Your application precedes each API request with a [call to the state endpoint][1] to ensure the tenant is in a **Running** state.

[!include[check-status-mermaid](includes/check-status-mermaid.md)]

The [state][3] signals wether the tenant is available for handling API requests.

## <a id="notify"></a>Receive tenant status (Push)

[Subscribing to a webhook][2] is a more reactive flow that sends notifications each and every time a tenant state changes. SuperOffice sends out a notifications [payload][4] and gives you a chance to manage tenant customer states better.

To receive notifications, application vendors must provide a **State Change URL** that specifies where SuperOffice sends notifications. This can be done through the developer portal, and is described further down in this document.

Notifications ensure that vendors are aware when the states of their customers change, for example, their SuperOffice subscription and that they know when tenants are unable to respond to requests.

When SuperOffice upgrades a tenant, for example, SuperOffice looks at each application approved by the tenant and sends out a notification to each one to indicate that the tenant is about to be upgraded. This provides the application an opportunity to know when a tenant going to be unavailable and why communications with that tenant cease until further notice.

[!include[get-notifications-mermaid](includes/get-notifications-mermaid.md)]

Not only does that provide advanced notice when tenants are upgraded to new versions of SuperOffice, but it can signal whenever a customer has canceled a subscription (Delete).

<!-- Reference links -->
[1]: ./check-status.md
[2]: ./get-notifications.md
[3]: ./check-status.md#state
[4]: get-notifications.md#payload
