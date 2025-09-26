---
uid: help-en-forms-contact-me
title: How to create a Contact me form
description: This tutorial walks you through how to create a Contact me form in SuperOffice Marketing.
keywords: form, contact me
author: Bergfrid Dias
date: 09.26.2025
version: 10.5
content_type: tutorial
category: marketing
topic: forms
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: en
---

# How to create a Contact me form

Put a "Contact me" form on your company's web pages to provide an easy channel of communication for existing or potential customers. Use this form to generate support requests or generate leads for your sales team.

## What we will be doing

In this tutorial we will create a short form for customers who want to get in touch with a support representative. The form submission will trigger a new request for your support department.

The example does not cover every field and option, but you can find comprehensive instructions in [Create a new form][1].

## Start here

1. Open SuperOffice Marketing and go to the **Forms** tab.

1. Click the **Form** button below **Create new** on the right side of the screen.

1. In the **Edit form** dialog, enter "Contact me (support)" in the **Form name** field.

1. Select **Properties**, enter a description, and set other form properties as relevant. Do NOT activate any options under **Deactivate form automatically**.

1. Click **Apply now** to save the form and continue editing.

![Set properties for new contact me form -screenshot][img5]

## Fields

1. Select **Fields** from the left menu.

1. Select the **Contact - Name** field, and click the red X to remove this field.

1. Click <i class="ph ph-plus" aria-label="Add"></i> and add the following fields:

    * First and last name.

    * **View elements** > **Text block**: Enter the text in "How can we contact you?" in bold.

    * **Contact - Mobile**: Enter an example of a correctly formatted phone number for your country (include the country code) in the **Placeholder** field (example: +47 999 88 777).

    * **Contact - Email**

    * **Form elements** > **Text area**: Change the name of the field to "Comment (optional)" and write "How can we help you today?" in the **Placeholder** field.

    [!include[Show toolbar](includes/tip-show-toolbar-open-editor.md)]

1. Select the **OK** field, change the name to "Submit", and edit the font/background color and position.

1. Edit the names of the other fields as necessary. **Tip**: Remove "Contact -".

1. Click <i class="ph ph-dots-six" aria-label="Six dots"></i> at the top of a field and drag it to the desired position in the form. The fields should have a logical order.

1. Click **Apply now** to save the form and continue editing.

![Add fields to new contact me form -screenshot][img6]

## Style

1. Select **Style** from the left menu to define the look and feel of the form. Edit the layout, colors, size, and fonts of the form. Consider involving your web design colleagues.

1. Click **Apply now** to save the form and continue editing.

## Landing pages

1. Select **Thank you page**.

1. Select **Show this message** and enter "Thank you for contacting us. We will be in touch shortly." This will be shown after the customer submits the form.

1. Select **Page for inactive form**.

1. Select **Redirect to external website** and enter a URL. If a customer accesses the form after it is marked as inactive, they will be sent to this page.

1. Click **Apply now** to save the form and continue editing.

## Form actions

1. Select **Actions** from the left menu to choose what happens after submission.

1. Select **Create request** and do the following:
    1. Enter a descriptive title for the requests that will be generated from this form.
    2. Select the relevant request category, for example "Support" or a sub-category called "Form submissions".
    3. Set the request priority to **Medium**.

1. Select **Manually if submitter is unknown. Automatically if submitter is known**: If the email address submitted in the form matches an email address in SuperOffice, the form submission is processed automatically. Otherwise, it must be processed manually.

1. **Email response**: Select or [create a form response][2] to send to contacts when their form is processed. For example, to inform the customer of your company's privacy policy. The email can also include a link to [manage subscriptions][6].

![Define your form actions -screenshot][img7]

## Save and launch

1. Click **Save**. The form is saved and the **Edit form** dialog closes.

1. In the header, set the form to **Active** <i class="ph ph-toggle-right" aria-label="Toggle on"></i>.

1. Go to the **Publish** tab.

1. Copy the direct link and/or JavaScript into a newsletter, website or customer centre to publish it to your customers or prospects.

1. Open the link to the form, fill in the form and check that everything works as expected.

> [!TIP]
> You might also be interested in our [newsletter sign-up][7] tutorial. Let your customers sign up for one or more of your newsletters.

<!-- Referenced links -->
[1]: create.md
[2]: ../../mailing/learn/create/tutorial-form-mailing.md
[6]: ../../recipients/learn/manage-email-subscriptions.md
[7]: tutorial-sign-up.md

<!-- Referenced images -->
[img5]: ../../../../media/loc/en/marketing/contact-me-form-properties.png
[img6]: ../../../../media/loc/en/marketing/contact-me-form-fields.png
[img7]: ../../../../media/loc/en/marketing/contact-me-form-actions.png
