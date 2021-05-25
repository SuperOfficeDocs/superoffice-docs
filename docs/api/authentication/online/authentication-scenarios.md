---
title: authentication       
description:                    
author: {github-id}
keywords:
---

# Authentication

Use the left menu to learn more about authentication details.

The following table is meant to assist you determine which OAuth/OpenID Connect flow is best suited for your application type.

## Authentication scenarios for various app types

| App type | Native/mobile app | Single-page app (SPA) | Regular web app | non-interactive backend / API |
|----|----|----|----|----|
| User context | Interactive | Interactive | Interactive | Non-interactive |
| Environment | Runs on device or OS | Runs in browser | Runs on server | Runs on server |
| Flow | Native app flow | Implicit flow| Authentication code flow, with or without PKCE | SuperOffice system user flow |
| Typical stack | OS-specific | Javascript | .NET<br>PHP | web service<br Windows service |
| App identifiers (keys) | client ID | client ID | client ID, client secret | client ID, client secret |
| Response tokens | ID token<br>access token<br>(refresh token) | ID token<br>(access token) | | ID token<br>access token<br>(refresh token) | system user token<br>system user ticket |

*This overview has been simplified for the clarity of the presentation.*
