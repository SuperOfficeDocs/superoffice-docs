---
uid: zapier-trigger-changed
title: Create a SuperOffice CRM changed trigger
description: How to use SuperOffice changed record trigger with Zapier
keywords: Appointment Changed, Company Changed, Contact Changed, Document Changed, Project Changed, Project Member Changed, Sale Changed, update Zap, Zapier changed trigger
author: miguellemos95, digitaldiina
date: 11.11.2025
content_type: howto
functional_right: general administrator
category: integration
topic: Zapier
platform: Zapier
language: en
redirect_from: 
  - /integrations/zapier/howto/appointment-updated-trigger
  - /integrations/zapier/howto/project-member-changed
---

<!-- markdownlint-disable-file MD051 -->

# Create a SuperOffice CRM changed trigger

Use a **changed trigger** when you want your Zap to start whenever an existing record is updated in SuperOffice CRM.

Each record type (such as Appointment, Company, or Sale) has its own change event.

Use the tabs below to view the specific steps and screenshots for each trigger type.
All other steps on this page are identical for every event.

[!include[Requirement](../../includes/note-req-general-admin.md)]

## Steps

1. On the Zaps page, click **Create**.

1. Click the **Trigger** step to open a window for selecting the application to use.

    ![Zapier window showing the Create your trigger step -screenshot][img2]

    [!include[search for SuperOffice](../../includes/search-for-so.md)]

1. A side menu opens. In the **Trigger event** section, select the event to listen for. For example, **Appointment Changed** or **Sale Changed**.

1. Click the **Account** section and log in using a SuperOffice account.

1. [!include[test](includes/test.md)]

1. [!include[action](includes/action.md)]

### [Appointment Changed](#tab/appointment-changed)

* In the **Trigger event** section, select **Appointment Changed**.

    ![Zapier setup window showing the Appointment Changed trigger option -screenshot][img3]

* Verify the trigger:

    ![Zapier test window showing successful trigger verification -screenshot][img4]

* When the **Appointment Changed** trigger runs in SuperOffice CRM, the chosen action executes automatically.

* Related actions and triggers:

  * [Create Appointment action][1]
  * [Update Appointment action][2]
  * [New Appointment trigger][3]

### [Company Changed](#tab/company-changed)

* In the **Trigger event** section, select **Company Changed**.

    ![Zapier setup window showing the Company Changed trigger option -screenshot][img5]

* Verify the trigger:

    ![Zapier test window showing successful trigger verification -screenshot][img6]

* When the **Company Changed** trigger runs in SuperOffice CRM, the chosen action executes automatically.

* Related actions and triggers:

  * [Create Company action][4]
  * [Update Company action][5]
  * [New Company trigger][3]

### [Contact Changed](#tab/contact-changed)

* In the **Trigger event** section, select **Contact Changed**.

    ![Zapier setup window showing the Contact Changed trigger option -screenshot][img7]

* Verify the trigger:

    ![Zapier test window showing successful trigger verification -screenshot][img8]

* When the **Contact Changed** trigger runs in SuperOffice CRM, the chosen action executes automatically.

* Related actions and triggers:

  * [Create Contact action][7]
  * [Update Contact action][8]
  * [New Contact trigger][3]

### [Document Changed](#tab/document-changed)

* In the **Trigger event** section, select **Document Changed**.

    ![Zapier setup window showing the Document Changed trigger option -screenshot][img9]

* Verify the trigger:

    ![Zapier test window showing successful trigger verification -screenshot][img10]

* When the **Document Changed** trigger runs in SuperOffice CRM, the chosen action executes automatically.

* Related actions and triggers:

  * [Create Document action][10]
  * [Update Document action][11]
  * [New Document trigger][3]

### [Project Changed](#tab/project-changed)

* In the **Trigger event** section, select **Project Changed**.

    ![Zapier setup window showing the Project Changed trigger option -screenshot][img11]

* Verify the trigger:

    ![Zapier test window showing successful trigger verification -screenshot][img12]

* When the **Project Changed** trigger runs in SuperOffice CRM, the chosen action executes automatically.

* Related actions and triggers:

  * [Create Project action][13]
  * [Update Project action][14]
  * [New Project trigger][3]

### [Project Member Changed](#tab/project-member-changed)

* In the **Trigger event** section, select **Project Member Changed**.

    ![Zapier setup window showing the Project Member Changed trigger option -screenshot][img13]

* Verify the trigger:

    ![Zapier test window showing successful trigger verification -screenshot][img14]

* When the **Project Member Changed** trigger runs in SuperOffice CRM, the chosen action executes automatically.

* Related actions and triggers:

  * [Create Project Member action][16]
  * [New Project Member trigger][3]

### [Sale Changed](#tab/sale-changed)

* In the **Trigger event** section, select **Sale Changed**.

    ![Zapier setup window showing the Sale Changed trigger option -screenshot][img15]

* Verify the trigger:

    ![Zapier test window showing successful trigger verification -screenshot][img16]

* When the **Sale Changed** trigger runs in SuperOffice CRM, the chosen action executes automatically.

* Related actions and triggers:

  * [Create Sale action][18]
  * [Update Sale action][19]
  * [New Sale trigger][3]

***

## Related content

* [Create a Zap with SuperOffice CRM][21]

<!-- Referenced links -->
[1]: ../actions/create-appointment.md
[2]: ../actions/update-appointment.md
[4]: ../actions/create-company.md
[5]: ../actions/update-company.md
[7]: ../actions/create-contact.md
[8]: ../actions/update-contact.md
[10]: ../actions/create-document.md
[11]: ../actions/update-document-content.md
[13]: ../actions/create-project.md
[14]: ../actions/update-project.md
[16]: ../actions/create-project-member.md
[18]: ../actions/create-sale.md
[19]: ../actions/update-sale.md
[21]: ../../get-started/create-zap.md

[3]: new.md

<!-- Referenced images -->
[img2]: ../media/new-zap-window.png
[img3]: media/appointment-changed-action.png
[img4]: media/appointment-changed-output.png
[img5]: media/company-changed-action.png
[img6]: media/company-changed-output.png
[img7]: media/contact-changed-action.png
[img8]: media/contact-changed-output.png
[img9]: media/document-changed-action.png
[img10]: media/document-changed-output.png
[img11]: media/project-changed-action.png
[img12]: media/project-changed-output.png
[img13]: media/project-changed-action.png
[img14]: media/project-member-changed-output.png
[img15]: media/sale-changed-action.png
[img16]: media/sale-changed-output.png
