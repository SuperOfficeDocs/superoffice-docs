---
uid: help-en-sharepoint-documents-folders
title: How to set up the SharePoint folders
description: How to set up the SharePoint folders
author: Bergfrid Dias
so.date: 01.15.2024
keywords: document, Sharepoint
so.topic: howto
language: en
---

# How to set up the SharePoint folders

The setup of the SharePoint site and document libraries are quite flexible, but we recommend to create a **separate SharePoint site** for your SuperOffice Documents, and **two document libraries**: one for documents and one for document templates.

* In SharePoint, you can give permission on the site level or on the document library level:
Document libraries automatically inherit the permission from the site level.
Documents within the library inherit the permission from the library itself.

* SharePoint user groups:
  * In SharePoint you can create and maintain SharePoint user groups, which gives direct access to the documents for the users (by default you have an owner group, a member group and a visitor group).
  * You cannot use SharePoint user groups to set permission on the document level with SuperOffice SharePoint Documents. The integration needs to use Microsoft Entra domain groups. So, you must grant permissions to these groups.

* SharePoint site owner group:
  * When you create a site in SharePoint, you automatically get an *owner group*. Members of this owner group will have access to all documents within that site.
  * This access cannot be removed.
  * For that reason, you need to use an impersonal account to create your SharePoint site for SuperOffice Documents.

![Grant the different permissions on the site level in SharePoint, remember that the Document owners need Full Control -screenshot][img1]

## Related

* [Requirements][1]
* [How to configure SharePoint document library][3]
* [Manage your document templates][2]

<!-- Referenced links -->
[1]: index.md
[2]: ../../../../admin/lists/learn/add-template.md
[3]:https://docs.superoffice.com/en/document/cloud/sharepoint-documents/set-up.html

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/document/admin-preferences-documentlibrary-sharepoint-permissions.png
