---
uid: twilio-sms-connector
title: Twilio
description: Twilio NetServer SMS connector
keywords: Twilio
author: SuperOffice Product and Engineering
date: 10.07.2025
content_type: howto
category: Marketing
topic: SMS
redirect_from: /en/service/sms/twilio
language: en
---

# Twilio

This document describes how to set up the Twilio NetServer SMS connector to use in Customer Service. You need to set up an account with [Twilio][1] to get an account id and auth token to connect to their service.

## Outgoing SMS configuration

Go to **System - SMS** inside the Service client or **Mailings - Settings** inside Sales & Marketing client. Choose Twilio SMS in the list of available modules

In the **Plugin configuration** you add:

```text
twilio_account_sid =
twilio_auth_token =
```

![imagec3rg.png -screenshot][img1]

<!-- Referenced links -->
[1]: https://www.twilio.com/sms

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/imagec3rg.png
