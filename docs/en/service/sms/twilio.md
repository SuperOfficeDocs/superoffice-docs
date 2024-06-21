---
title: Twilio
uid: twilio_sms_plugin
description: Twilio NetServer SMS plugin
author: {github-id}
keywords:
topic: howto
---

# Twilio

This document describes how to set up the Twilio NetServer SMS plugin to use in Customer Service. You need to set up an account with [Twilio][1] to get an account id and auth token to connect to their service.

## Outgoing SMS Configuration from SuperOffice 8.4 SR6

Go to **System - SMS** inside the Service client or **Mailings - Settings** inside Sales & Marketing client. Choose Twilio SMS in the list of available modules

In the **Plugin configuration** you add:

```text
twilio_account_sid =
twilio_auth_token =
```

![imagec3rg.png -screenshot][img1]

<!-- Referenced links -->
[1]: https://www.twilio.com/sms

<!-- Referenced images -->
[img1]:media/imagec3rg.png
