---
uid: compaya-sms-connector
title: Compaya
description: Compaya NetServer SMS connector
keywords: Compaya
author: SuperOffice Product and Engineering
date: 10.07.2025
content_type: howto
category: Marketing
topic: SMS
redirect_from: /en/service/sms/compaya
language: en
---

# Compaya

This document describes how to set up the Compaya NetServer SMS connector to use in Customer Service. You need to set up an account with [Compaya][1] to get a username and password to connect to their service.

## Outgoing SMS configuration

Go to **System - SMS** inside the Service client or **Mailings - Settings** inside Sales & Marketing client. Choose Compaya SMS in the list of available modules

In the **Plugin configuration** you add:

```text
compaya_username=[username]
compaya_password=[password]
```

![x -screenshot][img1]

Note - do not include the brackets.

<!-- Referenced links -->
[1]: http://www.compaya.dk/

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/compayasmssettings.png
