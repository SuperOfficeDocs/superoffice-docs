---
uid: cm-sms-connector
title: CM
description: Configuration of CM NetServer SMS connector
keywords: CM
author: SuperOffice Product and Engineering
date: 10.07.2025
content_type: howto
category: Marketing
topic: SMS
redirect_from: /en/service/sms/cm
language: en
---

# Configuration of CM NetServer SMS connector

This document describes how to set up the CM NetServer SMS connector to use in Customer Service. You need to set up an account with [CM][1] to get a username and password to connect to their service.

## Outgoing SMS configuration

Go to **System - SMS** inside the Service client or **Mailings - Settings** inside Sales & Marketing client. Choose CM in the list of available modules

In the **Plugin configuration** you add:

```text
cm_serviceId =
cm_username = cm_password =
```

![x -screenshot][img1]

Note - do not include the brackets.

<!-- Referenced links -->
[1]: https://www.cmtelecom.com/products/messaging/sms

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/cmsmssettings.png
