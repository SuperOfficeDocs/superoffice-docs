---
title: How to configure settings in SuperOffice Settings and maintenance
uid: configure-superoffice-admin
description: How to configure document templates for SharePoint Documents
author: Frode Berntsen
so.date: 11.02.2023
keywords: SharePoint, document, template
so.topic: howto
so.envir: cloud
so.client: online
---

# How to configure settings in SuperOffice Settings and maintenance

The configuration in Settings and maintenance is point-and-click. This part is primarily to select the values already created in the first part.

## SuperOffice Settings and maintenance​

You select your document library in **Settings and maintenance** > **Preferences** > **Document library**: ​

![SuperOffice Settings and maintenance document library – Location​ -screenshot][img9]

* Default is *SuperOffice document library*, and you can change that to SharePoint​.
* During configuration of your new document library, Settings and maintenance will show an intermediate state.​
* When you are finished and have confirmed that you will use SharePoint, the state in Settings and maintenance changes to *Microsoft SharePoint Online*.

> [!NOTE]
> It will be possible to change some of the settings in the Wizard later​.

## Five-step configuration ​wizard

![Microsoft SharePoint Online wizard header -screenshot][img1]

* Each of these steps must be filled in completely before you can move to the next step. The **Next step** button is disabled until you have finished the step.
* If **Next step** is disabled, use the **Save and Close** button to save your settings so far and return to finish the configuration later.
* The **Previous step** button takes you back one step.​
* Click **Discard changes** to cancel your edits.

## Step 1 – CRM compatibility

First, we run a set of validation test.

**Microsoft-login only:**

* For your integration to work properly, we support only users with Microsoft login. Users from other vendors / password login will not be able to create, edit, or delete documents, and that will cause problems.

* If not successful, this test will cause an error and you will not be allowed to proceed with the configuration.

    > [!NOTE]
    > If you need temporary access from consultants, those users must be set to former employees during configuration.

**User names:**

* We check that all users belongs to the same Microsoft domain. If they do not, that could cause issues when applying permissions to or creating SharePoint documents.

* If unsuccessful, this test will cause a warning with information, but you will still be able to proceed with the configuration.

![Microsoft SharePoint Online wizard CRM compatibility check -screenshot][img3]

## Step 2 – Sites and folders​

### ​SuperOffice documents - location, folders and filenames​

* **Site in SharePoint:** Choose your site from the dropdown. You must have permission level Owner to be able to select a site.

* **Document library:** Select from the drop-down​.

* **Folder structure:** You can select between​ User group, Author, Template type, Company name, and Project​. You can also organize the folders in Yearly subfolder​.

* **File name:** Select between Heading or Heading - Company name​.

### SuperOffice document templates

> [!NOTE]
> We recommend that you use SharePoint to store your new document templates, then you will be able to use Microsoft 365 online to edit them​.

* Just select Site in SharePoint and Document library from the dropdowns​.

  ![SuperOffice document templates – Location​ -screenshot][img2]

## Step 3 - Document properties​

Select **SuperOffice documents fields** to transfer as SharePoint document properties​.

We recommend that you select all here. These fields will appear as columns in your SharePoint document library​.

* Based on these fields you can create views in your SharePoint document library​. And you can choose to hide some of these fields there​.

    > [!NOTE]
    > To maintain changes to documents in SuperOffice, we must store the ID of the fields. You can hide these columns in your SharePoint document​.

* You can also search and group by these fields in SharePoint.​

    ![SuperOffice documents fields -screenshot][img10]

## <a id="step-4" />Step 4 - Groups and access​

![Groups and access​ -screenshot][img4]

### Confidentiality in SharePoint (Visible for)

Group access on SharePoint documents based on *Visible for* settings.

* If you plan **NOT to use Visible for**, leave this ticked off.​ Go to the next section.
* If you plan to **use Visible for** (or already do so), tick this checkbox. Follow the next steps.

To to set permissions on documents in SharePoint, the app needs to have *Read Write* permission to selected site. This is a one-time authorization and will include only the site you have selected for your SuperOffice documents.

### <a id="apps" />Apps for SuperOffice (system user)

To use any app for SuperOffice that interacts with documents (to use *Visible for*, to migrate documents, or have a third-party app that creates documents in SuperOffice), you need to [enable a system user][2]. We recommend you keep this on and go through the authorization.

### Authorize

> [!NOTE]
> This requires authorization by a Microsoft 365 Global Administrator. That user must also be in the owner group of the site (needs owner permission to the site to set Read Write permission)​.

1. Press **Authorize** to start the authorization process.

    * If you are a Microsoft 365 Global Administrator, you can authorize now.

    * If not, you must copy the URL and send it to someone with that role in your organization.​ If you wait for an authorization, you can press **Save and Close** and return to your settings later.

### Map user groups

When the SuperOffice app has been authorized, you can map your SuperOffice user groups to AD-groups within your document library.​

All SuperOffice user groups must be mapped before you can move to the next step.​

See the [reference of permissions in SharePoint​][1] for more information.

  ![Map your SuperOffice user groups to AD-groups within your document library -screenshot][img7]

## Step 5 - Review and confirm​

​Read carefully and make sure you have the correct settings. When you are sure, click **Confirm​**.

​    ![Review and confirm -screenshot][img8]

> [!CAUTION]
> After you have confirmed, **you will not be able to change the Site in SharePoint and Document library settings**.

<!-- Referenced links -->
[1]: permissions-in-sharepoint.md
[2]: permissions-app.md

<!-- Referenced images -->
[img1]: media/sharepoint-config-wizard.png
[img2]: media/template-location.png
[img3]: media/compatibility-check.png
[img4]: media/groups-and-access.png
[img7]: media/groups-and-access-ad.png
[img8]: media/confirm.png
[img9]: media/so-admin-document-library.png
[img10]: media/transfer-document-properties.png
