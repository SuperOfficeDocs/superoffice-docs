---
uid: help-en-step-1-setup---document
title: Step 1 Setup - Document
description: Step 1 Setup - Document
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Marketing
so.topic: help
language: en
---

# Step 1: Setup - Document

> [!TIP]
> To view and print an existing document mailing, close the **Setup** step (click **Cancel** or **Save + Close**). Select the **Mailings** tab, locate the document, click ![icon](../media/btn-Menu.png) and select **View**. Click the button under **Download generated document**. The document is downloaded to your browser. Open and print the document.

Using the document mailing workflow you can generate a PDF document to print and send to your customers. The first step in creating a document mailing, is called **Setup**. Here you can set the name of the mailing, the heading and attention text in the document, and set archive options for the mailing.

In order to do this:

1. Enter a name in the **Name of mailing** field.

2. In the **Heading** field, enter the document title.

3. In the **Attention** field, you must select to whom the mailing should be directed. Select one of the following options:
    * **If none defined**: Select this option to use the recipients' names by default, or, if no recipient name is found, use the recipient you enter in the text field. If you are creating a mailing directed at IT professionals in a company, you can enter "IT department" or similar.
    * **Use always**: Select this option to override the recipients' names and only use the recipient you enter in the text field.

4. Optional: Start writing in the **Project** field to search for a SuperOffice CRM project. <!-- Fix reuse ID=a21 -->
    You can connect the document mailing to a specific project. This can be relevant if you are creating mailings where the recipients are project members from a SuperOffice CRM project. By using template variables in the template, you can add project data to your mailing.

5. Optional: Start writing in the **Sale** field to search for a SuperOffice CRM sale. <!-- Fix reuse ID=a3 -->
    You can connect the document mailing to a specific sale. This can be relevant if you are creating mailings where the recipients are sale stakeholders from a SuperOffice CRM sale. By using template variables in the template, you can add sales data to your mailing.

6. In the **Our ref** field, enter the name that should appear as our reference in the document. You can use SuperOffice CRM [template variables](../../StandardCRM/chap02/Template-variables.md) in this field. Some examples have been provided below this field.

    > [!NOTE]
    > For variables such as sale ID or project ID to work, you must link the document mailing to a sale or project.

7. In the **Folder** list, select a folder in which to place the mailing.

    [!include[How to create a mailing folder](../../includes/create-mailing-folder.md)]

8. In the **Selection** and **Project** fields, you can associate the mailing with a selection and/or a project. Start typing in the **Selection** or **Project** fields to search for a selection or project respectively. <!-- Fix reuse ID=a2 -->
    Answer: To keep track of all mailings related to your selections and projects. The mailings are listed in the **Mailings** section tab in **Selections**, and in the **Activities** section tab in **Projects** in SuperOffice CRM.

    Example: If you send out multiple mailings to promote an event, you can add these mailings to a selection called "Event 2015" to have a complete list of all mailings for this event.

    Similarly, if you have created a project for your event, you can maintain a list of all project-related mailings in the **Activities** section tab.

    > [!NOTE]
    > If you add a selection or a project, any contacts in the selection or project will be added as recipients in the mailing. If you add both a selection and a project, only contacts from the selection will be added as recipients.

9. Click **Next** to go to the next step: [Step 2: Template](Step-2-Layout-Document.md).

> [!TIP]
> Click the **Save + close** button to save the mailing and close it. You can continue working on the mailing later.
