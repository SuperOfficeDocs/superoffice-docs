---
title: Set up
uid: office-365-set-up
description: How to set up Microsoft 365 Cloud Office document integration
author: {github-id}
date: 06.20.2022
keywords: Microsoft 365, document
topic: howto
envir: cloud
client: online
---

# Set up Microsoft 365 Cloud Office document integration

This article will help you set up the Microsoft 365 part of the integration between Microsoft 365 and SuperOffice CRM Online.

[!include[Microsoft 365 app is deprecated](includes/deprecated.md)]

Setting up Microsoft 365 SharePoint Integration has 2 parts:

* How to setup Microsoft 365 to integrate into CRM Online:
  * Check if your SuperOffice CRM Online tenant is ready (pre-requisite step).
  * Configure the integration in your Microsoft 365 SharePoint (steps 1 - 3).
  * Enable the integration for your CRM Online site (step 4).
  * Configure your templates in SuperOffice Admin (step 5).

## Before you begin

Ensure you meet the [prerequisites][3] and read the [security considerations][7].

* During set-up, some details must be collected. These details will be used as parameters for setting the new configurations for your SuperOffice CRM Online site.
  * Your SuperOffice Online customer-specific URL, Cust ID (found in the browser URL while logged into SuperOffice Online), for instance, `http://online.superoffice.com/cust8123/`.

  > [!NOTE]
  > Write down the number of the "cust"-part of the URL as "Cust ID".

* To create new content types (see step 2), you need the SharePoint settings to **allow user to run custom scripts** activated < 24 h. before setup. You may perform the other steps in the meantime or create new content types at a later time.

* How to activate Custom Script:

1. Go to SharePoint admin center > settings tab > Custom Script section.
2. Set settings to "Allow users to run custom script on self-service created sites".

![Allow users to run custom script on self-service created sites -screenshot][img3]

For more information:

* [New Microsoft 365 admin user interface][4]
* [Old Microsoft 365 admin user interface][5]

## Step 1 - Create a document library in your Microsoft 365 SharePoint library

> [!NOTE]
> The *SuperOffice Archive* folder needs to be a **document library**, and this document library needs to be located on the root of the SharePoint site, and not as a sub-site or a virtual site. See [troubleshooting tips][7] for more information.

1. Open Microsoft 365 and log in as an admin user, go to Microsoft 365 "Admin".

    ![Microsoft 365 Admin -screenshot][img6]

2. Go to SharePoint under "Microsoft 365 admin center" -> Admin centers.

    ![Admin centers -screenshot][img7]

3. Open the root area of your SharePoint tenant – by choosing 'Sites' -> 'Active sites' from the left-hand menu.

    ![Active sites -screenshot][img8]

    > [!NOTE]
    > Write down this URL as "SharePoint domain name URL=".

    Example: `SharePoint domain name URL=https://[your_domain_name].sharepoint.com`

4. Click the root address (`https://[your_domain_name].sharepoint.com`) from the **Active sites** list.

    ![Active sites -screenshot][img9]

5. Open **Site contents** from the menu.

    ![Site contents -screenshot][img10]

6. Create a document library (used for SuperOffice documents) in the **root** area:
    1. Click **New** and choose **Document library**.
    2. Enter a name for your document library. **Example:** `SuperOffice_Archive`

    > [!NOTE]
    > Write down this name as "SO Archive Document Library Name="

    This is the name of the document library. It will be the relative path of your document library to the root folder: `https://[your_domain_name].sharepoint.com/SuperOffice_Archive/`

    Example: "SO Archive Document Library Name=/SuperOffice_Archive/"

    Make sure the document library exists on Root of SharePoint, and have correct access rights (minimum "Edit" ) for your users before continuing.

7. Create a 'template' folder (used for SuperOffice templates) in the SuperOffice Document library:
    1. Click **New** and choose **Folder**.
    1. Enter a name for your template folder. For example, *Template*

    > [!NOTE]
    > Write down this name as "Template Folder Name="

    ![Template Folder Name -screenshot][img11]

    Folder for templates, created inside the SuperOffice Document library. For example, *Template Folder Name=Template*

    Make sure the folder exists, and have correct access rights for your users before continuing.

## Step 2 – Setting up Document Content types in Microsoft 365 SharePoint

For creating new blank documents, spreadsheets, and presentations in SuperOffice CRM Admin (from a SharePoint template), we need to define several content types in SharePoint.

To create new content types, you need the SharePoint settings to "allow user to run custom scripts" activated < 24 h. before setup. You may perform the next steps in the meantime or create content types at a later time if you prefer.

This selection will fail if SuperOffice 'content types' are not set up in SharePoint:

