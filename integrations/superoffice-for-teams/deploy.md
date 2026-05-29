---
uid: teams-deploy
title: Deploy SuperOffice for Teams
description: How to register your tenant, upload the app package, grant admin consent, and optionally push the app to users.
keywords: SuperOffice for Teams, Teams, deploy, admin, tenant registration, admin consent, setup policy
author: schildea
date: 07.05.2026
content_type: howto
category: integration
topic: SuperOffice for Teams
language: en
---

# Deploy SuperOffice for Teams

These steps are done once per tenant by a Microsoft 365 or SuperOffice administrator.

> [!TIP]
> Setting up for yourself only? [Go to the user guide][5].

## Step 1 – Register your tenant

Before users can archive content to SuperOffice, an administrator must register the customer tenant in the SuperOffice for Teams portal. This step happens outside Teams and creates the tenant record the app needs.

To register the tenant:

1. Go to the SuperOffice for Teams portal: [https://superofficeforteams.superofficeapps.com][1]
1. Sign in with your SuperOffice account.
1. Select the tenant you want to register.
1. Accept the terms and privacy policy.
1. Save the settings.

After saving, you will be redirected to the main page. Scroll down to download the Teams app package (.zip file). You will need this file in the next step when uploading the app in the Teams admin center during the pilot.

![SuperOffice for Teams portal showing the Get Started section and Download Teams app button -screenshot][img1]

## Step 2 – Upload the app in the Teams admin center

During the pilot, the administrator uploads the SuperOffice for Teams app package as a .zip file in the Teams admin center. Once SuperOffice for Teams is published in Microsoft AppSource and the Teams app store, this manual upload step will no longer be needed.

To upload the app during the pilot:

1. Go to the Teams admin center: [https://admin.teams.microsoft.com/policies/manage-apps -screenshot][2]
1. Click **Actions** in the top right corner.
1. Select **Upload new app**.
1. Upload the SuperOffice for Teams app package (.zip file).

## Step 3 – Grant admin consent

After uploading the app, the administrator must grant admin consent in the Teams admin center. This allows SuperOffice for Teams to request the Microsoft permissions it needs to work on behalf of the signed-in user.

To grant admin consent:

1. Go to the Teams admin center.
1. Open **Teams apps > Manage apps**.
1. Find and open **SuperOffice for Teams**.
1. Go to the **Permissions** tab.
1. Click the **Grant admin consent** link in the information message.
1. Follow the Microsoft consent flow to approve the requested permissions.

> [!NOTE]
> If admin consent is not granted at this stage, each individual user will need to request consent from the administrator when they first try to sign in. Granting consent during setup helps avoid extra approval steps for users later.

## Step 4 (optional) – Push the app to users

After completing steps 1 through 3, users can find and install SuperOffice for Teams themselves from the Teams app store. During the pilot, they will find it under **Built for your org**. After publication, they will be able to find it through the normal Teams app store flow.

If you want the app to be ready for users without requiring them to install it themselves, you can push it to them through an app setup policy in the Teams admin center.

> [!WARNING]
> When you push SuperOffice for Teams through an app setup policy, Teams sends a proactive welcome message from the SuperOffice for Teams bot to all users included in that policy. This means users may receive an unsolicited Teams message, such as "Hello [name]. Welcome to SuperOffice for Teams!", even if they have not opened the app themselves yet.

To push the app to users:

1. Go to the Teams admin center.
1. Open **Teams apps > Setup policies**.
1. Select an existing policy or create a new one.
1. Add **SuperOffice for Teams** under **Installed apps**.
1. Optional: Pin the app to the app bar so users can find it more easily.
1. Save and apply the policy to the relevant users.

Keep in mind that apps installed this way are managed by the administrator. Users will not be able to remove the app themselves. Only an administrator can uninstall it or remove it from the setup policy.

If you want users to stay in control of their own installation, skip this step and let them install the app themselves from **Built for your org** during the pilot.

| Deployment method | Where users find the app | Users can uninstall |
|---|---|---|
| Admin uploads the app and grants consent only | Built for your org in the Teams app store | Yes |
| Admin also pushes the app through a setup policy | Added by your org in Manage your apps | No - an admin must remove it |

<!-- Referenced links -->
[1]: https://superofficeforteams.superofficeapps.com
[2]: https://admin.teams.microsoft.com/policies/manage-apps
[5]: get.md

<!-- Referenced images -->
[img1]: media/superoffice-for-teams-portal-download-app.png