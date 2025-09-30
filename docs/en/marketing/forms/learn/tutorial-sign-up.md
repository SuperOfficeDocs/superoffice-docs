---
uid: help-en-forms-sign-up
title: How to create a newsletter sign-up form
description: This tutorial walks you through how to create a newsletter sign-up form in SuperOffice Marketing.
keywords: form, double opt-in, sign-up, newsletter
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

# How to create a newsletter sign-up form

Let us look at a another custom form that may be relevant to your company.

## What we will be doing

In this tutorial we will create a form for customers who want to sign up for one or more newsletters. The sign-up process will also include double opt-in to eliminate erroneous or fake subscriptions.

The example does not cover every field and option, but you can find comprehensive instructions in [Create a new form][1].

## Start here

1. In SuperOffice, [create a static selection][7] of companies/contacts called "Newsletter subscribers (form)". We will use this selection later in this guide.

1. Go to **Marketing** and select the **Forms** tab.

1. Click the **Form** button below **Create new** on the right side of the screen.

1. In the **Edit form** dialog, enter "Newsletter sign-up" in the **Form name** field.

1. Select **Properties**, enter a description, and set other form properties as relevant. Do NOT activate any options under **Deactivate form automatically**.

1. Click **Apply now** to save the form and continue editing.

## Fields

1. Select **Fields** from the left menu.

1. Select the **Contact - Name** field, and click the red X to remove this field.

1. Click <i class="ph ph-plus" aria-label="Add"></i> and add the following fields:

    * First and last name.

    * **Contact - Email** (make this field mandatory)

    * **Contact - Subscription**
        * Select one or more newsletters that should be available.
        * Set the field to **Mandatory**.
        * Change the name of the field to "Choose your subscriptions".

1. Select the **OK** field, change the name to "Submit", and edit the font/background color and position.

1. Edit the names of the other fields as necessary. **Tip**: Remove "Contact -".

1. Click <i class="ph ph-dots-six" aria-label="Six dots"></i> at the top of a field and drag it to the desired position in the form. The fields should have a logical order.

1. Click **Apply now** to save the form and continue editing.

![Add fields to new sign-up form -screenshot][img7]

## Style

1. Select **Style** from the left menu to define the look and feel of the form. Edit the layout, colors, size, and fonts of the form. Consider involving your web design colleagues.

1. Click **Apply now** to save the form and continue editing.

![Style new sign-up form -screenshot][img8]

## Double opt-in

[!include[Show toolbar](includes/tip-show-toolbar-open-editor.md)]

1. Select **Double opt-in** from the left menu.

1. Check **Enable double opt-in**.

1. Select the **Message** tab and enter the text to show after the form is submitted. This message should inform the customer that they will receive an email confirmation.

    <details><summary>Example</summary>

    We will now send an email to the address you registered in our form.

    Click the link in the email to confirm your email address and activate your subscription(s).

    Best regards,

    SuperShop
    </details>

1. Select the **Email** tab and create the confirmation email sent to the persons submitting the form.

    <details><summary>Example</summary>

    Hi and thanks for your interest in our newsletters

    Please click the link below to confirm your email address and start your subscription.

    Click here to confirm your email address

    Best regards,

    The SuperShop Team
    </details>

1. Select **Insert confirm link** (<i class="ph ph-arrow-square-out" aria-hidden="true"></i>) from the toolbar. The confirmation link is inserted in the body text.

1. Click the confirmation link, select **Edit link** (<i class="ph ph-pencil-simple" aria-hidden="true"></i>), and change the link text to "Click here to confirm your email address". The link is valid for 30 minutes by default.

1. Click **Apply now** to save the form and continue editing.

![Add double opt-in to new sign-up form -screenshot][img9]

## Landing pages

1. Select **Thank you page**.

1. Select **Show this message** and enter "Thank you for subscribing". This is shown after the customer verifies their email address.

1. Select **Page for inactive form**.

1. Select **Redirect to external website** and enter a URL. If a customer accesses the form after it is marked as inactive, they will be sent to this page.

1. Click **Apply now** to save the form and continue editing.

## Form actions

1. Select **Actions** from the left menu to choose what happens after submission.

1. Do not select **Create request**. The subscriptions will activate automatically, so no action is required by the support team.

1. Select **Manually if submitter is unknown. Automatically if submitter is known**. If the email address submitted in the form matches an email address in SuperOffice, the form submission is processed automatically. Otherwise, it must be processed manually.

1. **Add contact to selection**. Choose the selection you created in step 1. Use this selection to keep track of contacts added via this form.

1. **Add interest to contact**: Select the interest called **Newsletter**. This interest will be added to contacts who submit this form.

1. **Email response**: Select or [create a form response][2] to send to contacts when their form is processed. For example, to inform the customer of your company's privacy policy. The email can also include a link to [manage subscriptions][6].

![Define your form actions -screenshot][img6]

## Save and launch

1. Click **Save**. The form is saved and the **Edit form** dialog closes.

1. Set the form to **Active** <i class="ph ph-toggle-right" aria-label="Toggle on"></i> in the header.

1. Go to the **Publish** tab.

1. Copy the direct link and/or JavaScript into a newsletter, website or customer centre to publish it to your customers or prospects.

1. Open the link to the form, fill in the form and check that everything works as expected.

> [!TIP]
> You might also be interested in our [contact-me form][7] tutorial.

<!-- Referenced links -->
[1]: create.md
[2]: ../../mailing/learn/create/tutorial-form-mailing.md
[6]: ../../recipients/learn/manage-email-subscriptions.md
[7]: ../../../search-options/selection/learn/create.md

<!-- Referenced images -->
[img6]: ../../../../media/loc/en/marketing/sign-up-form-actions.png
[img7]: ../../../../media/loc/en/marketing/sign-up-form-fields.png
[img8]: ../../../../media/loc/en/marketing/sign-up-form-style.png
[img9]: ../../../../media/loc/en/marketing/sign-up-form-double-opt-in.png
