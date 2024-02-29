---
uid: help-en-form-actions
title: Define form actions
description: Define form actions
keywords: form, automation
author: SuperOffice RnD
so.date: 02.29.2024
so.version: 10
so.topic: howto
language: en
so.audience: person
---

# Define form actions

Processing 200 event sign-ups manually is time-consuming and unnecessary. Automated form actions can streamline this process.

Automation saves time otherwise spent on handling responses. When a submits the form, the system performs the actions for you!

## Available actions

### Notify of submissions by creating requests

Select this option to create a request for every form that is submitted. Enter a title and select the category and priority for the request. Submitted forms will be available under **Requests** in SuperOffice Service and in the **Request** section tab in the Company and Contact screens in SuperOffice CRM.

## How should a form submission be processed?

Here you can define whether the submitted forms should be processed automatically.

* **Automatically process all submissions. Create new contact if no match found**: All form submissions are processed automatically. There will no notifications of submitted forms.

* **Manually if submitter is unknown. Automatically if submitter is known**: If the email address submitted in the form matches an email address in SuperOffice, the form submission is processed automatically. Otherwise, it must be processed manually. You will receive a notification ![icon][img11].

* **Manually for all submissions**: You will receive a notification ![icon][img11] for each submitted form.

[How to process form submissions manually][6].

## What should happen when the form is processed?

Here you can select actions to perform when a form is processed (automatically or manually):

* **Add contact to selection**: If you selected automatic processing above, you should add a selection here to keep track of contacts added via this form. This will also make it easier to remove any irrelevant contacts (and companies).

* **Add contact to project**: Select a project. Contacts who submit this form will be added to this project.

* **Add interest to contact**: Select an interest. This interest will be added to contacts who submit this form.

* **Email response**: Select a form response to send to contacts when their form is processed. [How to create a form response][7].

* **Create request**: If you added a request field in the **Fields** category, you must also select a default category and priority for the requests that are create from this form. Submitted forms will be available under **Requests** in SuperOffice Service and in the **Request** section tab in the Company and Contact screens in SuperOffice CRM.

* **Execute CRMScript**: Select a script or macro to run when a form submission is processed. See [CRMScript][9].

* **Default category** / **Default business**: Select a default category and business for all contacts or companies that are added to SuperOffice based on submitted forms. With this option, you can group the form submissions and new contacts/companies to one specific category and/or business.

    For example, if you have a form for prospects, you select prospects as your category. You can then easily create selections based on this category and/or business.

## What would you like to do now?

* [Publish forms][2]

<!-- Referenced links -->
[2]: publish.md
[6]: submissions/process.md
[7]: ../../mailing/learn/create/tutorial-form-mailing.yml
[9]: ../../../automation/crmscript/learn/index.md

<!-- Referenced images -->
[img11]: ../../../../media/icons/marketing-and-forms/form-notification.png
