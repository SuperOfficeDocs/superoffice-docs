---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: register_idp       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Register identity provider (domain name) # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: guide                      # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Register identity provider (domain name)

Before using a federated sign-in service, you must register the domain with us. This enables SuperID to recognize the domain of the user's email address and redirect to the correct identity provider for authentication.

>[!NOTE]
>Any user that can authenticate with the customer's domain can register **Google** as an identity provider.<br>To register **Microsoft** as an IdP and grant the SuperOffice ID Azure AD application access to read user profile information, the user should be Global Admin or App Admin.

## Pre-requisites

* You have [mapped the usernames][1] to your IdP.

* You are able to authenticate with the customer's domain. For Azure AD, Global Admin or Application Administrator is required.

## Start IdP registration

1. Go to [https://id.superoffice.com/identityprovider/register][2]

2. Select your organization's identity provider (Google or Microsoft)

    ![select identity provider][img1]

## Initialize and accept setup with your IdP

> [!NOTE]
> You are sent to the provider's sign-in page after starting registration.

### For Microsoft

1. Authenticate with your **Global admin** or **App admin** Azure AD account.

2. Accept the permissions and grant SuperOffice access to read profile information if prompted.

    ![0365signin.png][img2]

    ![googlesignin.png][img3]

3. Confirm that all users of this domain should use the identity provider.

    ![image95szq.png][img4]

### For Google

1. Authenticate with a Google account in the domain.

    ![google signin][img5]

2. Accept the permissions and grant SuperOffice access to read profile information if prompted.

3. Confirm that all users of this domain should use the identity provider.

    ![image1x2xg.png][img6]

## Confirm registration

![imageniwh.png][img7]

Your organization's domain name is now registered in the SuperOffice environment.

When the user signs in, the domain of the username (the part after the @ sign) will be recognized and the user will be forwarded to the correct IdP to authenticate.

![image62fbl.png][img8]

Primary domain registration complete!

After registering the IdP, existing password users has to sign in once to SuperOffice, to [complete the transition][3] from password to IDP for their accounts.

## Register additional domains

Organizations may have multiple domains. Additional domains used to sign in to SuperOffice, beyond the domain of the Global Admin or App Admin, must be added manually.

The Domain Name System (DNS) has a tree structure or hierarchy, which includes nodes on the tree being a domain name. A subdomain is a domain that is part of a larger domain. A custom domain is a unique branded name that identifies a website.

You may want to set a new primary domain name for your Azure AD organization. When your organization is created in Azure AD, the initial domain name, such as `contoso.onmicrosoft.com`, is also set as the primary domain name. The primary domain is the default domain name when you register the domain name. [Check out Microsoft's article on how to change the primary domain name][4].

You can find additional domains in your Azure Active Directory under **Custom domain names**.

**To register another top-level domain name:**

* Repeat the process outlined on this page with the new domain name.

**To register a sub-domain:**

* Submit form below and we will add it manually. For example, for our main domain `SuperOffice.**com**`, we have a sub-domain `SuperOffice.**no**`.

**To register a custom domain name:**

* Submit form below and we will add it manually. For example, for our main domain `SuperOffice.com`, we have a custom domain `suocrm.com`

![image9lq1a.png][img9]

1. [Register identity provider][1]
2. Your primary domain will be registered in SuperId
3. Fill out the form for subdomains and custom domain names
4. We will manually add those subdomains and custom domain names
5. Repeat the process for other top-level domain

**Note:** For those who do not use a custom domain name or subdomain name for your UPN/SuperOffice usernames, do not need to fill out the form for subdomains and custom domain names below.

<!-- Referenced links -->
[1]: map-idp-usernames.md
[2]: https://id.superoffice.com/identityprovider/register
[3]: complete-user-transition.md
[4]: https://docs.microsoft.com/en-us/azure/active-directory/enterprise-users/domains-manage/

<!-- Referenced images -->
[img1]: media/choose-idp.png
[img2]: media/o365signin.png
[img3]: media/o365confirm.png
[img4]: media/confirm-all-users-o365.png
[img5]: media/google-signin.png
[img6]: media/confirm-all-users-google.png
[img7]: media/confirmation.png
[img8]: media/signin-domain.png
[img9]: media/register-subdomains.png
