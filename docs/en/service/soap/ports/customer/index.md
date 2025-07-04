---
title: The Customer port
uid: cs_soap_ports_customer
description: Services SOAP interface port reference - customer
author: SuperOffice Product and Engineering
keywords: soap
date: 01.25.2021
content_type: reference
---

# The Customer port

This port is meant to provide all the methods needed to create your own customer portal using SOAP.

As many of the methods provide functionality only available when the customer is logged in, a **session key** is central in many of the methods. This key is retrieved from a successful call to `login()` and should be passed to `logout()` when the session is over. If a session is idle for too long (30 minutes), the session key will be deleted from the list of legal keys.

For the methods where the authorized customers have more rights than the non-authorized customers(such as `faq_findEntries()`), an empty session key can be passed to access the publicly available items or a legal key to access all.
