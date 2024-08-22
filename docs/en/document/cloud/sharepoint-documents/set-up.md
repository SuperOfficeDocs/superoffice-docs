---
title: How to setup Microsoft 365 SharePoint
uid: sharepoint-set-up
description: How to create a site and a document library in Microsoft 365 SharePoint
author: Bergfrid Dias, ErikLebiko
date: 01.12.2024
keywords: SharePoint, document
topic: how to
envir: cloud
client: online
---

# How to set up Microsoft 365 SharePoint

The set-up of the SharePoint site and document libraries is quite flexible, but we recommend to create a separate SharePoint site for your SuperOffice documents, and 2 document libraries: one for documents and a separate document library for templates.

## <a id="step-1"></a>Step 1 - Create a SharePoint site in your Microsoft 365 SharePoint

> [!NOTE]
> If you plan to use **Visible for** (confidentiality), we recommend to set up the SharePoint site with a Microsoft 365 "service user", to avoid normal users (personal) / SuperOffice users do not have owner-rights.
>
> See the [reference of permissions in SharePoint​][1] for more information.

1. Go to SharePoint.
1. Follow the instructions in Microsoft Learn on how to [create a site in SharePoint][2].
1. Choose **Team site** as the type of site you would like to create.
1. If you plan to use **Visible for**, you should use **Private** for privacy settings.

## <a id="step-2"></a>Step 2 - Create library for documents in SharePoint site

1. Open the site you created in step 1.

    ![SharePoint Recent list -screenshot][img3]

2. Click **New** and select **Document library**.

    ![SharePoint New document library -screenshot][img4]

3. Type a name for the new document library for your SuperOffice documents. We recommend **SuperOffice Documents**.

    ![SharePoint Create document library, SuperOffice Documents -screenshot][img5]

4. Click **Create**.

## <a id="step-3"></a>Step 3 - Create library for templates in SharePoint site

1. Open the site you created in step 1.

2. Click **New** and select **Document library**.

3. Type a name for the new document library for SuperOffice templates. We recommend **SuperOffice Templates**.

    ![SharePoint Create document library, SuperOffice Templates -screenshot][img6]

4. Click **Create**.

<!-- Referenced links -->
[1]: permissions-in-sharepoint.md
[2]: https://docs.microsoft.com/en-US/sharepoint/create-site-collection

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/document/recent.png
[img4]: ../../../../media/loc/en/document/new-document-library.png
[img5]: ../../../../media/loc/en/document/create-document-library-documents.png
[img6]: ../../../../media/loc/en/document/create-document-library-templates.png
