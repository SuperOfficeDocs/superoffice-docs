---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: add_hosting       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Application hosting # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: concept              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Application hosting

You are responsible for hosting your own applications, regardless if you develop standard applications for the SuperOffice App Store or custom applications for a specific customer.

SuperOffice will not bill, [provision][1], or host partner applications. Instead, the App Store redirects to our partners' websites where customers buy directly from the partner.

As a partner, you will have to host your applications in **your own cloud** environment. This could be in an environment managed by a group of partners or for example in their Azure or Amazon cloud.

In practical terms, this means that you must build and host a page that receives [JWT tokens][3] at the redirect URL. This page must be up and running before you attempt to connect to our APIs and authorize your application.

Before you get to authorization, you must sign up to get your unique [client IDs and client secret][4]. You must tell us about your callback/redirect [URLs][5] when you [sign up][6].

<!-- Referenced links -->
[1]: ../provisioning/index.md
[3]: ../authentication/certificates/validate-security-tokens.md
[4]: client-id-secret.md
[5]: redirects/index.md
[6]: get-app-keys.md