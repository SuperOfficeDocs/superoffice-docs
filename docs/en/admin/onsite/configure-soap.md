---
uid: help-en-settings-soap-configure
title: Configure SOAP interface
description: Configure SOAP interface
keywords: Service SOAP, SOAP screen, add IP address range, configure SOAP
author: SuperOffice Product and Engineering
date: 07.10.2025
version: 10.5
content_type: howto
category: service
topic: soap
deployment: onsite
audience: settings
audience_tooltip: Settings and maintenance
language: en
redirect_from:
  - /en/admin/learn/screen/soap-config
  - /en/admin/learn/soap-configure-soap
---

# SOAP (ONSITE only)

In the SOAP screen, you can configure the SOAP interface. You can set up 3 types of port access:

* **Port: Customer**: This tab specifies which IP addresses should have access to the port which offers customer-portal-related functionality. This includes the customer's requests and external messages and the knowledge base.
* **Port: Request**: This tab relates to request handling functionality in SuperOffice Service. Computers with IP addresses within one of the ranges specified here will have access to running SOAP functions that provide this functionality.
* **Port: Admin**: This tab deals with functionality relating to the setup and configuration of SuperOffice Service. Computers with IP addresses within one of the ranges specified here will have access to running SOAP functions that provide this

## Add an IP address range

1. [!include[Go to](../../learn/includes/goto-sm.md)]

1. Click **Requests** and select the **SOAP** tab.

1. In the **Port** list, select the required access type.

1. In the fields next to **From**, enter the start address of the IP address range.

1. In the fields next to **To**, enter the end address of the IP address range.

1. Click the **Add** button to add the IP address range to the list below.

> [!TIP]
> To delete an IP address range from the list, click <i class="ph ph-x-circle" aria-label="Remove icon"></i>.
