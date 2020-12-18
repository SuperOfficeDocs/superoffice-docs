---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: federated_sign_in_guide       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Guide to federated sign-in  # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: guide                     # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Guide to federated sign-in

This guide will take you briefly through the identity management steps to let your users sign in to SuperOffice CRM Online with Microsoft or Google.

**Pre-requisites****:**

* A SuperOffice CRM Online tenant (site) with existing users

* Compatible domain - [check my domain][1]

* SuperOffice administrator account

* Google or Microsoft account

* For Azure AD, you need to be Global Admin

## Guide

1. [Map usernames in SuperOffice Admin to UPNs][2] managed by the identity provider.

2. [Register your domain name][3] (IdP).

3. Ask each user to [sign in to complete account transformation][4].

## Standard sign-in with an identity provider

The next time the user signs in from **online.superoffice.com** and provide the correct user name or UPN, the user is forwarded to [SuperID][5] to establish which service to use.

Does the user's browser session **have an active session** from the identity provider?

* If **yes**, they will be silently signed in to CRM Online

* If **no**, they will be redirected to the provider to sign in

    ![SuperID login][img1]

## You might also be interested in

* [Create a new user in the Admin client][6]
* [Reset password][7]
* [User accounts and roles][8]
* [Sign-in services][9]
* [Federated identity][10]

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/technical/documentation/identity-management/how-to/federated-sign-in-guide/check-idp-domain/
[2]: https://community.superoffice.com/en/technical/documentation/identity-management/how-to/federated-sign-in-guide/map-idp-usernames/
[3]: https://community.superoffice.com/en/technical/documentation/identity-management/how-to/federated-sign-in-guide/register-idp/
[4]: https://community.superoffice.com/en/technical/documentation/identity-management/how-to/federated-sign-in-guide/complete-user-transition/
[5]: https://community.superoffice.com/en/technical/documentation/identity-management/concepts/superid/
[6]: https://community.superoffice.com/en/technical/documentation/identity-management/how-to/add-user-in-admin-client/
[7]: https://community.superoffice.com/en/technical/documentation/identity-management/how-to/reset-password/
[8]: https://community.superoffice.com/en/technical/documentation/identity-management/overview/user-accounts/
[9]: https://community.superoffice.com/en/technical/documentation/identity-management/overview/sign-in-services/
[10]: https://community.superoffice.com/en/technical/documentation/identity-management/overview/federated-id/

[img1]: ./media/superidlogin.png
