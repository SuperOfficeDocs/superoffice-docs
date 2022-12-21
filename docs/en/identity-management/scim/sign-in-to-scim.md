---
title: Sign in to SuperOffice Identity Manager
uid: sign_in_to_scim
description: Sign in to SuperOffice Identity Manager
author: {github-id}
keywords:
so.topic: howto
so.envir: cloud
so.client: online
---

# Sign in to SuperOffice Identity Manager

You need to sign in to our Identity Manager to set up and to update the mapping of users synchronized from Azure AD to SuperOffice.

## Pre-requisites

* A SuperOffice admin account linked to an Azure Active Directory account (AAD admin not required).

**Environments:**

| Environment | URL |
| ------------- | ------------- |
| Development (SOD) | [https://cloudintegration-sod.superoffice.com/app/scim-config][1] |
| Stage | [https://cloudintegration-stage.superoffice.com/app/scim-config][2] |
| Production | [https://cloudintegration.superoffice.com/app/scim-config][3] |

## To sign in

1. In a browser, go to `https://{environment}.superoffice.com/app/scim-config`

2. Sign in with your registered **SuperOffice admin account**.

    ![Sign-in dialog -screenshot][img1]
3. **Pick the Azure AD account** from the IdP. Enter your password if you are not already signed in.

    ![x -screenshot][img2]

    After authentication, the IdP redirects you back to the **Identity Manager start page**.

    ![x -screenshot][img3]

<!-- Referenced links -->
[1]: https://cloudintegration-sod.superoffice.com/app/scim-config
[2]: https://cloudintegration-stage.superoffice.com/app/scim-config
[3]: https://cloudintegration.superoffice.com/app/scim-config

<!-- Referenced images -->
[img1]: media/im-sign-in-dialog.png
[img2]: media/im-federation-dialog.png
[img3]: media/1st-im-sign-in-ok.png
