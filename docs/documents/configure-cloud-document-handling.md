---
# Mandatory fields.
title: cloud_document_config       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Configure - Cloud Office document handling # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto                 # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud              # cloud or onsite
so.client: online            # online, web, win, pocket, or mobile
---

# Configure - Cloud Office document handling

In standard CRM Online, all templates are stored in CRM Online storage ("SO Archive") and are set to save the files users create also in CRM Online storage ("SO Archive").

Even with the integration set up - you may still use "SO Archive" for your templates and documents - but then without the benefits of Office365 or G Suite services.

> [!NOTE]
> There is one selection for where to store the template: **Store template in**
and one selection for where to store the file created based on this template: **Document stored in**.<br/>For most users, the important choice is **Document stored in**, because this is the criteria for where the document is created, and how it is opened (Word Online / Google Drive).

## Create a SuperOffice template for your cloud document integration

This will store the template in the O365 cloud or Google cloud, and when the user uses this template - the document created will also be saved in the O365 or Google cloud and opened with Google Drive or Word Online.

1. Open SuperOffice Admin, go to Lists, choose **Document - Template**

![x][1]

2. Click **Add**.

3. Add template file

    * Enter a name
    * Set **Store template in** to either "Google" or "Office365"
    * Choose the source of the new template
    * Click **Save**

![x][2]

4. Choose where to store document created by this template

    * Set **Document stored in** to either  "Google" or "Office365"
    * Click **Save**

![x][3]

## Considerations

To be able to edit the **template** in Google Drive or Word Online, it must be located in the O365 / Google cloud. If this is not a requirement, the template can stay put in CRM Online storage (SO Archive) if you like.

If you want to change where the original templates store new documents created - you can do this by changing the original template property "Document stored in:". This will not move the template itself.

If you want to move the template from CRM Online storage (SO Archive) to Google / O365, click "Add" in Document Template list -> Choose "Copy an existing document template file"

Use a descriptive title for the template, and use "Header" to group templates. This makes it easier for the end-user to understand which files save and opens the files in Drive / Word Online.

**NOTE:**

* All documents written in SuperOffice will be stored in the SharePoint / Google cloud if the template is set up for it, and available to open and edit in SuperOffice CRM Online

* If you want to use your O365 / G Suite account to edit SuperOffice templates, the SuperOffice templates need to be moved from SuperOffice to your SharePoint  / G Suite account

* Old documents will not automatically be moved from SuperOffice to your SharePoint  / G Suite

* Moving existing documents or templates to or from SuperOffice and your SharePoint  / G Suite is offered as a paid service

### Moving existing SuperOffice documents and templates between SuperOffice Online and cloud document provider

All documents written in SuperOffice will be stored in the provider's cloud if the template is set up for it, and available to open and edit in SuperOffice CRM Online.

**G suite:**

* If you want to use your G Suite account to edit SuperOffice templates, the SuperOffice templates need to be moved from SuperOffice to your G Suite account

* Old documents will not automatically be moved from SuperOffice to G Suite

* Moving existing documents or templates to or from SuperOffice and the is not offered as a service. A SuperOffice consultant might be able to assist you in a manual transition.

**Office 365:**

* If you want to use O365 to edit SuperOffice templates, the SuperOffice templates need to be moved from SuperOffice to O365 SharePoint

* Existing documents will not automatically be moved from SuperOffice to O365 SharePoint

* Moving existing documents to or from SuperOffice and O365 SharePoint is not supported

* Moving existing templates to or from SuperOffice and O365 SharePoint can be performed in the Admin client

<!-- Referenced links -->
[1]: media/template1.png
[2]: media/template3.png
[3]: media/template3b.png
