---
uid: teams-deploy
title: Deploy SuperOffice for Teams
description: How to register your tenant, upload the app package, grant admin consent, and optionally push the app to users.
keywords: SuperOffice for Teams, Teams, deploy, admin, tenant registration, admin consent, setup policy
author:
date: 07.05.2026
version:
content_type: howto
category: integration
topic: SuperOffice for Teams
language: en
---

# Deploy SuperOffice for Teams

These steps are completed once per tenant by a Microsoft 365 or SuperOffice administrator.

> [!TIP]
> Setting up for yourself only? [Go to the user guide][5].

## Step 1 – Register your tenant

Before users can archive content, you must register the tenant in the SuperOffice for Teams portal.

1. Go to the [SuperOffice for Teams portal][1].
2. Sign in with your SuperOffice account.
3. Select the tenant you want to register.
4. Accept the terms and privacy policy.
5. Click **Save**.

After saving, you are redirected to the main page. Scroll down to download the Teams app package (.zip file). You will need this in the next step.

## Step 2 – Upload the app in the Teams admin center

During the pilot, the app package must be uploaded manually. This step will not be needed once SuperOffice for Teams is published in the Microsoft Teams app store.

1. Go to the [Teams admin center][2].
2. Click **Actions** in the top-right corner.
3. Select **Upload new app**.
4. Upload the SuperOffice for Teams .zip file.

## Step 3 – Grant admin consent

Admin consent allows SuperOffice for Teams to request the Microsoft permissions it needs to work on behalf of signed-in users.

1. In the Teams admin center, open **Teams apps > Manage apps**.
2. Find and open **SuperOffice for Teams**.
3. Go to the **Permissions** tab.
4. Click the **Grant admin consent** link.
5. Follow the Microsoft consent flow to approve the requested permissions.

> [!NOTE]
> If admin consent is not granted here, each user must request it individually the first time they sign in.

## Step 4 (optional) – Push the app to users

By default, users can find and install SuperOffice for Teams themselves from **Built for your org** in the Teams app store. If you want the app pre-installed for users, push it via a setup policy.

1. In the Teams admin center, open **Teams apps > Setup policies**.
2. Select an existing policy or create a new one.
3. Add **SuperOffice for Teams** under **Installed apps**.
4. Optionally, pin the app to the app bar so users can find it easily.
5. Save and apply the policy to the relevant users.

> [!WARNING]
> When you push SuperOffice for Teams through a setup policy, Teams sends a proactive welcome message from the bot to all users included in that policy – even if they have not opened the app themselves.

Apps installed this way are managed by the administrator. Users will not be able to remove the app themselves.

| Deployment method | Where users find the app | Users can uninstall |
|---|---|---|
| Admin uploads and grants consent only | Built for your org | Yes |
| Admin also pushes via setup policy | Added by your org (Manage your apps) | No – admin must remove it |

<!-- Referenced links -->
[1]: https://superofficeforteams.superofficeapps.com
[2]: https://admin.teams.microsoft.com/policies/manage-apps
[5]: get.md