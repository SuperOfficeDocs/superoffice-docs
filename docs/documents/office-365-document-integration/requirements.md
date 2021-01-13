---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: office_365_requirements       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Requirements for Office 365 integration # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud              # cloud or onsite
so.client: online             # online, web, win, pocket, or mobile
---

# Prerequisites for Office 365 integration

## IDP authentication

> [!WARN]
> Your SuperOffice Online tenant must use IDP authentication

* Read more about [How to configure IDP for SuperID][1]
* Please use [this form][2] to register your IDP for your domain

When users have successfully logged in using Azure to authenticate to CRM Online, you may start to use the Office365 SharePoint Integration.

## To use the integration

* A SuperOffice Online paid subscription (This app is available for all SuperOffice user plans).

* A Microsoft Office365 subscription (All users of the SuperOffice Online tenant must have and use a Microsoft Office365 user account). All Microsoft 365 users need minimum read access to Root of the SharePoint site.

* In O365: Azure Active Directory (used for authentication) (It is usually called: *Active Directory Integration*).

## To set up the integration

* Administrator access to SuperOffice Online tenant with administrator/User-level 0 type access.

* An Microsoft Microsoft 365 Admin account in the domain with Admin rights. This includes admin access to the SharePoint admin center, to configure and authorize SuperOffice to access data stored in your Microsoft 365 cloud during the set-up.

* In Microsoft 365: Activate **allow user to run custom scripts**  < 24 h. before setup

## Limitations

* The *SuperOffice Archive* and the *SuperOffice Template* folders need to be located on the Root of the SharePoint site, and not as a sub-site or a virtual site. See [Troubleshooting tips][3] for more information.

* To create new content types (see step 2), you need the SharePoint settings to **allow user to run custom scripts** activated < 24 h. before setup. You may perform the other steps in the meantime / create new content types at a later time.

<!-- Referenced links -->
[1]: ../../identity-management/superid/federated-sign-in-guide.md
[2]: https://id.superoffice.com/identityprovider/register
[3]: troubleshooting.md
