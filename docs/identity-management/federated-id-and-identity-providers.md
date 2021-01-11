---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: federated_id_and_identity_providers       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Federated ID and identity providers                 # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author:              # Your GitHub alias.
keywords: 
so.topic: concept                   # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud                # cloud or onsite
so.client: online                # online, web, win, pocket, or mobile
---

# Federated ID and identity providers

Federated identity (FID) is a generic term for establishing a person's digital identity by delegating to a trusted 3rd party as opposed to a centralized domain of trust. It refers to where the user stores their credentials.

The trusted 3rd party is the **identity provider** (IdP). When accessing a new service, you have probably been presented with **Sign in with Facebook** or **Sign in with Google** as an alternative to creating a new user account.

For you as a user, this means that you can **use your existing account** to sign in to multiple services - fewer passwords to remember.

For you as an administrator, this means that you can [set up a SuperOffice account][1] simply by linking it to the federated ID.

Federated identity is related to [single sign-on (SSO)][2], however, SSO only pertains to the authentication part of federated identity management.

## How does it work?

When the user signs in to a service, instead of providing credentials to the service provider, the service provider trusts the identity provider to validate the credentials. **The user never provides credentials directly to anyone except for the identity provider.**

## Which identity providers do you support?

Today we support 2 different 3rd-party identity providers:

* Google Domains
  * Basic, Business and Enterprise of G Suite subscriptions include this
* Microsoft Azure AD (AAD)
  * Many of Office365 / Microsoft 365 subscriptions include this
  * Azure AD Premium P1 or higher.

>[!NOTE]
> For other identity providers who supports OpenID Connect/OAuth 2.0., please give your feedback, and we will look into adding support for it.

Other ways of achieving this can be to use:

* **Microsoft Hybrid Identity:** able to connect local AD
  * [microsoft.com - what-is-azure-ad-connect][3]
  * [microsoft.com - what-is-hybrid-identity][4]
    * If you don't have a Microsoft365 subscription, you probably need Azure AD Premium P1 or higher.  
        Consult Microsoft for cost and other considerations for setting up a Hybrid Identity.
* **Google Cloud Directory Sync**: sync from other system to Google

## Do I set it for all or for individual users?

The **use of IDP as the authentication method** is enabled/registered per domain name.

Users who have a SuperOffice username corresponding to this domain name will be automatically redirected to identity provider when logging in.

To be able to authenticate with your identity provider, your SuperOffice username needs to match your User Principal Name (UPN) at your identity provider.

Whether users sign in with a password or via a federated sign-in service depends on 2 things:

* Have you [registered an identity provider][5] (domain name)?
* Does that domain match the user's username or UPN?

If you answer *yes* to both questions, the federated identity is used. Otherwise, SuperID falls back to password-based sign-in.

> [!NOTE]
> Some user can have federated sign-in, and some password - depending on the domain-part of their SuperOffice username: name@**domain-name**

## Why should I use federated IDs?

It is easier for the user to sign in and it increases the security of your identity management solution.

* **Simplified sign-in:** uses your existing Microsoft or Google credentials. No SuperOffice password required.
* **Automatic sign-in** if you have an active browser session (if supported by the IdP!)
* Multi-factor authentication (**MFA**) / Two-factor authentication (2FA) / Two-step verification (if supported by the IdP!)
* **Leaner identity management** in the SuperOffice Admin client: entering the federated ID (UPN) will save you from typing in details.

<!-- Referenced links -->
[1]: user/add-user-in-admin-client.md
[2]: single-sign-on.md
[3]: https://docs.microsoft.com/en-us/azure/active-directory/hybrid/whatis-azure-ad-connect
[4]: https://docs.microsoft.com/en-us/azure/active-directory/hybrid/whatis-hybrid-identity
[5]: superid/register-idp.md
