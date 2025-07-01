---
title: Sign in to SuperOffice Identity Manager
uid: sign_in_to_scim
description: Sign in to SuperOffice Identity Manager
author: SuperOffice Product and Engineering
date: 01.15.2024
keywords: IdP, Microsoft Entra, ME-ID, AAD, SCIM
content_type: howto
deployment: online
platform: web
index: true
---

# Sign in to SuperOffice Identity Manager

You need to sign in to our Identity Manager to set up and to update the mapping of users synchronized from Microsoft Entra ID (formerly AAD) to SuperOffice.

## Pre-requisites

* A SuperOffice admin account linked to a Microsoft Entra account (Microsoft Entra admin not required).

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
3. **Pick the Microsoft Entra account** from the IdP. Enter your password if you are not already signed in.

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
