---
title: Which flow should you use?
uid: online_auth_scenarios
description: Authentication scenarios for various app types
author: {github-id}
keywords: authorization
so.topic: reference
so.envir: cloud
so.client: online
---

# Which flow should you use?

The following table is meant to assist you in determining which OAuth/OpenID Connect flow is best suited for your application type.

## Authentication scenarios for various app types

| App type | Native/mobile app | Single-page app (SPA) | Regular web app | non-interactive backend / API |
|----|----|----|----|----|
| User context    | Interactive | Interactive | Interactive | Non-interactive |
| Environment     | Runs on device or OS | Runs in browser | Runs on server | Runs on server |
| Flow            | [Native app flow][1] | [Implicit flow][2] | [Authorization Code flow][3], with or without PKCE | [SuperOffice system user flow][4] |
| Typical stack   | OS-specific | Javascript | .NET<br>PHP | web service<br> Windows service |
| App identifiers (keys) | client ID | client ID | client ID, client secret | client ID, client secret |
| Response tokens | ID token<br>access token<br>(refresh token) | ID token<br>(access token) | ID token<br>access token<br>(refresh token) | system user token<br>system user ticket |

*This overview has been simplified for the clarity of the presentation.*

<!-- Referenced links -->
[1]: sign-in-user/native-apps.md
[2]: sign-in-user/implicit-flow.md
[3]: sign-in-user/auth-code-flow.md
[4]: auth-application/index.md
