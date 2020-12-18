---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: map_idp_usernames       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Update SuperOffice username to match IdP username  # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: guide                 # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Update SuperOffice username to match IdP username

Before using a federated sign-in service, you must update each SuperOffice username to match the IdP username.

The username also known as the **User-Principal-Name** (UPN) set in your IdP must match the username set in SuperOffice Admin.

**Pre-requisites:**

* SuperOffice administrator account

* Access to view user accounts of your identity provider

The username you are going to map to is commonly (but not always) the **primary email** registered to the user account at the identity provider: `user@domain`.

## Look up the IdP username

You can find the username in the **admin>users** section.

**For Microsoft:**

Go to [https://admin.microsoft.com/AdminPortal/Home#/users][1]

    ![UPN O365][img1] 

**For Google:**

Go to  [https://admin.google.com/ac/users][2]

    ![UPN Google][img2]

## Change username in SuperOffice Admin client

You **need to map each username** in SuperOffice Admin to the federated ID.

1. Select **Users** from the navigator in the Admin client.

2. For each user:

    1. Select the SuperOffice user to change.
    2. Enter the new username and click **Save**.

<!-- Referenced links -->
[1]: https://admin.microsoft.com/AdminPortal/Home#/users
[2]: https://admin.google.com/ac/users

[img1]: ./media/upn_o365.png
[img2]: ./media/upn_google.png
