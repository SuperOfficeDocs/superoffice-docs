---
# Mandatory fields.
title: erp_arch_sync_service       # (Required) Very important for SEO.
description: ERP connector Sync Service # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords: .net
so.topic: concept              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Sync Service

![x][img1]

SuperOffice clients will all talk to the ERP system via an **ERP Sync Connector** over SOAP. There can be many Superoffice clients, spread over many different companies, all talking to the same SOAP endpoint.

The SOAP endpoint must keep track of which client is connected to which ERP system. Each connection is identified by a globally unique ID (GUID), which is generated when the connection is created. The GUID is created by NetServer - the web service has no say in what it is.

In the SuperOffice database, the connection is numbered normally using integer keys. The GUID is only used when talking to the Sync Service. If we used the internal integer keys with the web service we would have conflicts.

For example, client 1 would have Sync connection ID 2 configured to map to ERP System A, while client 2 would have its sync connection ID 2 mapped to ERP System B. The ERP Sync connector would not be able to tell one "connection ID 2" from the other.

<!-- Referenced images -->
[img1]: media/sdk-diagrams.png
