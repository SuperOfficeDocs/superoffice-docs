---
title: Troubleshooting Microsoft 365
uid: troubleshooting_office_365
description: Troubleshooting Microsoft 365 document integration
author: {github-id}
keywords:
topic: howto
envir: cloud
client: online
---

# Troubleshooting Microsoft 365 document integration

## Use correct site library type in SharePoint

The SuperOffice Archive needs to be a **Document library** and located on the Root area of your SharePoint site.

There is no support for configuring the Microsoft 365 integration to use a sub-site or a virtual site.

![Document library -screenshot][img1]

(1) = Root

(2) = Site collection (sub-site or a virtual site)

> [!CAUTION]
> A virtual site or sub-site will typically have an address of URL: `https://[your domain-name].sharepoint.com/sites/superoffice` **(not supported)**

### Archive path and Template Path is relative to Root of SharePoint

* The address of the **SharePoint domain name URL** will most likely be `https://[your domain-name].sharepoint.com`

A virtual site or a sub-site will typically have an address of URL: `https://[your domain-name].sharepoint.com/sites/superoffice` **(not supported)**.

* The SuperOffice Archive needs to be a **Document library**, and located on the root area:
  * At the root of your SharePoint site, click **New** and choose **Document library**.

The address of "Archive Path URL" will most likely be: `https://[your domain-name].sharepoint.com/SuperOffice_Archive/` (we will use the relative path to root `/SuperOffice_Archive/` for our setup).

A virtual site or subsite for the archive folder will typically have an address of URL: `https://[your domain-name].sharepoint.com/sites/superoffice/SuperOffice_Archive/` **(not supported)**.

* The *Template* folder is a **folder within** the SuperOffice Archive Document library. The address of Template Path URL will most likely be `https://[your domain-name].sharepoint.com/SuperOffice_Archive/Template/`
or
`https://[your domain-name].sharepoint.com/SuperOffice_Archive/Forms/AllItems.aspx?id=%2FSuperOffice_Archive%2FTemplate`
(we will use the relative path to Root or the SuperOffice Archive  `/SuperOffice_Archive/Template/` for our setup).

A virtual site or sub-site for the template folder will typically have an address of URL: `https://[your domain-name].sharepoint.com/sites/superoffice/SuperOffice_Archive/` **(not supported)**
or
URL: `https://[your domain-name].sharepoint.com/sites/superoffice/SuperOffice_Archive/Forms/AllItems.aspx?id=%2Fsites%2Fsuperoffice%2FSuperOffice_Archive%2FTemplate/` **(not supported).**

### Document Center

There is no support in the SuperOffice Microsoft 365 SharePoint integration for using **Document Center** for the SuperOffice Archive, it needs to be a **Document library**.

## Update access rights for the users

### During login to CRM Online with Microsoft 365 authentication activated

> [!NOTE]
> Not available for SuperID with IDP

* "We were unable to log you in through Microsoft 365. Error: access_denied."

![ Error: access_denied -screenshot][img2]

This is due to users do not have sufficient read access to the SharePoint Group area where the Integration App is, and/or users do not have sufficient read access to the SharePoint root area.

### During the upload of new templates or creating new documents in SharePoint

#### Error saving document

![Error saving document -screenshot][img3]

#### No access

![No access -screenshot][img4]

#### An error ocurred while saving

![No access -screenshot][img5]

1. Update access rights

    Either update access rights for the Root and/or the folder, or create a new Group with a minimum of **read** access, and add the users to this Group.

    You need **Edit** for documents (in the document library), and **read** (in the area of the App) for using the App for logging in. Therefore, in this scenario (logging in) user needs **read** (in the area of the App).

    **Create a new Group:**

    Admin > Admin centers > SharePoint > site collections > Open the web Site Address (...sharepoint.com) > Site contents > Site settings > Users and Permissions > Site Permissions  > Create Group > add users to this group.

    ![Create a new Group -screenshot][img6]

    ![Create a new Group -screenshot][img7]

    ![Create a new Group -screenshot][img8]

    ![Create a new Group -screenshot][img9]

    **Read** for root and the Document library should be enough for the Integration App.

    ![Read for Document library -screenshot][img10]

    **Modify existing groups:**

    ![Modify existing groups -screenshot][img11]

    ![Modify existing groups -screenshot][img12]

2. Check Permissions

    Use this to identify what the users' rights are and if they are sufficient for the task.

3. Correct document library name and folder names

If the document library name or folder name has any changes or was you submitted the wrong values during setup, make sure paths are relative to the root, and correct.

## (Re-)Adding trust to the app

* Adding trust to the app once more can resolve issues when there is something wrong with the app' permissions:

Admin > Admin centers > SharePoint > site collections > Open the web Site Address (...sharepoint.com) > Site contents > ... for the app > Manage permissions > click **click here to trust it again**:

![Adding trust to the app -screenshot][img13]

![Adding trust to the app -screenshot][img14]

## Check permissions

**Check permissions** under **Site Permissions** can also be helpful to sure users have access.

### Error when creating a document in CRM Online

* "Error saving document..."

![Error saving document -screenshot][img15]

This is due to users do not have sufficient read access to the SharePoint Root area or 'edit' access to the document library.

Either update access rights for the Root or the document library, or create a new Group with a minimum of **Edit**, and add the users to this Group:

Admin > Admin centers > SharePoint > site collections > Web Site Address (...sharepoint.com) > Settings for website > Area access rights > Permissions > add group.

You need **Edit** for documents (in the document library), and **read** (in the area of the App) for using the App for logging in.

## Edit scope of the app trust

If the app somehow asks for the wrong scope for what it trusts, the scope can be manually changed to **write** - to be able to have proper credentials when trying to create documents in SharePoint:

When the approval dialog show, edit the URL to include scope=Web.Write:

from `&scope=&` to `&scope=Web.Write&` and click the **Enter** button to update the page.

You then see the permissions it asks for are also changing. Now you can click **Trust it**.

![image8ses9u.png -screenshot][img16]

<!-- Referenced images -->

[img1]: media/o365rootsitecollection.png
[img2]: media/o365erroraccessdenied.png
[img3]: media/imagerlog.png
[img4]: media/imageqvkbj.png
[img5]: media/imagela1cd.png
[img6]: media/sitecontents.png
[img7]: media/siesettings.png
[img8]: media/setsitesettings2.png
[img9]: media/creategroup.png
[img10]: media/givegrouppermissions.png
[img11]: media/setsitesettings.png
[img12]: media/addusers.png
[img13]: media/appmanagepermissions.png
[img14]: media/trustagain.png
[img15]: media/o365errorcreatedocument.png
[img16]: media/image8ses9u.png
