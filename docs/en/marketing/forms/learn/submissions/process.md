---
uid: help-en-form-submissions-process
title: Process form submissions
description: In this how-to guide you will learn how to process form submissions manually.
author: SuperOffice RnD
so.date: 02.21.2023
keywords: Forms
so.topic: howto
language: en
---

# Process form submissions

As soon as the form submissions start flooding in, it is time to process them. Forms can be processed automatically, manually, or a combination of both.

> [!NOTE]
> SuperOffice will check and validate the email address entered in the form to make sure it is an existing domain name. Basic email address syntax will also be checked.

When you have set up your web form to automatically process all incoming submissions, you won't have to lift a finger. SuperOffice CRM will process them for you and create a new contact when no match is found in your database.

* When you process form submissions manually you can prevent duplicate contacts by checking whether a person is already registered in your database or not.

* You could also choose this option "Manually if submitter is unknown. Automatically if submitter is known." Then you have more control of the contacts added to your database through form submissions.

Form submissions with status **Submitted** must be processed manually. This means reviewing the form contents and linking the submitter to an existing or a new contact and/or company in SuperOffice. Processed forms are available in the **Activities** section tab in the Company and Contact screens in SuperOffice CRM. If you selected to be notified by new request, the processed forms will be available in the **Request** section tab.

Watch this video (or follow the step-by-step guide below) to learn how you can manually process a submitted web form (video length - 4:30) or follow the steps below.

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/XtdkUwIXkww]

## Steps

1. In SuperOffice Marketing:
    1. Open a form and go to the **Form submissions** tab or go to the **Form submissions** tab (in the main **Marketing** screen).
    2. At the bottom of the list of form submission, deselect all filters except **Submitted**. The list now displays only form submission that must be processed.

    In SuperOffice CRM: Go to the Contact screen, search for the relevant person and select the **Activities** section tab.

2. Double-click a row.

3. In the **Form submission** window, review the submitted data in the **Data from form** tab.

4. Go to the **Actions** tab to view the actions that are performed on the form data when you process it.

5. In the **Submitter** side panel, you must link the submitter to an existing or new contact in SuperOffice.

6. Click **Process**.

## Linking the submitter to a SuperOffice contact and company

When a form is submitted, SuperOffice will try to match the email address in the form with existing email addresses in SuperOffice to link the form submission to an existing contact. If the submitter is found in SuperOffice, you can show contact information, requests, sales, follow-ups and previously registered chat sessions.

If no match is found, try to locate the correct contact or create a new contact (and company).

### Use suggested contact

If SuperOffice finds matching contacts in the database, they are listed under **This contact could be...**. Click a contact to view relevant information and to link the contact to this form submission.

### Search for a contact

If SuperOffice cannot find the correct contact in the database, you can search for the contact using the search field. Here you can also select from the history list and favorites.

### Change contact

If you selected the wrong contact, click **Change contact** at the bottom of the side panel to search for another contact.

### Create new company and contact

If the submitter is not found in SuperOffice, you can create a new contact and company in the side panel.

1. Click **Create new company and contact**. Some fields are populated with information the customer provided in the form.
2. Fill in the relevant fields.
3. Click **Add**. The new contact and company is added to SuperOffice.

## <a id="filter" />Filter the form submissions overview

To work more efficient, you can filter the records to show one or more form statuses or Mine/Primary groups. You find the **Filter** button in the lower-right corner.

![Different filter options on form submissions -screenshot][img1]

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/marketing/form-submissions-filter.png
