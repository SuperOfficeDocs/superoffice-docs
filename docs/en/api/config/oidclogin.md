---
title: OidcLogin element
uid: ns_config_oidclogin
description: NetServer utility class to get access to values related to CRM OIDC login
so.date: 12.08.2021
author: Bergfrid Dias
keywords: config, NetServer, web.config, OidcLogin, OIDC
so.topic: reference
so.envir: cloud
---

# NetServer OidcLogin element

Utility class to get access to values related to CRM OIDC login.

| Name | Description |
|---|---|
| Authority | OpenID Connect authority/well-Known URL ([Authority]/.well-known/openid-configuration must return discovery document.) |
| ClientId | ClientID for SuperOffice CRM, different for each environment/Identity Provider. |
| IsSSOEnabled | Is SSO enabled for tenant? |
| UserNameClaim | Claim to get userName from external identity token. |

See the [NetServer Core reference][1] for details about handling this programmatically.

<!-- Referenced links -->
[1]: <xref:SuperOffice.Configuration.ConfigFile.OidcLogin>
