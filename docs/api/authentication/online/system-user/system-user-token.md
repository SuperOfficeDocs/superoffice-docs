---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: system_user_token       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: System user tokens # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: concept             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# System user tokens

A _system user token_ is a  contract between an application and a tenant

This component is coupled with the [application][1] in the Operation Centre, and is only included in the JWT or `id_token` when an administrator signs in to SuperID.

Technically, the system user token is a String formatted as `NAME_OF_APP-<some_random_characters>` that:

* is unique for each [tenant][2] application
* will exist for the lifetime of the application
* is included in the JWT claims when an administrator signs in to the application

A system user token remains the same and will not change for the lifetime of the application.

## How is the system user token used?

The system user token is primarily a means to perform [non-interactive operations][3] on the APIs. It is:

* used to [obtain a valid system user ticket][4] credential from SuperID
* used by the application for all future background processing

This token is **not** used for direct access to any customer tenant web services. For that, you need the [system user *ticket*][5].

In the future, system user functionality will be replaced with OAuth 2.0 Client Credentials flow, which will not have the sliding expiration behavior.

![Non-interactive token flow][img1]

## Where does the system user token come from?

You will receive the system user token in the [JWT claim][6], or `id_token`.

* the token is only generated if system user token functionality is requested during application registration

![imagecxe1.png][img2]

* the token is only created and added as a claim when a customer administrator has successfully authenticated and [approved the application for the tenant][7]

It is up to the application to securely store the system user token.

<!-- Referenced links -->
[1]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/apps/index.md
[2]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/apps/tenant-status/index.md
[3]: system-user-flow.md
[4]: get-system-user-ticket.md
[5]: system-user-ticket.md
[6]: ../superid-token.md
[7]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/apps/provisioning/get-consent.md

<!-- Referenced images -->
[img1]: media/non-interactive-token-flow.jpg
[img2]: media/imagecxe1.png
