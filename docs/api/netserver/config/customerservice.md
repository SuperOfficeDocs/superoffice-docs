---
title: CustomerService element
uid: ns_config_customerservice
description: NetServer configuration values for accessing Customer Service
so.date: 12.08.2021
author: Bergfrid Dias
keywords: config, NetServer, web.config, CustomerService, CsCgiUrl, CsCgiUrlDirect, CsCgiUrlInternal, CsDomain, CsPassword, CsUserName, ImpersonateCsUser, CS, base path
so.topic: reference
so.envir:
---

# NetServer CustomerService element

Configuration values for accessing Customer Service

| Name | Description |
|---|---|
| CsCgiUrl | Base path for CustomerService as accessed from a browser when accessed from the internet and public URLs. Like customer center or links in mailings (Online only). |
| CsCgiUrlDirect | Base path for CustomerService as accessed from NetServer (Back-channel) (Online only). |
| CsCgiUrlInternal | Base path for CustomerService as used by an internal employee working with service (Front-channel from associate) (Online only). |
| CsDomain | The Active Directory Domain this user belongs to. |
| CsPassword | The password. |
| CsUserName | The username to impersonate. |
| ImpersonateCsUser | Impersonate a specific (Windows Domain) user when using Customer Service API. |

See the [NetServer Core reference][1] for details about handling this programmatically.

<!-- Referenced links -->
[1]: <xref:SuperOffice.Configuration.ConfigFile.CustomerService>
