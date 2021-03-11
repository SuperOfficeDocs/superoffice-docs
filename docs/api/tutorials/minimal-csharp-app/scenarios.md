---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: minimal_csharp_app_scenarios       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Scenarios       # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Scenarios

These scenarios walk you through the sample code and what happens when you run the sample.

![SystemUserSignInProcess.png][img1]

1. Administrator installs, or the user navigates to, partner application.
2. Redirect started because the user attempting to access to SuperOffice functionality has not been authenticated.
3. User is redirected to SuperID with client ID for authentication.
4. SuperID successfully authenticates the user and then sends them to the partner applications redirect URL.
5. Partner application receives SuperID request and JWT token. Validated using certificates.
6. Partner application processes/configures user and stores **system user token** in the database.
7. Partner service polls database for new tenant user tokens.
8. Partner service [signs user token with private key][1] and sends it to SuperID to exchange for a system user ticket.
9. Partner service [validates system user token][2] using certificates.
10. Partner service calls tenant web services using the system user ticket.

## Application code

The default page displays two action links.

### Create company with login user

The first link uses the current users' **SoSession** (Principal Context) to create a new company in the tenant SuperOffice. This is standard functionality used to contrast how to perform the same operation as a system user.

### Create company with system user

The second link uses a [system user token][3] to get a system user ticket, and then uses the system user ticket to authenticate and create a new company in the tenant database.

> [!CAUTION]
> This scenario is not the recommended way to leverage a system user in an application. Threading with a NetServer SoSession instance is a complex topic, and it is only here in this example as a demonstration of signing the token, sending the signed token to SuperID, and then validating the returned JWT token containing the system user ticket.

The preferred way to use a system user token is demonstrated in the [System Console project][4].

![x][img2]

<!-- Referenced links -->
[1]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/authentication/system-user/sign-system-user-token.md
[2]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/authentication/certificates/validate-security-tokens.md
[3]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/authentication/system-user/system-user-token.md
[4]: system-user-service-console.md

<!-- Referenced images -->
[img1]: media/systemusersigninprocess.png
[img2]: media/image017.jpg
