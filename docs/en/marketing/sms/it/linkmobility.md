---
uid: pswincom-sms-connector
title: Link Mobility (PSWinCom)
description: Link Mobility (PSWinCom) NetServer SMS connector
keywords: Link Mobility, PSWinCom
author: SuperOffice Product and Engineering
date: 10.07.2025
content_type: howto
category: Marketing
topic: SMS
redirect_from: /en/service/sms/linkmobility
language: en
---

# Link Mobility (PSWinCom)

This document describes how to set up the Link Mobility PSWinCom NetServer SMS connector to use in Customer Service. You need to set up an account with Link Mobility and refer to the [PSWinCom][1] Gateway to get a username and password to connect to their service.

## Outgoing SMS configuration

Go to **System - SMS** inside the Service client or **Mailings - Settings** inside Sales & Marketing client. Choose PSWinCom SMS in the list of available modules

In the **Plugin configuration** you add:

```text
pswin_username =
pswin_password =
```

![x -screenshot][img1]

Note - do not include the brackets.

<!-- Referenced links -->
[1]: https://www.linkmobility.com/products/link-sms-gateway/

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/pswincomsmssettings.png
