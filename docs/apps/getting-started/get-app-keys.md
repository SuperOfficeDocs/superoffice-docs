---
title: Get application keys
uid: get_app_keys
description: Get application keys
author: {github-id}
keywords: client ID, app ID
so.topic: howto
so.envir: cloud
so.client: online
---

# Get application keys

After signing up for a developer account, you need to register your application idea to get your unique client ID and client secret so you can start coding.

## Required info

* Name of your company
* Name and email of your technical contact
* Name of your application
* Standard or custom application
* Description of what your application will do and how it will interact with SuperOffice
* Which SuperOffice endpoints you need access to
* User context (application user or non-interactive)

## Relevant info

* Which kind of authorization flow you plan to use
* Whether you plan to access any restricted agents
* Your redirection endpoint
* Additional integrations and URLs

## Process

1. [Submit your application idea][1] (form).
    * You will get a confirmation that we have received your request.
2. We register your application in [SOD][2] and you will receive an email with instructions to get your application keys.
    * This is normally handled within the next business day.
    * We use SendSafely, an end-to-end encryption platform, to send you the client ID, the client secret, and any private encryption keys.
3. Save the application keys in a secure location. The SendSafely-message will expire!

**Next step:** Create an MVC application at your redirection endpoint and implement your chosen authorization flow.

<!-- Referenced links -->
[1]: https://community.superoffice.com/application-registration
[2]: app-envir.md
