---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: oidc_metadata_document       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: OpenID Connect metadata document # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: oidc,authentication
so.topic: concept             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# OpenID Connect metadata document

OpenID Connect describes a metadata document, which contains most of the information required for an application to do sign-in. This includes information such as the URLs to use and the location of the service’s public signing keys.

The metadata is a simple JavaScript Object Notation (JSON) document.

 The OpenID Connect metadata document can be found at:

`https://{environment}.superoffice.com/login/.well-known/openid-configuration`

The **environment** sub-domain is unique to each [application environment:][1]

## Environment-specific sub-domains

| Environment | Sub-domain |
|-------------|------------|
| Development | sod |
| Stage | qaonline |
| Production | online |

## Example excerpt

[!include[ALT](./includes/oidc-metadata.md)]

<!-- Referenced links -->
[1]: ../../apps/getting-started/app-envir.md
