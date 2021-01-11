---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: get_app_keys       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Get application keys # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Get application keys

After signing up for a developer account, you need to register your application idea to get your own unique client ID and client secret so you can start coding.

**Required info:**

* Name of your company
* Name and email of your technical contact
* Name of your application
* Standard or custom application
* Description of what your application will do and how it will interact with SuperOffice
* Which SuperOffice endpoints you need access to
* User context (application user or non-interactive)

**Relevant info:**

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

**Next step:** Create an MVC  application at your redirection endpoint and implement your chosen authorization flow.

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/developer/create-apps/resources/application-registration/
[2]: app-envir.md
