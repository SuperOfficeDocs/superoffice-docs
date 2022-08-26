---
title: Configure
uid: cloud-document-config
description: How to configure document templates for Google Workspace Integration
author: Bergfrid Dias
so.date: 06.20.2022
keywords: Google Workspace, document
so.topic: howto
so.envir: cloud
so.client: online
---

# Create a SuperOffice template for your cloud document integration

This will store the template in the Google cloud, and when the user uses this template - the document created will also be saved in the Google cloud and opened with Google Drive.

[!include[How to link a template](../includes/link-templates.md)]

![imageh3map.png -screenshot -screenshot][img1]

1. Open SuperOffice Admin, go to Lists, choose **Document - Template**.

2. Click **Add**.

3. Add template file:

    * Enter a name.
    * Set **Store template in** to "Google".
    * Choose the source of the new template (create, upload, or copy).
    * Click **Save**.

    ![x -screenshot -screenshot][img2]

4. Optionally edit the template name, if required, and click **Edit** to edit the template file itself.

5. Enter the required information in the **Details** and **Languages** tabs:

    * Select **Direction** (outgoing or incoming).
    * Choose where to store document created by this template: set **Document stored in** to "Google".
    * Enter a value in the **Our reference (default)** field using [template variables][1]. For example `auth` for the sender’s first and last names.
    * Optionally, enter a description.

    ![x -screenshot][img3]

6. Click **Save**. The Document template is now available in the CRM client:

![imagedmnmi.png -screenshot -screenshot][img4]

![image6r9sc.png -screenshot -screenshot][img5]

> [!NOTE]
> All documents written in SuperOffice will be stored in the Google cloud if the template is set up for it, and available to open and edit in SuperOffice CRM Online.

* If you want to use your Google Workspace account to edit SuperOffice templates, the SuperOffice templates need to be moved from SuperOffice to your Google Workspace account. If this is not a requirement, the template can stay put in CRM Online storage (SO Archive) if you like.

* Old documents will not automatically be moved from SuperOffice to Google Workspace.

* Moving existing documents or templates to or from SuperOffice and the is not offered as a service. A SuperOffice consultant might be able to assist you in a manual transition.

<!-- Referenced links -->
[1]: ../../templates/index.md

<!-- Referenced images -->
[img1]: media/imageh3map.png
[img2]: media/template3.png
[img3]: media/template3b.png
[img4]: media/imagedmnmi.png
[img5]: media/image6r9sc.png
