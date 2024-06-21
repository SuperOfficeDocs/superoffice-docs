---
uid: help-en-form-submissions-process
title: Process form submissions
description: In this how-to guide you will learn how to process form submissions manually.
keywords: form, form data, submission, submitted, submitter, process, data from form
author: Bergfrid Dias
date: 03.04.2024
version: 10
topic: howto
language: en
audience: person
audience_tooltip: SuperOffice Marketing
---

# Process form submissions

As soon as the form submissions start flooding in, it is time to process them. Forms can be processed automatically, manually, or a combination of both. This is specified as [form actions][2].

Form submissions with status **Submitted** must be processed manually. This means reviewing the form contents and linking the submitter to an existing or a new contact and/or company in SuperOffice.

The main reason for choosing manual processing is to have more control of the contacts added to your database through form submissions. Specifically, you can prevent duplicate contacts by checking whether a person is already registered. SuperOffice validates the email address in the form to ensure it is a valid domain. Basic email syntax is also checked.

When a form is submitted, SuperOffice attempts to link the form to an existing contact using the email address provided.

* If a match is found, you can display the contact's information, requests, sales, follow-ups, and previous chat sessions.
* If no match is found, search for the correct contact or create a new one.

Watch this video (or follow the step-by-step guide below) to learn how you can manually process a submitted web form (video length - 4:30) or follow the steps below.

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/XtdkUwIXkww]

## Steps

### 1 - Locate and open the form submission

Do one of the following:

* If you were notified by a Service request, open the request and click the link.

* If the submitter is known, go to the Contact screen, search for the relevant person, and select the **Activities** section tab. Double-click the row with the unprocessed form submission.

* In SuperOffice Marketing:

    1. Open a form and go to the **Form submissions** tab, or go to the **Form submissions** tab in the main Marketing screen.

    2. At the bottom of the list of form submission, deselect all filters except **Submitted**. The list now displays only form submission that must be processed.

    3. Double-click the row with the submission you want to process.

### 2 - Review and process data

In the **Form submission** window:

1. Select the **Data from form** tab and review the submitted data.

2. Select the **Actions** tab to view the actions that are performed on the form data when you process it.

3. In the **Submitter** side panel, link the submitter to an existing or new SuperOffice contact:

    * **Use suggested contact:** If SuperOffice finds matching contacts, they are listed under **This contact could be...**. Click a contact to link it to this form submission.

    * **Search for a contact:** If the correct contact is not found, use the search field to find it. You can also select from history and favorites.

    * **Change contact:** If you have selected the wrong contact, click **Change contact** to search again.

    * **Create new company and contact:** If the submitter is not found in SuperOffice, create a new contact and company:

      1. Click **Create new company and contact**. Some fields are pre-filled with form data.
      2. Complete the relevant fields.
      3. Click **Add** to add the new contact and company to SuperOffice.

4. Click **Process**.

![Form submission, Data from form -screenshot][img1]

## Related topics

* [Track form submissions and view statistics][1]
* [Analyze your mailing results][4]

<!-- Referenced links -->
[1]: view-statistics.md
[2]: define-form-actions.md
[4]: ../../mailing/learn/view-statistics.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/form-submission-add-contact.png
