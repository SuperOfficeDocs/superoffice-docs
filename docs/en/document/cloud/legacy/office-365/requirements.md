---
title: Pre-requisites for Microsoft 365 integration
uid: office_365_requirements
description: Requirements for Microsoft 365 integration
author: frodeb
date: 01.15.2024
keywords: Microsoft Entra
topic: reference
envir: cloud
client: online
---

# Pre-requisites for Microsoft 365 integration

## IDP authentication

> [!WARNING]
> Your SuperOffice Online tenant must use IDP authentication.

* Read more about [How to configure IDP for SuperID][1].
* Please use [this form][2] to register your IDP for your domain.

When users have successfully logged in using Microsoft Entra to authenticate to CRM Online, you may start to use the Microsoft 365 SharePoint Integration.

## To use the integration

* A SuperOffice Online paid subscription (This app is available for all SuperOffice user plans).

* A Microsoft 365 subscription (All users of the SuperOffice Online tenant must have and use a Microsoft 365 user account). All Microsoft 365 users need minimum read access to Root of the SharePoint site.

* In Microsoft 365: Microsoft Entra ID (formerly AAD, used for authentication) (It is usually called: *Active Directory Integration*).

## To set up the integration

* Administrator access to SuperOffice Online tenant with administrator/User-level 0 type access.

* A Microsoft 365 Admin account in the domain with Admin rights. This includes admin access to the SharePoint admin center, to configure and authorize SuperOffice to access data stored in your Microsoft 365 cloud during the set-up.

* In Microsoft 365: Activate **allow user to run custom scripts**  < 24 h. before setup.

## Limitations

* The *SuperOffice Archive* and the *SuperOffice Template* folders need to be located on the Root of the SharePoint site, and not as a sub-site or a virtual site. See [Troubleshooting tips][3] for more information.

* To create new content types (see step 2), you need the SharePoint settings to **allow user to run custom scripts** activated < 24 h. before setup. You may perform the other steps in the meantime / create new content types at a later time.

<!-- Referenced links -->
[1]: ../../../../identity-management/superid/howto/federated-sign-in-guide.md
[2]: https://id.superoffice.com/identityprovider/register
[3]: troubleshooting.md
