---
uid: smsteknik-sms-connector
title: SMSTeknik
description: Configuration of SMSTeknik NetServer SMS connector
keywords: SMSTeknik
author: SuperOffice Product and Engineering
date: 10.07.2025
content_type: howto
category: Marketing
topic: SMS
redirect_from: /en/service/sms/smsteknik
language: en
---

# Configuration of SMSTeknik NetServer SMS connector

This document describes how to set up the SMSTeknik NetServer SMS connector to use in Customer Service. You need to set up an account with [SMSTeknik][1] to get a username and password to connect to their service.

## Outgoing SMS configuration

Go to **System - SMS** inside the Service client or **Mailings - Settings** inside Sales & Marketing client. Choose SMS Teknik in the list of available modules

In the **Plugin configuration** you add:

```text
smsteknik_serviceId =
smsteknik_username =
smsteknik_password =
```

![x -screenshot][img1]

Note - do not include the brackets.

<!-- Referenced links -->
[1]: http://www3.smsteknik.se/tj%C3%A4nster/sms-gateway

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/smstekniksmssettings.png
