---
uid: security-enhancements
title: Security enhancements
description: Security enhancements
keywords: security, TLS, PKI, port 443
author: Margrethe Romnes, Tony Yates
date: 03.22.2024
topic: concept
envir: cloud
client: online
---

# Security enhancements

Running in the cloud means that SuperOffice continuously invests in new technology, infrastructure, and increased security. In this document, we will inform you about the security measures in place and what will come in the future.

> [!NOTE]
> This is a living document and will change over time, first published August 23, 2017. Updated October 15, 2018. Updated January 2020. Updated March 2024.

For the last years, SuperOffice has tightened and improved the security of the SuperOffice CRM Online platform. The actions we have taken and will continue to improve on, include:

* Require PKI, or authentication via certificates.
* Prevent outbound internet traffic on all ports, except 80 and 443.
* January 2020: Disabled TLS 1.1 and 1.0 and weak cipher suites.
* January 2024: Added support for TLS 1.3.

## Certificates vs. filtering on IP

SuperOffice, customers, and partners want a safe and secure platform. While filtering on a destination IP address is one way of enforcing security, we have chosen a different approach where we authenticate using certificates or PKI. In the near future, this will be fully enforced.

## Restricting outbound traffic

One of several significant ongoing changes is to control outbound traffic from the SuperOffice CRM Online environment. SuperOffice began this work on August 18, 2017, by modifying the CRM Online domain and infrastructure.

We will also introduce **Proxy Servers** for outbound traffic as one of the next steps in the process. The consequence for partners is that it limits the ports that may be used to access the internet. In the short term, we will allow both port 80 (common HTTP) and port 443 (secure HTTPS), but it is likely that we will limit this to only secure traffic on port 443 in the future.

Erp Sync and Quote Connector already require to use secure communication at port 443.

From August 25th, 2018 we also started to enforce the use of `app://appid` in the maintenance client - ERP Sync Connectors as notified and discussed [here][1] 2 two years ago.

SuperOffice will always strive to inform partners before major changes, but customer security is our 1st priority and there may be situations that require us to take action before informing partners.

<!-- Referenced links -->
[1]: ../api/plugins/erp-connectors/online/secure-in-online.md
