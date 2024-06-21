---
uid: api_scenarios_web_online
title: Integration in the online Web client
description: Integration in the online Web client
author: Tony Yates
date: 11.25.2021
keywords: API, integration point, online
topic: concept
envir: cloud
client: web
---

# Integration scenarios: Web client (online)

Both SuperOffice onsite installations and CRM Online applications use the same NetServer web service APIs. The only difference between the two environments is how integrations are authenticated. While on-site integrations have a more direct approach, supplying credentials, CRM Online integrations must use [federated authentication][8].

**Federated authentication** is a way SuperOffice can provide a single-sign-in experience for multi-tenant users and applications that serve multi-tenant installations.

The SuperOffice CRM Online environment hosts an app store with several partner integrations. These integrations are comprised of Business to Consumer (B2C) applications. Most applications expose functionality inside SuperOffice by adding web panels in relevant areas, while others add a button that opens a web page to the application. All application vendors have their own cloud platforms to manage customers and tenant users.

## Integration points (online)

* Custom lists
* Custom list items
* User-defined fields
* Web panels
* Custom buttons (navigator and button bar)
* Access to web services, including webhooks

## Related SDK

* [CRM Online SDK][9]

<!-- Referenced links -->
[8]: ../../identity-management/federated-auth.md
[9]: ../../api/reference/webapi/index.md

<!-- Referenced images -->
