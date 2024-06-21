---
uid: api_scenarios_cs
title: Integration in the Service client
description: Integration in the Service client
author: Tony Yates
date: 11.26.2021
keywords: API, integration point, Service
topic: reference
envir: cloud, onsite
client: service
---

# Integration scenarios: Service

There are several articles available that explain in detail many of the internal automation integration points provided by SuperOffice CS. There are not, however, too many external integration points to discuss. The ones that do exist are primarily the CS legacy [SOAP services][10]. It must be said that these services have not evolved for quite some time, and do not appear to be on any road map. That said, there are a few major installations that do leverage these endpoints, and therefore they are not likely to fade away any time soon either. Similar to the Windows client COM APIs, these APIs are in the future not likely to change.

> [!NOTE]
> There are no prebuilt SuperOffice proxies available for these APIs. You must use a proxy generator appropriate for your target technology platform, or use raw SOAP requests, to use these services.

## Integrations points

* SOAP Services (**Not available in Online**) (available at `http://<domain>/scripts/SOAP.exe?action=<endpoint>`. Available action parameters:
  * customer
  * ticket
  * admin
* Custom tables and fields
* Custom screens and dialogs
* Scheduled events
* Event-driven interaction
* Data Exchange
* High-level automation

## Related SDK

* [Customer Service][10]

<!-- Referenced links -->
[10]: ../soap/overview.md

<!-- Referenced images -->
