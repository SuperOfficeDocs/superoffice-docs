---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: twilio_sms_plugin       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Twilio NetServer SMS plugin # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto                 # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:              # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
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

![imagec3rg.png][img1]

<!-- Referenced links -->
[1]: https://www.twilio.com/sms

<!-- Referenced images -->
[img1]:media/imagec3rg.png
