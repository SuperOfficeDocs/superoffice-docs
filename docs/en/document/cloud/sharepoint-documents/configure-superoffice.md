---
title: How to configure settings in SuperOffice Admin
uid: configure-superoffice-admin
description: How to configure document templates for SharePoint Documents
author: Frode Berntsen
so.date: 10.05.2023
keywords: SharePoint, document, template
so.topic: howto
so.envir: cloud
so.client: online
---

# How to configure settings in SuperOffice Admin

The configuration in the SuperOffice Admin is point-and-click. This part is primarily to select the values already created in the first part.

## SuperOffice Admin client​

You select your Document library in Admin - Preferences - Document library: ​

![SuperOffice Admin document library – Location​ -screenshot][img9]

* Default is SuperOffice document library, and you can change that to SharePoint​.
* When you are configuring your new document library, Admin will show an intermediate state.​
* When you are finished and have confirmed that you will use SharePoint, the state in Admin changes to Microsoft SharePoint Online.

> [!NOTE]
> It will be possible to change some of the settings in the Wizard later​.

## Configuration ​wizard

The wizard has four steps:​

![Microsoft SharePoint Online wizard -screenshot][img1]

* Each of these steps must be filled in completely before you can move to the next step. The **Next step** button will be disabled until you have finished the step.
* If the **Next step** is disabled, you will have a **Save and Close** button, which allows you to save your settings so far and return to finish the configuration later.
* You will also have a **Previous step** button to take you back one step.​
* You can also use **Discard changes** which means all your changes will be discarded.​

## Step 1 – Sites and Folders​

### ​SuperOffice documents - location, folders and filenames​

* Site in SharePoint: Just choose your site from the dropdown. You must have permission level Owner to be able to select a site.
* Document library: Select from the drop-down​.
* Folder structure: You can select between​ User group, Author, Template type, Company name, and Project​. You can also organize the folders in Yearly subfolder​.
* File name: Select between Heading or Heading - Company name​.

### SuperOffice document templates

> [!NOTE]
> We recommend that you use SharePoint to store your new document templates, then you will be able to use Microsoft 365 online to edit them​.

* Just select Site in SharePoint and Document library from the dropdowns​.

  ![SuperOffice document templates – Location​ -screenshot][img2]

## Step 2 - Document properties​

Select **SuperOffice documents fields** to transfer as SharePoint document properties​.

We recommend that you select all here. These fields will appear as columns in your SharePoint document library​.

* Based on these fields you can create views in your SharePoint document library​. And you can choose to hide some of these fields there​.

    > [!NOTE]
    > To maintain changes to documents in SuperOffice, we must store the ID of the fields. You can hide these columns in your SharePoint document​.

* You can also search and group by these fields in SharePoint.​

    ![SuperOffice documents fields -screenshot][img10]

## <a id="step3" />Step 3 - Groups and access​

### Confidentiality in SharePoint (Visible for)

Group access on SharePoint documents based on `Visible for` settings
* If you plan not to use `Visible for`, you leave this ticked off​.
* If you plan to use `Visible for`, you tick this on – and follow the next steps.

### Apps for SuperOffice (system user)

To use any app for SuperOffice that interact with documents (ie. to be able to use `visible for`, to migrate documents or have a third-party app that creates documents in SuperOffice), you need to enable a system user and add the `SuperOffice Document Library` app to your SharePoint. Read more about the `SuperOffice Document Library` app in [Permissions for SuperOffice Document Library integration (app)][2]

​    ![Groups and access​ -screenshot][img4]

### Confidentiality in SharePoint (Visible for) is ticked on​

* To to set permissions on documents in SharePoint, the app need to have `Read Write` permission to selected site. Only Microsoft 365 Global Administrator can authorize this permissions. This is a one-time authorization and will only include the site you have selected for your SuperOffice documents.

* If you are a Microsoft 365 Global Administrator, you can authorize now – if not, you must copy the URL and send it to someone with that role of Microsoft 365 Global administrator in your organization.​

* That user also needs to be in the owner group of the site (needs owner permission to the site in order to set Read Write permission)​.

    If you wait for an authorization, you can press **Save and Close** and return to your settings later.

    ![Enable group access on SharePoint documents based on Visible for settings in SuperOffice ticked on -screenshot][img5]

If you wait for an authorization, and return to the Wizard, this page will be shown.

You can also **Check status again** to see if Microsoft 365 Global administrator has authorized the app.

As soon as someone has authorized the SuperOffice app, you will see the next page and will be able to map your SuperOffice user groups to AD-groups within your document library.​

​    ![see if Microsoft 365 Global administrator has authorized the app -screenshot][img6]

When the SuperOffice app has been authorized, you can map your SuperOffice user groups to AD-groups within your document library.​

All SuperOffice user groups needs to be mapped before you can move to the next step.​

See the [reference of permissions in SharePoint​][1] for more information.

  ![map your SuperOffice user groups to AD-groups within your document library -screenshot][img7]

## Step 4 - Review and confirm​

​Read carefully and make sure you have the correct settings. When you are sure – click **Confirm​**.

​    ![Review and confirm -screenshot][img8]

> [!CAUTION]
> When you have confirmed **you will not be able to change the Site in SharePoint and Document library settings**.

<!-- Referenced links -->
[1]: permissions-in-sharepoint.md
[2]: permissions-app.md

<!-- Referenced images -->
[img1]: media/sharepoint-wizard.png
[img2]: media/template-location.png
[img4]: media/groups-and-access.png
[img5]: media/groups-and-access-2.png
[img6]: media/groups-and-access-authorization.png
[img7]: media/groups-and-access-ad.png
[img8]: media/confirm.png
[img9]: media/so-admin-document-library.png
[img10]: media/transfer-document-properties.png
