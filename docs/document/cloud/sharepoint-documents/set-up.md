---
title: How to setup Microsoft 365 SharePoint folders
uid: sharepoint-set-up
description: How to create a site and a document library in Microsoft 365 SharePoint
author: Bergfrid Dias
so.date: 06.20.2022
keywords: SharePoint, document
so.topic: how to
so.envir: cloud
so.client: online
---

# How to set up Microsoft 365 SharePoint folders

The set-up of the SharePoint site and document libraries is quite flexible, but we recommend to create a separate SharePoint site for your SuperOffice documents, and 2 document libraries: one for documents and a separate document library for templates.

## Step 1 - Create a SharePoint site in your Microsoft 365 SharePoint

> [!NOTE]
> If you plan to use **Visible for**, we recommend to set up the SharePoint site with a Microsoft 365 "service user", to avoid normal users (personal) / SuperOffice users do not have owner-rights.
>
> See the [reference of permissions in SharePoint​][1] for more information.

1. Open Microsoft 365 and sign in.
2. Open SharePoint from the menu.
3. Click **Create site**.

    ![SharePoint Create Site button -screenshot][img1]

4. Choose **Team site** as the type of site you would like to create. [Learn more][2].
5. Fill in the name of the site.
6. Choose privacy settings according to how you like it.

    ![SharePoint Add people -screenshot][img2]

7. Click **Finish**.

## Step 2 - Create a document library for documents in your SharePoint site

1. Open the site you created in step 1.

    ![SharePoint Recent list -screenshot][img3]

2. Click **New** and select **Document library**.

    ![SharePoint New document library -screenshot][img4]

3. Type a name for the new document library for your SuperOffice documents. We recommend **SuperOffice Documents**.

    ![SharePoint Create document library, SuperOffice Documents -screenshot][img5]

4. Click **Create**.

## Step 3 - Create a document library for templates in your SharePoint site

1. Open the site you created in step 1.

2. Click **New** and select **Document library**.

3. Type a name for the new document library for SuperOffice templates. We recommend **SuperOffice Templates**.

    ![SharePoint Create document library, SuperOffice Templates -screenshot][img6]

4. Click **Create**.

<!-- Referenced links -->
[1]: permissions-in-sharepoint.md
[2]: https://docs.microsoft.com/en-US/sharepoint/create-site-collection

<!-- Referenced images -->
[img1]: media/create-site-button.png
[img2]: media/add-people.png
[img3]: media/recent.png
[img4]: media/new-document-library.png
[img5]: media/create-document-library-documents.png
[img6]: media/create-document-library-templates.png