![Edit list item -screenshot][img12]

1. Open Microsoft 365, and log in as an admin user, go to "Microsoft 365 admin center".
2. Go to SharePoint under "Admin centers".
3. Open "Active sites", and open the root area – by clicking the link `https://[your_domain_name].sharepoint.com` from the list.
4. Click the settings wheel-> Site Settings -> Site Content Types.

    ![Site Settings -screenshot][img13]

    ![Site Settings -screenshot][img14]

5. Click **Create**.

    ![Create Content types -screenshot][img15]

6. Set:
    1. Enter 'SuperOffice Blank Document' as name.
    1. Choose "Documents Content Types" / "Content types for documents" under 'Select parent content type from:'.
    1. Choose "Document" under 'Parent Content Type'.
    1. Enter SuperOffice as Group (Create the group if it's non-existing).

    ![Create Content types -screenshot][img16]

7. Click **OK**.

8. Navigate the list to your newly created content type and open it. Click Advanced settings.

    ![Content types advanced settings -screenshot][img17]

9. Select 'Upload a new document template:'. Choose a blank document from your computer. (Either <a href="../../../../../assets/downloads/cloud-office/blank.docx" download> download a pre-created blank document</a> or create a blank document from Office and stored locally).

10. Click **OK**.

11. Repeat step 6 - 13 for:

* SuperOffice Blank Spreadsheet (<a href="../../../../../assets/downloads/cloud-office/blank.xlsx" download>download .xlsx</a>)
* SuperOffice Blank Presentation (<a href="../../../../../assets/downloads/cloud-office/blank.pptx" download>download .pptx</a>)

### If you get an access error

**For new UI:**

1. Read [New Microsoft 365 admin user interface][4].

2. Go to the [Settings page of the new SharePoint admin center][12], and sign in with an account that has [admin permissions][13] for your organization. At the bottom of the page, select **classic settings page**.
Confirm whether the settings are configured to "Allow users from running custom script".

**For old UI:**

1. Read [Microsoft 365 admin user interface][14].

2. Go to SharePoint admin center > settings tab > Custom Script section >
confirm whether the settings are configured to "Allow users from running custom script".

    * Set them to "Allow users to run custom script" to see the outcome. The SharePoint settings "Allow user to run custom scripts" can take < 24 h. before activated. You may perform the other steps in the meantime or create the content types at a later time.

## Step 3 – Adding the SuperOffice Integrator App in Microsoft 365 SharePoint

### 1. Add or upload the app manually

Since we’re not in Office Store, we have to do this manually:

1. In "SharePoint admin center" - click "apps" from the menu.

2. Open "Customer apps" from the "Active sites" page (click URL) or go via "Advanced" and choose "Apps" -> "Apps catalog".

    ![Apps catalog -screenshot][img25]

    ![Apps catalog -screenshot][img26]

    ![Apps catalog -screenshot][img27]

    If you don’t have an **App Catalog** from before – choose to create a new one, for example:

    * Title: Custom apps
    * Web Site Address: `https://[your_domain_name].sharepoint.com/sites/apps/`
    * Administrator: [any admin/currently logged-in user]
    * Server Resource Quota: 20

    The App Catalog is now being created – and available to be used within about 5 minutes.

    <!-- markdownlint-disable-next-line MD044 -->
3. Download the SuperOffice SharePoint App <a href="../../../../../assets/downloads/cloud-office/cloud-office-SuperOffice.zip" download>SuperOffice.Microsoft 365.Integrator.app</a> locally.

4. Choose "Apps for SharePoint" in the menu. ![Apps catalog -screenshot][img30]

5. Click upload and choose the local file *SuperOffice.Microsoft 365.Integrator.app*.

    ![SuperOffice Integration app -screenshot][img31]

6. Click **OK**. The App is now Uploaded – and available to be used on your SharePoint site within about 10 minutes.

    ![SuperOffice Integration app uploaded -screenshot][img31]

### To use the App on your SharePoint site - Add the App to the site

1. Go back to Grup Area: Open the Root area – by opening the link `https://[your_domain_name].sharepoint.com` from the **SharePoint admin centre** menu by clicking the link `https://[your_domain_name].sharepoint.com` from the list

2. Click **Site contents** in the menu:

    ![SuperOffice Integration app -screenshot][img32]

3. Click **New** from the dropdown inside the Grup Area, and choose **App**.

    Inside "Your Apps" – Apps you can add – you should now see "SuperOffice Online Integration" (if it is not in the list yet - it might take a few minutes before it is available. Try again in a few minutes).

4. Click on it to open the app details.

    ![SuperOffice Integration app details -screenshot][img33]

    (if you are not able to add it yet - it might take a few minutes before it is available to add. Try again in a few minutes).

    ![SuperOffice Integration app details -screenshot][img34]

5. Add it by clicking **Trust It** to approve.

    ![SuperOffice Integration app details -screenshot][img35]

    Once added - the SuperOffice Integration app should now be in the Group Area.

    ![SuperOffice Integration app in group area -screenshot][img36]

6. SharePoint users who will use this app for logging in to CRM Online will need "read" access to the root folder of SharePoint (see [Troubleshooting tips][7] for more information and options on how to enable it).

## Step 4 – Notify SuperOffice to activate Microsoft 365 document integration

To turn on the Microsoft 365 SharePoint integration for your CRMOnline tenant, submit the following details:

* "Cust ID"
* "SharePoint domain name URL"
* "SO Archive Document Library Name"
* "SO Template Folder Name"

> [!NOTE]
> Once we receive the form submission, we will activate the feature as soon as possible, and the feature will then be ready to use the following day. (Your site must be recycled to get the new configurations.)

**Use [this form][17] for submitting the details to us.**

You will get a notification from SuperOffice R&D Services when the Microsoft 365 SharePoint integration is activated.

When it is ready to use, you may continue to set up the templates, to make use of the Microsoft 365 SharePoint integration.

## Step 5 - Configure your templates in SuperOffice Admin

This will store the template in the Microsoft 365 cloud. When the user uses this template, the document created will also be saved in the Microsoft 365 cloud and opened with Word Online.

1. Open SuperOffice Admin, go to Lists, choose **Document - Template**.

2. Click **Add**.

3. Add template file:

    * Enter a name.
    * Set **Store template in** to "Office365".
    * Choose the source of the new template (create, upload, or copy).
    * Click **Save**.

4. Optionally edit the template name, if required, and click **Edit** to edit the template file itself.

5. Enter the required information in the **Details** and **Languages** tabs:

    * Select **Direction** (outgoing or incoming).
    * Choose where to store document created by this template: set **Document stored in** to "Office365".
    * Enter a value in the **Our reference (default)** field using [template variables][1]. For example `auth` for the sender’s first and last names.
    * Optionally, enter a description.

6. Click **Save**. The Document template is now available in the CRM client

> [!NOTE]
> All documents written in SuperOffice will be stored in the SharePoint cloud if the template is set up for it, and available to open and edit in SuperOffice CRM Online.

* If you want to use Microsoft 365 to edit SuperOffice templates, the SuperOffice templates need to be moved from SuperOffice to Microsoft 365 SharePoint.

* Existing documents will not automatically be moved from SuperOffice to Microsoft 365 SharePoint.

* Moving existing **documents** to or from SuperOffice and Microsoft 365 SharePoint is not supported.

* Moving existing **templates** to or from SuperOffice and Microsoft 365 SharePoint can be performed in the Admin client.

<!-- Referenced links -->
[1]: ../../../templates/learn/template-variables.md
[3]: requirements.md
[4]: https://docs.microsoft.com/en-us/sharepoint/allow-or-prevent-custom-script
[5]: https://social.technet.microsoft.com/wikicontents/articles/37533.sharepoint-online-how-to-enable-custom-script.aspx
[7]: troubleshooting.md
[12]: https://admin.microsoft.com/sharepoint?page=migrationCenter&modern=true
[13]: https://docs.microsoft.com/en-us/sharepoint/sharepoint-admin-role
[14]: https://social.technet.microsoft.com/wiki/contents/articles/37533.sharepoint-online-how-to-enable-custom-script.aspx
[17]: https://crm.superoffice.com/scripts/customer.fcgi?action=formFrame&formId=20

<!-- Referenced images -->
[img3]: media/o365customscripts.png
[img6]: media/imagebx1f.png
[img7]: media/image18cb.png
[img8]: media/imagesgm93.png
[img9]: media/image4e5im.png
[img10]: media/imagetrxas.png
[img11]: media/imageujv6m.png
[img12]: media/o365createnewtemplate.png
[img13]: media/imageu49ea.png
[img14]: media/o365sitecontenttypes.png
[img15]: media/o365sitesettingscreatecontenttypes.png
[img16]: media/o365createdocumentcontenttype.png
[img17]: media/o365contenttypeadvanced.png
[img25]: media/imagedtyeq.png
[img26]: media/imagev7ojr.png
[img27]: media/image69pt4.png
[img30]: media/imagekoepi.png
[img31]: media/imageydark.png
[img32]: media/image6e0ta.png
[img33]: media/imagebnc9j.png
[img34]: media/imagezfo3m.png
[img35]: media/image61nqk.png
[img36]: media/o365appadded.png
