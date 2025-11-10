---
uid: zapier-trigger-new
title: Create a SuperOffice CRM new trigger
description: How to use SuperOffice new record trigger with Zapier
keywords: New Appointment, New Company, New Contact, New Document, New Project Member, New Project, New Request, New Sale, new Zap, Zapier new trigger
author: miguellemos95, digitaldiina
date: 11.11.2025
content_type: howto
functional_right: general administrator
category: integration
topic: Zapier
platform: Zapier
language: en
redirect_from: /integrations/zapier/howto/triggers/index
---

<!-- markdownlint-disable-file MD051-->

# Create a SuperOffice CRM new trigger

Use a **new trigger** when you want your Zap to start whenever a new record is created in SuperOffice CRM.

Each record type (such as Sale, Contact, or Project) has its own trigger event.

Use the tabs below to view the specific steps and screenshots for each trigger type. All other steps on this page are identical for every event.

[!include[Requirement](../../includes/note-req-general-admin.md)]

## Steps

1. On the Zaps page, click **Create**.

1. Click the **Trigger** step to open a window for selecting the application to use.

    ![Zapier window showing the Create your trigger step -screenshot][img2]

    [!include[search for SuperOffice](../../includes/search-for-so.md)]

1. A side menu opens. In the **Trigger event** section, select the event to listen for. For example, **New Contact** or **New Sale**.

1. Click the **Account** section and log in using a SuperOffice account.

1. [!include[test](includes/test.md)]

1. [!include[action](includes/action.md)]

### [New Appointment](#tab/new-appointment)

* In the **Trigger event** section, select **New Appointment**.

    ![Zapier setup window showing the New Appointment trigger option -screenshot][img6]

* Verify the trigger:

    ![Zapier test window showing successful trigger verification -screenshot][img7]

* When the **New Appointment** trigger runs in SuperOffice CRM, the chosen action executes automatically.

* Related actions and triggers:

  * [Create Appointment action][4]
  * [Update Appointment action][5]
  * [Appointment Changed trigger][3]

### [New Company](#tab/new-company)

* In the **Trigger event** section, select **New Company**.

    ![Zapier setup window showing the New Company trigger option -screenshot][img8]

* Verify the trigger:

    ![Zapier test window showing successful trigger verification -screenshot][img9]

* When the **New Company** trigger runs in SuperOffice CRM, the chosen action executes automatically.

* Related actions and triggers:

  * [Create Company action][7]
  * [Update Company action][8]
  * [Company Changed trigger][3]

### [New Contact](#tab/new-contact)

* In the **Trigger event** section, select **New Contact**.

    ![Zapier setup window showing the New Contact trigger option -screenshot][img10]

* Verify the trigger:

    ![Zapier test window showing successful trigger verification -screenshot][img11]

* When the **New Contact** trigger runs in SuperOffice CRM, the chosen action executes automatically.

* Related actions and triggers:

  * [Create Contact action][10]
  * [Update Contact action][11]
  * [Contact Changed trigger][3]

### [New Document](#tab/new-document)

* In the **Trigger event** section, select **New Document**.

    ![Zapier setup window showing the New Document trigger option -screenshot][img12]

* Verify the trigger:

    ![Zapier test window showing successful trigger verification -screenshot][img13]

* When the **New Document** trigger runs in SuperOffice CRM, the chosen action executes automatically.

* Related actions and triggers:

  * [Create Document action][13]
  * [Update Document action][14]
  * [Document Changed trigger][3]

### [New Project Member](#tab/new-project-member)

* In the **Trigger event** section, select **New Project Member**.

    ![Zapier setup window showing the New Project Member trigger option -screenshot][img14]

* Verify the trigger:

    ![Zapier test window showing successful trigger verification -screenshot][img15]

* When the **New Project Member** trigger runs in SuperOffice CRM, the chosen action executes automatically.

* Related actions and triggers:

  * [Create Project Member action][16]
  * [Remove Project Member action][17]
  * [Project Member Changed trigger][3]

### [New Project](#tab/new-project)

* In the **Trigger event** section, select **New Project**.

    ![Zapier setup window showing the New Project trigger option -screenshot][img16]

* Verify the trigger:

    ![Zapier test window showing successful trigger verification -screenshot][img17]

* When the **New Project** trigger runs in SuperOffice CRM, the chosen action executes automatically.

* Related actions and triggers:

  * [Create Project action][19]
  * [Update Project action][20]
  * [Project Changed trigger][3]

### [New Request](#tab/new-request)

* In the **Trigger event** section, select **New Request**.

    ![Zapier setup window showing the New Request trigger option -screenshot][img18]

* Verify the trigger:

    ![Zapier test window showing successful trigger verification -screenshot][img19]

* When the **New Request** trigger runs in SuperOffice CRM, the chosen action executes automatically.

* Related actions and triggers:

  * [Create Request action][22]
  * [Update Request action][23]

### [New Sale](#tab/new-sale)

* In the **Trigger event** section, select **New Sale**.

    ![Zapier setup window showing the New Sale trigger option -screenshot][img4]

* Verify the trigger:

    ![Zapier test window showing successful trigger verification -screenshot][img5]

* When the **New Sale** trigger runs in SuperOffice CRM, the chosen action executes automatically.

* Related actions and triggers:

  * [Create Sale action][1]
  * [Update Sale action][2]
  * [Sale Changed trigger][3]

***

<!-- Referenced links -->
[1]: ../actions/create-sale.md
[2]: ../actions/update-sale.md
[4]: ../actions/create-appointment.md
[5]: ../actions/update-appointment.md
[7]: ../actions/create-company.md
[8]: ../actions/update-company.md
[10]: ../actions/create-contact.md
[11]: ../actions/update-contact.md
[13]: ../actions/create-document.md
[14]: ../actions/update-document-content.md
[16]: ../actions/create-project-member.md
[17]: ../actions/remove-project-member.md
[19]: ../actions/create-project.md
[20]: ../actions/update-project.md
[22]: ../actions/create-request.md
[23]: ../actions/update-request.md

[3]: changed.md

<!-- Referenced images -->
[img2]: ../media/new-zap-window.png
[img4]: media/new-sale-action.png
[img5]: media/new-sale-output.png
[img6]: media/new-appointment-action.png
[img7]: media/new-appointment-output.png
[img8]: media/new-company-action.png
[img9]: media/new-company-output.png
[img10]: media/new-contact-action.png
[img11]: media/new-contact-output.png
[img12]: media/new-document-action.png
[img13]: media/new-document-output.png
[img14]: media/new-project-member-action.png
[img15]: media/new-project-member-output.png
[img16]: media/new-project-action.png
[img17]: media/new-project-output.png
[img18]: media/new-request-action.png
[img19]: media/new-request-output.png
