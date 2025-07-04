---
title: Create a Microsoft Entra enterprise application
uid: create_azure_enterprise_app
description: Create a Microsoft Entra enterprise application
author: SuperOffice Product and Engineering
date: 09.04.2024
keywords: IdP, SCIM, Microsoft Entra, ME-ID, AAD
content_type: howto
deployment: online
platform: web
index: true
---

# Create a Microsoft Entra enterprise application

Creating a Microsoft Entra (formerly Azure Active Directory) enterprise application is the first step to integrate the SuperOffice SCIM endpoint with the Microsoft Entra provisioning service.

**Pre-requisites:**

* A Microsoft Entra admin account.

* Access to Microsoft Entra admin center with permissions to create an enterprise application of type **non-gallery application** - **Microsoft Entra Premium** (P1 or P2) required.

For testing, you can do a [30-day free trial of Microsoft Entra ID Premium][1]. If you obtain a new license to Microsoft Entra ID, you might need to sign out and back in to activate the license.

## Sign in and add the application

1. In a browser, sign in to the [Microsoft Entra admin center][2].
2. From the left pane, select **Enterprise applications**.
3. Add your own application:
    1. Click **\+ New application**.
    2. Select **All**.
    3. Click **Create your own application**.
    4. Enter a name.
    5. Select **Integrate any other application you don't find in the gallery (Non-gallery)**.
    6. Click **Add**.

For updated info from Microsoft, see their guide to [build a SCIM endpoint and configure provisioning][3].

## Turn on automatic provisioning from Microsoft Entra ID

1. Go to the app management screen and select **Provisioning** from the left pane.

2. Set **Provisioning mode** to **Automatic**.

    ![Microsoft Entra provisioning panel -screenshot][img1]

## Configure admin credentials

1. Expand the **Admin Credentials** settings block.

2. [Get the SCIM config][4] from the SuperOffice Identity Manager.

3. Copy the **URL** into the **Tenant URL** field.

4. Copy the **Token** into the **Secret Token** field.

5. Click **Test Connection** and verify the connection between Microsoft Entra ID and the SuperOffice SCIM endpoint.

6. Click **Save.**

![SCIM test connection from Microsoft Entra ID -screenshot][img2]

## Configure mapping

The Microsoft Entra portal allows mapping to the `id` attribute. However, this is **not** supported by SCIM and should not be used.

1. Expand the **Mappings** settings block.
2. Customize the attribute mapping of `**externalId**` for user objects:
     1. Select the user attribute set.
     2. Change the default mapping of `**externalId**` from `mailNickName` to `objectId`.
     3. Enable the **Match objects using this attribute** option.
     4. Set **Matching precedence** to `2`.
     5. Click **OK**.

    ![Mapping external ID -screenshot][img3]

3. Change the attribute mapping for group objects to match on `objectId` rather than `displayName`:

    1. Select the group attribute set.
    2. Select the **`displayName`** attribute, change **Matching precedence** value to `2`, and click **OK**.
    3. Select the **`objectId`** attribute, enable the **Match objects using this attribute** option, set **Matching precedence** value to `1`, and click **OK**.

    ![Mapping groups -screenshot][img4]

4. Click **Save**.

## Start 1st synchronization and verify the result

1. Scroll down to **Settings.**
2. Select **scope** - do you want to sync all or only assigned users and groups?
3. Set **Provisioning status** to **`On`**.
4. Click **Save** to start the synchronization.
5. Wait for the incremental cycle to complete.
6. You can now [preview the users][5] in the SuperOffice Identity Manager.

![Microsoft Entra provisioning settings -screenshot][img5]

## Next steps

* [Add SCIM rules][6] to set up your mapping in SuperOffice.
* [Subscribe to synchronization error messages][7].

<!-- Referenced links -->
[1]: https://developer.microsoft.com/en-us/microsoft-365/dev-program
[2]: https://entra.microsoft.com/
[3]: https://learn.microsoft.com/en-us/entra/identity/app-provisioning/use-scim-to-provision-users-and-groups#step-4-integrate-your-scim-endpoint-with-the-azure-ad-scim-client
[4]: get-scim-config.md
[5]: ../provisioning/preview-sync.md
[6]: ../provisioning/add-scim-rule.md
[7]: get-sync-error-messages.md

<!-- Referenced images -->
[img1]: media/scim-provisioning-automatic.png
[img2]: media/scim-admin-credentials.png
[img3]: media/scim-aad-mapping-externalid.png
[img4]: media/scim-mapping-objectid-precedence.png
[img5]: media/scim-incremental-cycle-completed.png
