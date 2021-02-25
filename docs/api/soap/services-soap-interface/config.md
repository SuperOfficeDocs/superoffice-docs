---
title: services_soap_config
description: Services SOAP configuration
author: {github-id}             # Your GitHub alias.
keywords:
so.date: 01.25.2021
so.topic: howto
---

# Configuration

The configuration of the SOAP interface is fairly limited. The only option you have is to limit the access to the different ports by ranges of IP addresses. You need administrator-level rights to do this.

> [!CAUTION]
> You should carefully consider which ranges need access to the different ports, as SOAP opens for easier brute force exploitation of your system. If malicious hackers get access to the interface, this could jeopardize the security of your system.

**To configure the interface:**

1. Go to System->Soap from within the user interface of Service.
2. Enter or delete ranges that are permitted to use the different ports.

If you try to run a client from an IP address that is not within the permitted ranges an exception will be thrown.
