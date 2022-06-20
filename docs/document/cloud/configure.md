---
title: Configure
uid: cloud_document_config
description: Configure - Cloud Office document handling
author: {github-id}
keywords:
so.topic: howto
so.envir: cloud
so.client: online
---

# Configure - Cloud Office document handling

The Microsoft 365 and Google Workspace Integration apps integrate the document-management features of Microsoft 365 SharePoint and Google Drive with CRM Online so that you can create, store, and find your documents within SuperOffice, and enjoy the benefits of both SuperOffice and Microsoft 365 or Google Workspace services all in one place.

Simply sign in to SuperOffice using your Microsoft 365 or Google login details and then open, edit and store documents in Microsoft 365 SharePoint or Google Workspace directly from SuperOffice.

To start using the Integration, setup consists of 2 steps:

1) How to set up [Microsoft 365][3] or [Google Workspace][2] to integrate to CRM Online.

2) How to configure the document templates for use, is documented in this article.

In standard CRM Online, all templates are stored in CRM Online storage ("SO Archive") and are set to save the files users create also in CRM Online storage ("SO Archive").

Even with the integration set up - you may still use "SO Archive" for your templates and documents - but then without the benefits of Microsoft 365 or Google Workspace services.

> [!NOTE]
> There is one selection for where to store the template: **Store template in:** and one selection for where to store the file created based on this template: **Document stored in:**.
>
> For most users, the important choice is **Document stored in:** because this is the criteria for where the document is created, and how it is opened (Word Online / Google Drive).

## Create a SuperOffice template for your cloud document integration

This will store the template in the Microsoft 365 cloud or Google cloud, and when the user uses this template - the document created will also be saved in the Microsoft 365 or Google cloud and opened with Google Drive or Word Online.

Templates are displayed as items in the **Document - Template** list and you link a template to SuperOffice CRM by entering it as an item in the list.

![imageh3map.png -screenshot -screenshot][img1]

1. Open SuperOffice Admin, go to Lists, choose **Document - Template**.

2. Click **Add**.

3. Add template file:

    * Enter a name.
    * Set **Store template in** to either "Google" or "Office365".
    * Choose the source of the new template (create, upload, or copy).
    * Click **Save**.

    ![x -screenshot -screenshot][img2]

4. Optionally edit the template name, if required, and click **Edit** to edit the template file itself.

5. Enter the required information in the **Details** and **Languages** tabs:

    * Select **Direction** (outgoing or incoming).
    * Choose where to store document created by this template: set **Document stored in** to either  "Google" or "Office365".
    * Enter a value in the **Our reference (default)** field using [template variables][1]. For example `auth` for the sender’s first and last names.
    * Optionally, enter a description.

    ![x -screenshot][img3]

6. Click **Save**. The Document template is now available in the CRM client:

![imagedmnmi.png -screenshot -screenshot][img4]

![image6r9sc.png -screenshot -screenshot][img5]

## Considerations

To be able to edit the **template** in Google Drive or Word Online, it must be located in the Microsoft 365 / Google cloud. If this is not a requirement, the template can stay put in CRM Online storage (SO Archive) if you like.

If you want to change where the original templates store new documents created - you can do this by changing the original template property "Document stored in:". This will not move the template itself.

If you want to move the template from CRM Online storage (SO Archive) to Google / Microsoft 365, click **Add** in Document Template list -> Choose "Copy an existing document template file".

Use a descriptive title for the template, and use "Header" to group templates. This makes it easier for the end-user to understand which files save and opens the files in Drive / Word Online.

**NOTE:**

* All documents written in SuperOffice will be stored in the SharePoint / Google cloud if the template is set up for it, and available to open and edit in SuperOffice CRM Online.

* If you want to use your Microsoft 365 / Google Workspace account to edit SuperOffice templates, the SuperOffice templates need to be moved from SuperOffice to your SharePoint  / Google Workspace account.

* Old documents will not automatically be moved from SuperOffice to your SharePoint  / Google Workspace.

* Moving existing documents or templates to or from SuperOffice and your SharePoint  / Google Workspace is offered as a paid service.

### Moving existing SuperOffice documents and templates between SuperOffice Online and cloud document provider

All documents written in SuperOffice will be stored in the provider's cloud if the template is set up for it, and available to open and edit in SuperOffice CRM Online.

**Google Workspace:**

* If you want to use your Google Workspace account to edit SuperOffice templates, the SuperOffice templates need to be moved from SuperOffice to your Google Workspace account.

* Old documents will not automatically be moved from SuperOffice to Google Workspace.

* Moving existing documents or templates to or from SuperOffice and the is not offered as a service. A SuperOffice consultant might be able to assist you in a manual transition.

**Microsoft 365:**

* If you want to use Microsoft 365 to edit SuperOffice templates, the SuperOffice templates need to be moved from SuperOffice to Microsoft 365 SharePoint.

* Existing documents will not automatically be moved from SuperOffice to Microsoft 365 SharePoint.

* Moving existing documents to or from SuperOffice and Microsoft 365 SharePoint is not supported.

* Moving existing templates to or from SuperOffice and Microsoft 365 SharePoint can be performed in the Admin client.

<!-- Referenced links -->
[1]: ../templates/index.md

<!-- Referenced images -->
[img1]: media/imageh3map.png
[img2]: media/template3.png
[img3]: media/template3b.png
[img4]: media/imagedmnmi.png
[img5]: media/image6r9sc.png

[3]: legacy/office-365/set-up.md
[2]: g-suite/set-up.md
