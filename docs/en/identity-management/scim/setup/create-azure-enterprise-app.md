---
title: Create an Azure AD enterprise application
uid: create_azure_enterprise_app
description: Create an Azure AD enterprise application
author: {github-id}
keywords:
so.topic: howto
so.envir: cloud
so.client: online
---

# Create an Azure AD enterprise application

Creating an Azure enterprise application is the 1st step to integrate the SuperOffice SCIM endpoint with the Azure AD provisioning service.

**Pre-requisites:**

* An Azure AD admin account.

* Access to Azure AD portal with permissions to create an enterprise application of type **non-gallery application** - **Azure Active Directory Premium** (P1 or P2) required.

For testing, you can do a [30-day free trial of AAD Premium][1]. If you obtain a new license to AAD, you might need to sign out and back in to activate the license.

## Sign in and add the application

1. In a browser, sign in to the [AAD portal][2].
2. From the left pane, select **Enterprise applications**.
3. Add your own non-gallery application:
    1. Click **\+ New application**.
    2. Select **All**.
    3. Click the **Non-gallery application** tile.
    4. Enter a name and click **Add**.

For updated info from Microsoft, see their guide to [build a SCIM endpoint and configure provisioning][3].

## Turn on automatic provisioning from AAD

1. Go to the app management screen and select **Provisioning** from the left pane.

2. Set **Provisioning mode** to **Automatic**.

    ![AAD provisioning panel -screenshot][img1]

## Configure admin credentials

1. Expand the **Admin Credentials** settings block.

2. [Get the SCIM config][4] from the SuperOffice Identity Manager.

3. Copy the **URL** into the **Tenant URL** field.

4. Copy the **Token** into the **Secret Token** field.

5. Click **Test Connection** and verify the connection between AAD and the SuperOffice SCIM endpoint.

6. Click **Save.**

![SCIM test connection from AAD -screenshot][img2]

## Configure mapping

The Azure portal allows mapping to the `id` attribute. However, this is **not** supported by SCIM and should not be used.

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
    3. Select the `**objectId**` attribute, enable the **Match objects using this attribute** option, set **Matching precedence** value to `1`, and click **OK**.

    ![Mapping groups -screenshot][img4]

4. Click **Save**.

## Start 1st synchronization and verify the result

1. Scroll down to **Settings.**
2. Select scope - do you want to sync all or only assigned users and groups?
3. Set **Provisioning status** to `**On**`.
4. Click **Save** to start the synchronization.
5. Wait for the incremental cycle to complete.
6. You can now [preview the users][5] in the SuperOffice Identity Manager.

![AAD provisioning settings -screenshot][img5]

## Next steps

* [Add SCIM rules][6] to set up your mapping in SuperOffice.
* [Subscribe to synchronization error messages][7].

<!-- Referenced links -->
[1]: https://developer.microsoft.com/en-us/microsoft-365/dev-program
[2]: https://aad.portal.azure.com/
[3]: https://docs.microsoft.com/en-us/azure/active-directory/app-provisioning/use-scim-to-provision-users-and-groups#step-4-integrate-your-scim-endpoint-with-the-azure-ad-scim-client
[4]: get-scim-config.md
[5]: ../provisioning/preview-sync.md
[6]: ../provisioning/add-scim-rule.md
[7]: get-sync-error-messages.md

<!-- Referenced images -->
[img1]: media/image3jfz4q.png
[img2]: media/image44zrl.png
[img3]: media/scim-aad-mapping-externalid.png
[img4]: media/imageq74vv.png
[img5]: media/imagexnbgj.png
