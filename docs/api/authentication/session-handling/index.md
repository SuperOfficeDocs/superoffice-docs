---
title: session_handling      
description: NetServer session handling
author: {github-id}             # Your GitHub alias.
keywords: authentication,principal
---

# Session handling

A new session is created when a user signs in and is successfully authenticated. **Session Cache** holds authentication information about the signed-in user, the associate of the user, a business ID of the company that the user belongs to, reference data, and so on. You can obtain the data held in the session cache through a property named `Principal` in the session object.

* [How to create a new session][1]
* [Suspending a session][2]
* [Switching between Sessions][3]

<!-- Referenced links -->
[1]: create-session.md
[2]: suspend-session.md
[3]: switch-sessions.md
