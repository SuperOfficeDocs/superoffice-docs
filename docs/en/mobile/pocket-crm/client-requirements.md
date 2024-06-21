---
title: Client requirements
uid: pocket_crm_client_requirements
description: Requirements for Pocket CRM mobile client
author: {github-id}
date: 09.12.2023
keywords:
topic: reference
client: pocket
---

# Requirements for Pocket CRM mobile client

## Operation system

* iOS - Pocket CRM client (Available from Apple App Store)
* Google Android - Pocket CRM client  (Available from Google Play)
* (Windows 10 - [End of Life][1])

### From Pocket CRM 9.1

iOS version 10 or newer is required.

## Network

[!include[Pocket network requirements](../includes/mobile-network-req.md)]

## Documents

Office documents need supported viewer software installed on the device.

## Email

The mobile app uses the same components as SuperOffice inbox in Web. See [web server requirements][2].

## Limitations

### Pocket client does not support AD authentication

There is only one way that **Pocket uses AD to authenticate** its users.

The user's credentials used to get past the login screen (there is no way around that - Pocket doesn't know how to collect the phone's AD credentials) must be in SO Admin setup as an AD user. That's it.

NetServer web service accepts the user's credentials and tries to authenticate the user the only way it knows how - using a chain of authentication resolvers. If the username passed in is a username with an associate id with a matching credential record of type "ActiveDirectory", then the credentials will be authenticated using the AD authentication routines.

Pocket CRM receives the result of the process and proceeds past the login screen with the authenticated user's principal and credentials ticket intact.

<!--Referenced links-->
[1]: https://community.superoffice.com/en/product-releases/whats-new/product/pocket-crm-app-end-of-life-for-the-microsoft-windows-10-mobile-phone/
[2]: ../../onsite/requirements/web-client.md
