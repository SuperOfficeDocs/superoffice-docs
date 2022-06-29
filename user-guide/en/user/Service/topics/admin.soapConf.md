---
uid: help-en-admin-soapconf
title: admin soapConf
description: admin soapConf
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# SOAP

In the **SOAP** screen, you can configure the SOAP interface. You can set up 3 types of port access:

* **Port: Customer**: This tab specifies which IP addresses should have access to the port which offers customer-portal-related functionality. This includes the customer's requests and external messages and the knowledge base.
* **Port: Request**: This tab relates to request handling functionality in SuperOffice Service. Computers with IP addresses within one of the ranges specified here will have access to running SOAP functions that provide this functionality.
* **Port: Admin**: This tab deals with functionality relating to the setup and configuration of SuperOffice Service. Computers with IP addresses within one of the ranges specified here will have access to running SOAP functions that provide this functionality.

To add an IP address range:

1. Select ![icon](../media/globalmenu_settings_small.png)**System settings** &gt; **SOAP**.
2. In the **Port** list, select the required access type.
3. In the fields next to **From**, enter the start address of the IP address range.
4. In the fields next to **To**, enter the end address of the IP address range.
5. Click the **Add** button to add the IP address range to the list below.

> [!TIP]
> To delete an IP address range from the list, click the delete icon ( ![icon](../media/btn_delete.png) ).
