---
title: Federated ID and identity providers
uid: federated_id_and_identity_providers
description: Federated ID and identity providers
author:
date: 01.15.2024
keywords: IDP, identity provider, Microsoft Entra ID, ME-ID, AAD
content_type: concept
deployment: online
platform: web
index: true
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

We support 2 different 3rd-party identity providers:

* Google Domains
  * Basic, Business, and Enterprise of Google Workspace subscriptions include this
* Microsoft Entra ID (ME-ID, formerly Azure Active Directory)
  * Many Microsoft 365 subscriptions include this
  * Microsoft Entra ID Premium P1 or higher.

>[!NOTE]
> Use Microsoft or Google as federation gateway with your custom IDP.

Other ways of achieving this can be to use:

* **Microsoft Hybrid Identity:** able to connect local Active Directory
  * [microsoft.com - what-is-azure-ad-connect][3]
  * [microsoft.com - what-is-hybrid-identity][4]
    * If you don't have a Microsoft 365 subscription, you probably need Microsoft Entra ID Premium P1 or higher.
        Consult Microsoft for cost and other considerations for setting up a Hybrid Identity.
* **Google Cloud Directory Sync**: sync from another system to Google

## Do I set it for all or for individual users?

The **use of IDP as the authentication method** is enabled/registered per domain name.

Users who have a SuperOffice username corresponding to this domain name will be automatically redirected to the identity provider when logging in.

To be able to authenticate with your identity provider, your SuperOffice username needs to match your User Principal Name (UPN) at your identity provider.

Whether users sign in with a password or via a federated sign-in service depends on 2 things:

* Have you [registered an identity provider][5] (domain name)?
* Does that domain match the user's username or UPN?

If you answer *yes* to both questions, the federated identity is used. Otherwise, SuperID falls back to password-based sign-in.

> [!NOTE]
> Some users can have federated sign-in, and some password, depending on the domain-part of their SuperOffice username: name@**domain-name**

## Why should I use federated IDs?

It is easier for the user to sign in and it increases the security of your identity management solution.

* **Simplified sign-in:** uses your existing Microsoft or Google credentials. No SuperOffice password is required.
* **Automatic sign-in** if you have an active browser session (if supported by the IdP!)
* Multi-factor authentication (**MFA**) / Two-factor authentication (2FA) / Two-step verification (if supported by the IdP!)
* **Leaner identity management** in the SuperOffice Admin client: entering the federated ID (UPN) will save you from typing in details.

<!-- Referenced links -->
[1]: user/add-user-in-admin-client.md
[2]: single-sign-on/index.md
[3]: https://learn.microsoft.com/en-us/entra/identity/hybrid/connect/whatis-azure-ad-connect
[4]: https://learn.microsoft.com/en-us/entra/identity/hybrid/whatis-hybrid-identity
[5]: superid/howto/register-idp.md
