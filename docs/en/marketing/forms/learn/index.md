---
uid: help-en-forms
title: Work with forms
description: SuperOffice web forms are a great way to gather customer information and feedback. Web forms allow the people visiting your website to get in touch with you and leave their contact details.
keywords: form, submission, double opt-in
author: Bergfrid Dias
date: 09.26.2025
version: 10.5
content_type: concept
category: marketing
topic: forms
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
redirect_from:
  - /en/marketing/forms/index
  - /en/marketing/forms/learn/examples
  - /en/marketing/forms/learn/view
  - /en/marketing/forms/learn/submissions/index
language: en
---

# Work with forms

The forms feature is a powerful engine to get information from a form into SuperOffice without too much integrations and hassle. Forms make it easier to interact with customers and prospects via your website or customer centre. A wide variety of data can be added in a form (including file upload) and you can add automated actions to perform when the form is submitted and processed.

It is easy to create a form and post it on any web page you want it to show, and it is easy to transform all those new prospects to contacts in SuperOffice. Examples of forms: start free trial, [contact us][1], update data, consent management.

![You can use a web form to ask people to sign up for your next webinar or seminar, or to contact your company with their questions -screenshot][img1]

## <a id="ex"></a>Use cases

You can use web forms to capture your website visitors' details – their name, email address, preferences, comments, and feedback, and possibly convert them into customers. The data you get via web forms can be automatically imported to your SuperOffice CRM database, saving you time and effort.

* **Capture contact information:** The information people submit on web forms is saved in SuperOffice CRM, so you can follow up on them later.

* **Receive customer feedback:** Whenever customers or website visitors have a question, a problem or an inquiry, they can contact you directly on web forms.

* **Gain consent:** When a person gives you permission to store information about them on a web form, you know they are truly interested in your marketing messages. Not only will it increase the success of your email campaigns, but you will also follow the rules set by the GDPR.

* **Automate follow-ups:** Forms will help you speed up your work by automating manual tasks, such as creating follow-up activities, sending mailings, updating contacts' interests, and adding contacts to a selection or a project.

## Workflow

Creating a form follows roughly this workflow:

1. [Create a new form][2].
2. [Form response - Step 1: Setup][3] - an email can be automatically sent to a submitter when their form is processed.
3. [Publish forms][4] - use a link or JavaScript to publish the form in a newsletter or on a website or Customer Centre.
4. [Track form submissions and view statistics][5] - view the response rate in real-time.
5. [Process form submissions][6] - update SuperOffice with the submitted data, either manually or automatically. SuperOffice can identify existing contacts based on email addresses or create new contacts and companies.

## Where can you find forms?

SuperOffice Marketing has 3 tabs pertaining to forms.

![There are several ways to find forms -screenshot][img2]

* **Forms tab:** allows you to create new forms and view previously created ones. The **Active Forms** section displays currently used forms. A red bubble on a form indicates unprocessed submissions.

    Use the secondary row of tabs (Recent, My forms,Active forms, All forms) and the search box to explore the available forms.

    Double-click a form to view details about it.

* **Form templates tab:** contains all available [form templates][7]. On first access, you will see templates from the Online Library. You can import these for use or inspiration. To download a template, click on it and press **Import Template**.

* **Form submissions tab:** shows a list of persons who have submitted a form, and the current [status of their submission](#status).

## <a id="view"></a>The View form screen

![The SuperOffice Marketing 'View form' screen -screenshot][img4]

At the top, you have the following options:

|Option | Description |
|---|---|
| Inactive/Active | Toggle this slider button to activate or deactivate the form. |
| Refresh | Updates the screen. |
| Edit | Opens the form in edit mode. |
| <i class="ph ph-star" aria-label="Star icon"></i> | Sets the form as a [favorite][11]. |

The **View form** screen consists of the following tabs:

* **Summary:** shows basic information about the form, including a preview, and various submission statistics.
* **Publish:** shows the link and script for [publishing the form][3] on a web page or in a mailing.
* **Reports:** shows charts with statistics for the form (mouse-over to view exact numbers).
* **Form submissions:** shows submissions for an individual form
* **Response email:** shows a preview the form response (mailing) associated with this form. Visible only if the **Email response** [form action][8] is selected.

## <a id="submissions"></a>Form submissions

When a form is submitted from a Customer Centre or website, the data is collected and displayed in the **Form submissions** tab. A red icon on the tab indicates new form submissions.

Use the filter options at the bottom of the list to view only submissions with specific statuses.

> [!NOTE]
> You can also [view submissions for individual forms][5] by opening a form in the **Forms** tab.

### <a id="status"></a>Status

* **Processed**: The form was submitted and automatically processed.
* **Submitted**: The form was submitted, but not processed yet. [How to process form submissions][6].
* **Awaiting confirmation**: The form was submitted, but the sender must confirm their email address (double-opt in).

## <a id="opt-in"></a>What is double opt-in?

With double opt-in, the customers must verify their email address by clicking the link in a confirmation email in addition to submitting the form.

This option adds an extra layer of security to the form. If you activate this option, the person submitting the form must also confirm their email address. This is done by sending them an email when they submit the form. The email contains a link they must click to confirm that the email address is correct. The link is valid for 30 minutes by default.

This means that your mailing list will be more reliable, which will help raise the opening rates of your mailings. As an added bonus, you won't have to spend time correcting spelling mistakes in email addresses or deleting email addresses that do not exist. And it also will help you in your effort to stay GDPR-compliant.

<!-- Referenced links -->
[1]: tutorial-sign-up.md
[2]: create.md
[8]: define-form-actions.md
[3]: ../../mailing/learn/create/tutorial-form-mailing.md
[4]: publish.md
[5]: view-statistics.md
[6]: process-submissions.md
[7]: form-templates.md
[11]: ../../../learn/basics/fav.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/edit-form.png
[img2]: ../../../../media/loc/en/marketing/find-forms.png
[img4]: ../../../../media/loc/en/marketing/view-form-screen.png
