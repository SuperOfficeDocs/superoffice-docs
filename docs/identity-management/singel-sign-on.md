---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: singel_sign_on       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description:                    # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: SSO
so.topic: concept                      # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Single sign-on

Single sign-on (SSO) allows users to access multiple services with a single set of credentials. On the plus side, it facilitates a smoother user experience. On the flip side, you'll be more exposed if you lose "the keys to the castle".

## Cookies are a very basic form of SSO

1. You sign in to **SuperOffice** in one browser tab.

1. This creates a session and the browser stores a cookie.

1. You open a second tab and go to **SuperOffice.**

1. The browser checks the session cookie and grants you access without asking you to sign in again.

## Federated identity takes SSO a step further

With a [federated ID][1], you sign in once with this ID, and as long as the session is valid, you can access all other services that trust this identity provider without having to sign in again. In some cases, the user needs to give consent the 1st time they sign in to a new service provider with an IdP.

1. You sign in to your **Microsoft** email online.

2. You get a hall-pass in your browser's cookie jar.

3. You navigate to **SuperOffice** \- and boom - you're in!

Note that this is not the same as using the same username and password to sign in to different services! (Which is actually bad password hygiene.)

## What are my SSO options with SuperOffice?

* CRM online SuperID password sign-in

* CRM online SuperID wtih IdP; 3rd-party identity providers: Microsoft and Google

* [SuperOffice Onsite][2] with SSO

[Read more about our sign-in services][3]

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/technical/documentation/identity-management/overview/federated-id/
[2]: https://community.superoffice.com/en/technical/documentation/prepare/prepare-crm-server/prepare-web-server/IIS_Authentication/
[3]: https://community.superoffice.com/en/technical/documentation/identity-management/overview/sign-in-services/
