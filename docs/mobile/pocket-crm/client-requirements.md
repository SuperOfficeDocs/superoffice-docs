---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: pocket_crm_system_requirements # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: System requirements for Pocket CRM mobile client # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: reference             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
#so.envir:                      # cloud or onsite
so.client: pocket               # online, web, win, pocket, or mobile
---

# System requirements for Pocket CRM mobile client

## Operation system

* iOS - Pocket CRM client (Available from Apple App Store)
* Google Android - Pocket CRM client  (Available from Google Play)
* (Windows 10 - [End of Life][1])

### From Pocket CRM 9.1

iOS version 10 or newer is required!

**Devices no longer supported:**

* iPhone 5 or older
* Pad 2 or older
* iPod Touch with ARM v 7 or older

Old devices will still be able to run Pocket CRM but they will not be able to upgrade or re-install.

## Network

[!include[Pocket network requirements](../includes/mobile-network-req.md)]

## Documents

Office documents need supported viewer software installed on the device.

## Email

The mobile app uses the same components as SuperOffice inbox in Web. See web server requirements.

## Limitations

### Pocket client does not support AD authentication

There is only one way that **Pocket uses AD to authenticate** its users.

The user's credentials used to get past the login screen (there is no way around that - Pocket doesn't know how to collect the phones AD credentials) must be in SO Admin setup as an AD user. That's it.

NetServer web service accepts the user's credentials and tries to authenticate the user the only way it knows how - using a chain of authentication resolvers. If the username passed in is a username with an associate id with a matching credential record of type "ActiveDirectory", then the credentials will be authenticated using the AD authentication routines.

Pocket CRM receives the result of the process and proceeds past the login screen with the authenticated user's principal and credentials ticket intact.

<!--Referenced links-->
[1]: https://community.superoffice.com/en/customer/inspiration/articlestandard-crm/pocket-crm-app-end-of-life-for-the-microsoft-windows-10-mobile-phone/