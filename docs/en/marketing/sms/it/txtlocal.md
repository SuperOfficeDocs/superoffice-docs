---
uid: txtlocal-sms-connector
title: TxtLocal
description: Configuration of TxtLocal NetServer SMS connector
keywords: TxtLocal
author: SuperOffice Product and Engineering
date: 10.07.2025
content_type: howto
category: Marketing
topic: SMS
redirect_from: /en/service/sms/txtlocal
language: en
---

# Configuration of TxtLocal NetServer SMS connector

This document describes how to set up the TxtLocal NetServer SMS connector to use in Customer Service. You need to set up an account with [TxtLocal][1] to get a username and password to connect to their service.

## Outgoing SMS configuration

Go to **System - SMS** inside the Service client or **Mailings - Settings** inside Sales & Marketing client. Choose TXTLocal in the list of available modules

In the **Plugin configuration** you add:

```text
txtlocal_username = txtlocal_password =
```

![x -screenshot][img1]

Note - do not include the brackets.

<!-- Referenced links -->
[1]: http://www.textlocal.com/

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/txtlocalsmssettings.png
