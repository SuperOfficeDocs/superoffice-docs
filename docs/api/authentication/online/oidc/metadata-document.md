---
title: Metadata document
uid: oidc_metadata_document
description: OpenID Connect metadata document
author: {github-id}
keywords: oidc,authentication
so.topic: concept
so.envir: cloud
so.client: online
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
| Development | sod        |
| Stage       | qaonline   |
| Production  | online     |

## Example excerpt

[!include[ALT](./includes/oidc-metadata.md)]

<!-- Referenced links -->
[1]: ../../../../../superoffice-docs/docs/apps/getting-started/app-envir.md
