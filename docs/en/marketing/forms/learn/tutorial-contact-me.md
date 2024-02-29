---
uid: help-en-forms-contact-me
title: How to create a Contact me form
description: This tutorial walks you through how to create a Contact me form in SuperOffice Marketing.
keywords: form, contact me
author: SuperOffice RnD
so.date: 02.29.2024
so.version: 10
so.topic: tutorial
language: en
so.audience: person
---

# How to create a Contact me form

Put a "Contact me" form on your company's web pages to provide an easy channel of communication for existing or potential customers. Use this form to generate support requests or generate leads for your sales team.

## What we will be doing

In this tutorial we will create short form for customers who want to get in touch with a support representative. The form submission will trigger a new request for your support department.

The example does not cover every field and option, but you can find comprehensive instructions in [Create a new form][1].

## Start here

1. Open SuperOffice Marketing and go to the **Forms** tab.

1. Select **Form** under **Create new** on the right side of the screen. The **Edit form** screen displays.

1. Enter "Contact me (support)" in the **Form name** field.

1. Fill in the options/fields in the **Properties** category as relevant. Do NOT activate any options under **Deactivate form automatically**.

## Fields

1. In the **Fields** category, click ![icon][img1] and add the following fields:

    * First and last name. Remove the **Contact - Name field**.
    * **View elements** > **Text block**: Enter the text in "How can we contact you?" in bold.
    * **Contact - Mobile**: Enter an example of a correctly formatted phone number for your country (include the country code) in the **Placeholder** field (example: +47 999 88 777).
    * **Contact - Email**
    * **Form elements** > **Text area**: Change the name of the field to "Comment (optional)" and write "How can we help you today?" in the **Placeholder** field.

1. Select the **OK** field, change the name to "Submit", and edit the font/background color and position.

1. Edit the names of the other fields as necessary. **Tip**: Remove "Contact -".

1. Click ![icon][img2] at the top of a field and drag it to the desired position in the form. The fields should have a logical order.

1. Click **Apply now** to save the form and continue editing.

## Style

1. In the **Style** category, edit the layout, colors, size and fonts of the form. Consider involving your web design colleagues.

1. Click **Apply now** to save the form and continue editing.

## Landing pages

1. In the **Thank you page** category, you can either redirect the customer to a web page or display a message (such as "Thank you for contacting us. We will be in touch shortly."). This will display after the customer submits the form.

1. In the **Page for inactive form** category, enter a URL or a message. This is relevant if a customer accesses the form after it is marked as inactive.

## Form actions

1. In the **Actions** category, you must set up the actions to be performed when the form is processed:

    * Select **Create request** and do the following:
        1. Enter a descriptive title for the requests that will be generated from this form.
        2. Select the relevant request category, for example "Support" or a sub-category called "Form submissions".
        3. Set the request priority to **Medium**.

    * Select **Manually if submitter is unknown. Automatically if submitter is known**: If the email address submitted in the form matches an email address in SuperOffice, the form submission is processed automatically. Otherwise, it must be processed manually.

    * **Email response**: Select or [create a form response][2] to send to contacts when their form is processed. For example, to inform the customer of your company's privacy policy. The email can also include a link to [manage subscriptions][6].

## Save and launch

1. Click **Save**. The form is saved and the **Edit form** screen closes.

1. Set the form to **Active** ![icon][img6] in the header.

1. Go to the **Publish** tab.

1. Copy the direct link and/or JavaScript into a newsletter, website or customer centre to publish it to your customers or prospects.

1. Open the link to the form, fill in the form and check that everything works as expected.

> [!TIP]
> You might also be interested in our [newsletter sign-up][7] tutorial. Let your customers sign up for one or more of your newsletters.

## What happens now?

* [Track form submissions and view statistics][4]
* [Process form submissions][5]

<!-- Referenced links -->
[1]: create.md
[2]: ../../mailing/learn/create/tutorial-form-mailing.yml
[4]: submissions/track.md
[5]: submissions/process.md
[6]: ../../recipients/learn/manage-email-subscriptions.md
[7]: tutorial-sign-up.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/marketing-and-forms/add-field.png
[img2]: ../../../../media/icons/marketing-and-forms/move-field.png
[img6]: ../../../../media/icons/marketing-and-forms/form-active.png
