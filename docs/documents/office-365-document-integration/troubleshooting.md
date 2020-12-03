---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: troubleshooting_office_365       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Troubleshooting Office 365 document integration # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: article                # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud              # cloud or onsite
so.client: online             # online, web, win, pocket, or mobile
---

# Troubleshooting Office 365 document integration

## Use correct site library type in SharePoint (a)

The SuperOffice Archive needs to be a “Document library”, and located on the Root area of your SharePoint site.

There is no support for configuring the Office365 integration to use "sub-site" or a "virtual site".

![x][1]

(1) = Root

(2) = Site collection ("sub-site" or a "virtual site")  

> [!CAUTION]
> A virtual site or "sub-site" will typically have an address of URL: `https://[your domain-name].sharepoint.com/sites/superoffice` **(not supported)**

### Archive path and Template Path is relative to Root of SharePoint

* The address of the **SharePoint domain name URL** will most likely be `https://[your domain-name].sharepoint.com`

A virtual site or subsite will typically have an address of URL: `https://[your domain-name].sharepoint.com/sites/superoffice` **(not supported)**

* The SuperOffice Archive needs to be a **Document library**, and located on the root area:
  * At the root of your SharePoint site, click **New** and choose **Document library**.

The address of “Archive Path URL" will most likely be: `https://[your domain-name].sharepoint.com/SuperOffice_Archive/` (we will use the relative path to root `/SuperOffice_Archive/` for our setup)

A virtual site or subsite for the archive folder will typically have an address of URL: `https://[your domain-name].sharepoint.com/sites/superoffice/SuperOffice_Archive/` **(not supported)**

* The **Template** folder is a **folder within** the SuperOffice Archive “Document library”. The address of “Template Path URL" will most likely be `https://[your domain-name].sharepoint.com/SuperOffice_Archive/Template/`
or
`https://[your domain-name].sharepoint.com/SuperOffice_Archive/Forms/AllItems.aspx?id=%2FSuperOffice_Archive%2FTemplate`
(we will use the relative path to Root or the SuperOffice Archive  `/SuperOffice_Archive/Template/` for our setup)

A virtual site or sub-site for the template folder will typically have an address of URL: `https://[your domain-name].sharepoint.com/sites/superoffice/SuperOffice_Archive/` **(not supported)**
or  
URL: `https://[your domain-name].sharepoint.com/sites/superoffice/SuperOffice_Archive/Forms/AllItems.aspx?id=%2Fsites%2Fsuperoffice%2FSuperOffice_Archive%2FTemplate/` **(not supported)**

### Document Center

There is no support in the SuperOffice Office365 SharePoint integration for using **Document Center** for the SuperOffice Archive, it needs to be a **Document library**.

## Update access rights for the users (b)

### During login to CRM Online with O365 authentication activated (N/A for SuperId with IDP)

* "We were unable to log you in through Office 365. Error: access\_denied."

![x][2]

This is due to users does not have sufficient read access to the SharePoint Group area where the Integration App is, and/or users do not have sufficient read access to the SharePoint root area

### During upload of new templates or creating new documents in SharePoint

#### Error saving document

![imagerlog.png][3]

#### No access

![imageqvkbj.png][4]

#### An error ocurred while saving

![imagela1cd.png][5]

1. Update access rights

Either update access rights for the Root and/or the folder, or create a new Group with a minimum of "read" access, and add the users to this Group.

You need "Edit" for documents (in the document library), and "read" (in the area of the App) for using the App for logging in. Therefore, in this scenario (logging in) user needs "read" (in the area of the App).

**Create a new Group:**

Admin -> Admin centers -> SharePoint -> site collections -> Open the web Site Address (...sharepoint.com) -> Site contents -> Site settings -> \[Users and Permissions\] -> Site Permissions  -> Create Group -> add users to this group

![x][6]

![x][7]

![x][8]

![x][9]

"Read" for root and the “Document library” should be enough for the Integration App

![x][10]

**Modify existing groups:**

!x[][11]

![x][12]

2. Check Permissions

Use this to identify what the users' rights are, and if they are sufficient to the task.

3. Correct document library name and folder names

If the document library name or folder name has changes or was you submitted the wrong values during setup, make sure paths are relative to the root, and correct.

## (Re-)Adding trust to the app (c)

* Adding trust to the app once more can resolve issues when there is something wrong with the app' permissions:

Admin -> Admin centers -> SharePoint -> site collections -> Open the web Site Address (...sharepoint.com) -> Site contents -> \[...\] for the app -> Manage permissions -> click "click here to trust it again":

![x][13]

![x][14]

## Check permissions (d)

**Check permissions** under "Site Permissions" can also be helpful in making sure users have access.

### Error when creating a document in CRM Online

* "Error saving document..."

![x][15]

This is due to users do not have sufficient read access to the SharePoint Root area or 'edit' access to the document library.

Either update access rights for the Root or the document library, or create a new Group with a minimum of "Edit", and add the users to this Group:

Admin -> Admin centers -> SharePoint -> site collections -> Web Site Address (...sharepoint.com) -> Settings for website -> Area access rights -> Permissions -> add group

 You need "Edit" for documents (in the document library), and "read" (in the area of the App) for using the App for logging in.

## Edit scope of the app trust (e)

If the app somehow asks for the wrong scope for what it trusts, the scope can be manually changed to "write" - to be able to have proper credentials when trying to create documents in SharePoint:

When the approval dialog show, edit the URL to include scope=Web.Write:

from `&scope=&` to `&scope=Web.Write&` and click the **Enter** button to update the page.

You then see the permissions it ask for is also changing. Now you can click **Trust it**.

![image8ses9u.png][16]

<!-- Referenced links -->
[1]: https://community.superoffice.com/contentassets/6172620ecdb4492292b5962b7c455735/o365rootsitecollection.png
[2]: https://community.superoffice.com/contentassets/6172620ecdb4492292b5962b7c455735/o365erroraccessdenied.png
[3]: https://community.superoffice.com/contentassets/138afe13308e4bdfa1cc567b3fb6048d/imagerlog.png
[4]: https://community.superoffice.com/contentassets/138afe13308e4bdfa1cc567b3fb6048d/imageqvkbj.png
[5]: https://community.superoffice.com/contentassets/138afe13308e4bdfa1cc567b3fb6048d/imagela1cd.png
[6]: https://community.superoffice.com/contentassets/6172620ecdb4492292b5962b7c455735/sitecontents.png
[7]: https://community.superoffice.com/contentassets/6172620ecdb4492292b5962b7c455735/siesettings.png
[8]: https://community.superoffice.com/contentassets/6172620ecdb4492292b5962b7c455735/setsitesettings2.png
[9]: https://community.superoffice.com/contentassets/6172620ecdb4492292b5962b7c455735/creategroup.png
[10]: https://community.superoffice.com/contentassets/6172620ecdb4492292b5962b7c455735/givegrouppermissions.png
[11]: https://community.superoffice.com/contentassets/6172620ecdb4492292b5962b7c455735/setsitesettings.png
[12]: https://community.superoffice.com/contentassets/6172620ecdb4492292b5962b7c455735/addusers.png
[13]: https://community.superoffice.com/contentassets/6172620ecdb4492292b5962b7c455735/appmanagepermissions.png
[14]: https://community.superoffice.com/contentassets/6172620ecdb4492292b5962b7c455735/trustagain.png
[15]: https://community.superoffice.com/contentassets/6172620ecdb4492292b5962b7c455735/o365errorcreatedocument.png
[16]: https://community.superoffice.com/contentassets/138afe13308e4bdfa1cc567b3fb6048d/image8ses9u.png