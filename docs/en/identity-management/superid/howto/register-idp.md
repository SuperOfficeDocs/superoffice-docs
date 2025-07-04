---
uid: register-idp
title: Register identity provider (domain name)
description: Register identity provider (domain name)
keywords: IdP, SuperID, Microsoft Entra, ME-ID, AAD
author: Frode Berntsen
date: 03.31.2025
version: 10.5
content_type: howto
deployment: online
platform: web
index: true
---

# Register identity provider (domain name)

Before using a federated sign-in service, you must register the domain with us. This enables SuperID to recognize the domain of the user's email address and redirect to the correct identity provider for authentication.

> [!NOTE]
> Any user that can authenticate with the customer's domain can register **Google** as an identity provider.
>
> To register **Microsoft** as an IDP and grant the SuperOffice ID Microsoft Entra application access to read user profile information, the user should be Global Admin or App Admin.

## Pre-requisites

* You have [mapped the usernames][1] to your IDP.

* You are able to authenticate with the customer's domain. For Microsoft Entra ID, Global Admin or Application Administrator is required.

## How does DP registration impact existing users?

A 'user-transition' (SuperOffice password -> Google/Microsoft authentication) for all existing users, on first log in after IDP registration is completed: users have to sign in once to SuperOffice, to [complete the transition][3] from password to IDP for their accounts.

No use of "SO password" any longer, but user is sent to Google/Microsoft for authentication on login to CRM Online.

## Start IDP registration

1. Go to [https://id.superoffice.com/identityprovider/register][2].

2. Select your organization's identity provider (Google or Microsoft).

    ![select identity provider -screenshot][img1]

## Initialize and accept setup with your IDP

> [!NOTE]
> You are sent to the provider's sign-in page after starting registration.

### For Microsoft

1. Authenticate with your **Global admin** or **App admin** Microsoft Entra account.

2. Accept the permissions and grant SuperOffice access to read profile information if prompted.

    ![Microsoft 365 sign-in -screenshot][img2]

    ![Microsoft 365 sign-in -screenshot][img3]

    ![Microsoft 365 sign-in -screenshot][img12]

3. Confirm that all users of this domain should use the identity provider.

    ![confirm-all-users-o365.png -screenshot][img4]

#### Explanation about requested permissions

SuperOffice application (Application Id d0c02962-eedd-4d1e-8a70-a315f1aa5072) is required for logging in and to support basic functionality for the user (delegated permission). The permission does not require Admin consent.  The reason for asking administrator to approve these permissions is to prevent that the individual user must consent to these permissions.

The delegated permissions required for the SuperOffice application are:

| Function | Permissions needed |
| ------ | -----------|
| Logging in | *User.Read*, *email*, *openid* and *profile*. Get basic information about the signed in user. |
| Email | The built-in e-mail client in the SuperOffice CRM product requires *IMAP.AccessAsUser.All* for receiving and *SMTP.Send* for sending e-mails on behalf of the user. *Offline_access* is needed for refreshing the mailboxes in background. |
| Video Meeting & Microsoft Teams | *OnlineMeetings* permissions is required to set up video meetings directly from the diary of the SuperOffice CRM product. |
| SharePoint document archive | The *Sites.Manage.All* and *Sites.ReadWrite.All* is required to create, read and write documents to SharePoint. |

### For Google

1. Authenticate with a Google account in the domain.

    ![Google sign-in -screenshot][img5]

2. Accept the permissions and grant SuperOffice access to read profile information if prompted.

3. Confirm that all users of this domain should use the identity provider.

    ![confirm-all-users-google.png -screenshot][img6]

## Confirm registration

![confirmation.png -screenshot][img7]

Your organization's domain name is now registered in the SuperOffice environment.

When the user signs in, the domain of the username (the part after the @ sign) will be recognized and the user will be forwarded to the correct IDP to authenticate.

![signin-domain.png -screenshot][img8]

Primary domain registration is complete!

After registering the IDP, existing password users have to sign in once to SuperOffice, to [complete the transition][3] from password to IDP for their accounts. New users added will be able to log in directly. Do note "Send welcome emails to new users" is 'on' by default.
The administrator can choose whether or not new users shall receive a welcome email with sign-in info when their account is created. Read more here: [send welcome emails][6].

## Register additional domains

Organizations may have multiple domains. Additional domains used to sign in to SuperOffice, beyond the domain of the Global Admin or App Admin, must be added manually.

The Domain Name System (DNS) has a tree structure or hierarchy, which includes nodes on the tree being a domain name. A subdomain is a domain that is part of a larger domain. A custom domain is a unique branded name that identifies a website.

You may want to set a new primary domain name for your Microsoft Entra organization. When your organization is created in Microsoft Entra ID, the initial domain name, such as `contoso.onmicrosoft.com`, is also set as the primary domain name. The primary domain is the default domain name when you register the domain name. [Check out Microsoft's article on how to change the primary domain name][4].

You can find additional domains in your Microsoft Entra admin center under **Custom domain names**.

![Custom domains -screenshot][img10]

![Custom domains -screenshot][img11]

**To register another top-level domain name:**

* Repeat the process outlined on this page with the new domain name.

**To register a sub-domain name or custom domain name:**

1. [Register identity provider][1].
2. Your primary domain will be registered in SuperID.
3. Fill out the [form for sub-domains and custom domain names][5].
4. We will manually add those subdomains and custom domain names.
5. Repeat the process for other top-level domains.

![register-subdomains.png -screenshot][img9]

<!-- Referenced links -->
[1]: map-idp-usernames.md
[2]: https://id.superoffice.com/identityprovider/register
[3]: complete-user-transition.md
[4]: https://learn.microsoft.com/en-us/entra/identity/users/domains-manage
[5]: custom-domains-registration-form.md
[6]: ../../user/send-welcome-emails.md

<!-- Referenced images -->
[img1]: media/choose-idp-green.png
[img2]: media/o365signin1-green.png
[img3]: media/o365confirm.png
[img4]: media/confirm-all-users-o365-green.png
[img5]: media/google-signin.png
[img6]: media/confirm-all-users-google-green.png
[img7]: media/confirmation-green.png
[img8]: media/signin-domain-green.png
[img9]: media/register-subdomains.png
[img10]: media/ms365customdomains1.png
[img11]: media/ms365customdomains2.png
[img12]: media/o365permissions1-green.png
