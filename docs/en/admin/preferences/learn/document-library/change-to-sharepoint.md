---
uid: help-en-document-library-change-to-sharepoint
title: Configure SharePoint document library
description: Configure SharePoint document library
author: SuperOffice RnD
so.date: 03.21.2023
keywords: document, SharePoint
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: en
---

# Configure SharePoint document library

> [!NOTE]
> Before you can start this configuration, you must set up your SharePoint site, libraries and permissions. All users must authenticate using Microsoft 365.

When you are configuring your new document library, Admin will show an intermediate state.

When you are finished and have confirmed that you will use SharePoint, the state in Admin changes to Microsoft SharePoint Online.

It is possible to change some of the settings in the Wizard later

**Steps:**

1. [!include[Open preferences](../includes/open-preferences.md)]
2. Select the **Document library** tab.
3. Click **Change**. The page is updated with information about the connected SharePoint site. The change is not yet complete.
4. Click **Complete the change** to confirm that you want to use SharePoint as the default document library. The change is now complete.
5. Click **Settings**.
6. Complete the four steps of the configuration wizard described below.

## Step 1 - Sites and folders

In this step you must configure location, folders and file names for your SuperOffice documents and templates.

### SuperOffice documents - location, folders and filenames

* **Site in SharePoint**: Select your site from the list.
* **Document library**: Select the library from the list.
* **Folder structure**: Select the preferred folder structure (folder names).
* **Organize the folders in annual subfolders**: Select this option to add subfolders per year.
* **Filename**: Select the preferred naming of files.

### SuperOffice document templates – Location

* **Site in SharePoint**: Select your site from the list.
* **Document library**: Select the library from the list.

Click **Next step** to continue.

## Step 2 - Document properties

In this step you must select which document fields to transfer as document properties from SuperOffice to SharePoint.

> [!NOTE]
> We recommend that you select all available fields. These fields will appear as columns in your SharePoint document library.

These fields can be used to create views in your SharePoint document library. You can also search and group by these fields in SharePoint. Specific fields can be hidden if necessary.

> [!NOTE]
> To maintain changes to documents in SuperOffice, we must store the ID of the fields. ID columns can be hidden in your SharePoint document views.

Click **Next step** to continue.

## Step 3 - Groups and access

In this step you can enable group access to SharePoint documents based on "Visible for" settings in SuperOffice.

If you plan not to use "Visible for", do not select this option.

1. Select **Enable group access to SharePoint documents based on "Visible for" settings in SuperOffice**.

2. To set permissions for documents in SharePoint, we need read/write permissions for the selected site. This is a one-time authorization and will include only the site you selected for your SuperOffice documents.

    > [!NOTE]
    > Only a Microsoft 365 Global Administrator can authorize these permissions. In addition, the Microsoft 365 Global Administrator must be a member of the owner group of the site, because site owner permissions are required to set read/write permissions.

    Do one of the following:

    * If you are a Microsoft 365 Global Administrator: Click **Authorize now** to authorize.

    * If you are NOT a Microsoft 365 Global Administrator: Click **Copy the authorization URL** and send it to a Microsoft 365 Global Administrator in your organization.

3. If you have to wait for an authorization, you have the following options:

    * Click **Save and close** to continue the configuration late. The page text is updated to indicate that authorization is pending.

    * Click **Check status again** to see if the Microsoft 365 Global Administrator has authorized the app.

4. For each SuperOffice user group, select the matching user group in SharePoint. All SuperOffice user groups must be mapped before you can go to the next step.

5. Click **Next step** to continue.

## Step 4 - Review and confirm

Review the configuration carefully and make sure the settings are correct.

After you confirm the settings, they cannot be edited:

SuperOffice documents

* Site in SharePoint
* Document library

SuperOffice document templates

* Site in SharePoint
* Document library

Click **Confirm** when you are done.

## Related topics

* [SharePoint documents][1] - technical overview

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/document/cloud/sharepoint-documents/index.html

<!-- Referenced images -->
