---
uid: help-en-forms-examples
title: How to create forms (examples)
description: How to create forms (examples)
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Forms
so.topic: concept
language: en
---

# How to create forms (examples)

Let's look at two custom forms that may be relevant to your company:

* [Newsletter sign-up](#newsletter-sign-up): Let your customers sign up for one or more of your newsletters.
* [Contact me](#contact-me): Use a "contact me" form to open up another communication channel with your customers or prospects. Use this form to generate support requests or generate leads for your sales team.

The examples do not cover every field and option, but you can find comprehensive instructions in [Create a new form][1].

## What is double opt-in?

With double opt-in, the customers must verify their email address by clicking the link in a confirmation email in addition to submitting the form.

This option adds an extra layer of security to the form. If you activate this option, the person submitting the form must also confirm their email address. This is done by sending them an email when they submit the form. The email contains a link they must click to confirm that the email address is correct.
The link is valid for 30 minutes by default.

## <a id="newsletter-sign-up" />Newsletter sign-up

This form will let your customers sign up for one or more newsletters. The sign-up process will also include double opt-in to eliminate erroneous or fake subscriptions.

1. Open SuperOffice CRM and create a static selection of companies/contacts called "Newsletter subscribers (form)". We will use this selection later in this guide.

1. Open SuperOffice Marketing and go to the **Forms** tab.

1. Select **Form** under **Create new** on the right side of the screen. The **Edit form** screen displays.

1. Enter "Newsletter sign-up" in the **Form name** field.

1. Fill in the options/fields in the **Properties** category as relevant. Do NOT activate any options under **Deactivate form automatically**.

1. Click **Apply now** to save the form and continue editing.

1. In the **Fields** category, click ![icon][img1] and add the following fields:

    * First and last name (remove the **Contact - Name field**)
    * **Contact - Email** (make this field mandatory)
    * Contact - Subscription
        * Select one or more newsletters which should be available
        * Set the field to **Mandatory**.
        * Change the name of the field to "Select your subscriptions".

1. Select the **OK** field, change the name to "Submit", and edit the font/background color and position.

1. Edit the names of the other fields as necessary. **Tip**: Remove "Contact -".

1. Click ![icon][img2] at the top of a field and drag it to the desired position in the form. The fields should have a logical order.

1. Click **Apply now** to save the form and continue editing.

1. In the **Style** category, edit the layout, colors, size and fonts of the form. Consider involving your web design colleagues.

1. Click **Apply now** to save the form and continue editing.

1. In the **Double opt-in** category, select **Enable double opt-in**.

1. In the **Message** tab, enter the text to display after the form is submitted. This message should inform the customer that they will receive an email confirmation. Click **Show/hide toolbar** ![icon][img3] to display formatting options for the text.

    <details><summary>Example</summary>

    We will now send an email to the address you registered in our form.

    Click the link in the email to confirm your email address and activate your subscription(s).

    Best regards,

    SuperShop
    </details>

1. In the **Email** tab, create the confirmation email sent to the persons submitting the form.

    <details><summary>Example</summary>

    Hi and thanks for your interest in our newsletters

    Please click the link below to confirm your email address and start your subscription.

    Click here to confirm your email address

    Best regards,

    The SuperShop Team
    </details>

1. Click **Show/hide toolbar** ![icon][img3] and then click **Insert confirm link** ![icon][img4]. The confirmation link is inserted in the body text.

1. Click the confirmation link, select **Edit link** ![icon][img5], and change the link text to "Click here to confirm your email address". The link is valid for 30 minutes by default.

1. Click **Apply now** to save the form and continue editing.

1. In the **Thank you page** category, you can either redirect the customer to a web page or display a message (such as "Thank you for subscribing"). This will display after the customer verifies their email address.

1. Click **Apply now** to save the form and continue editing.

1. In the **Page for inactive form** category, enter a URL or a message. This is relevant if a customer accesses the form after it is set to inactive.

1. Click **Apply now** to save the form and continue editing.

1. In the **Actions** category, you must set up the actions to be performed when the form is processed:

    * Do not select **Create request**. The subscriptions will activate automatically, so no action is required by the support team.

    * Select **Manually if submitter is unknown. Automatically if submitter is known**: If the email address submitted in the form matches an email address in SuperOffice, the form submission is processed automatically. Otherwise, it must be processed manually.

    * **Add contact to selection**: Select the selection you created in step 1. Use this selection to keep track of contacts added via this form.

    * **Add interest to contact**: Select the interest called **Newsletter**. This interest will be added to contacts who submit this form.

    * **Email response**: Select a form response to send to contacts when their form is processed. This email can for example inform the customer of your company's privacy policy and can also include a link to manage subscriptions. [How do I create a form response?][2].

1. Click **Save**. The form is saved and the **Edit form** screen closes.

1. Set the form to **Active** ![icon][img6] in the header.

1. Go to the **Publish** tab.

1. Copy the direct link and/or JavaScript into a newsletter, website or customer centre to publish it to your customers or prospects.

1. Open the link to the form, fill in the form and check that everything works as expected.

## <a id="contact-me" />Contact me

Put a "contact me" form on your company's web pages to provide an easy channel of communication for existing or potential customers.

In this example we will show you how to create short form for customers who want to get in touch with a support representative. The form submission will trigger a new request for your support department.

1. Open SuperOffice Marketing and go to the **Forms** tab.

1. Select **Form** under **Create new** on the right side of the screen. The **Edit form** screen displays.

1. Enter "Contact me (support)" in the **Form name** field.

1. Fill in the options/fields in the **Properties** category as relevant. Do NOT activate any options under **Deactivate form automatically**.

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

1. In the **Style** category, edit the layout, colors, size and fonts of the form. Consider involving your web design colleagues.

1. Click **Apply now** to save the form and continue editing.

1. Optional: To enable double opt-in, you should also set the **Email** field to **Mandatory**.

1. In the **Thank you page** category, you can either redirect the customer to a web page or display a message (such as "Thank you for contacting us. We will be in touch shortly."). This will display after the customer submits the form.

1. In the **Page for inactive form** category, enter a URL or a message. This is relevant if a customer accesses the form after it is marked as inactive.

1. In the **Actions** category, you must set up the actions to be performed when the form is processed:

    * Select **Create request** and do the following:
        1. Enter a descriptive title for the requests that will be generated from this form.
        2. Select the relevant request category, for example "Support" or a sub-category called "Form submissions".
        3. Set the request priority to **Medium**.

    * Select **Manually if submitter is unknown. Automatically if submitter is known**: If the email address submitted in the form matches an email address in SuperOffice, the form submission is processed automatically. Otherwise, it must be processed manually.

    * **Email response**: Select a form response to send to contacts when their form is processed. This email can for example inform the customer of your company's privacy policy and can also include a link to manage subscriptions. [How to create a form response][2].

1. Click **Save**. The form is saved and the **Edit form** screen closes.

1. Set the form to **Active** ![icon][img6] in the header.

1. Go to the **Publish** tab.

1. Copy the direct link and/or JavaScript into a newsletter, website or customer centre to publish it to your customers or prospects.

1. Open the link to the form, fill in the form and check that everything works as expected.

## What happens now?

* [Form submissions][3]
* [Track form submissions and view statistics][4]
* [Process form submissions][5]

<!-- Referenced links -->
[1]: create.md
[2]: ../../mailing/learn/create/tutorial-form-mailing.yml
[3]: submissions/index.md
[4]: submissions/track.md
[5]: submissions/process.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/marketing-and-forms/add-field.png
[img2]: ../../../../media/icons/marketing-and-forms/move-field.png
[img3]: ../../../../media/icons/marketing-and-forms/toolbar-show-hide.png
[img4]: ../../../../../common/icons/new-window-icon.png
[img5]: ../../../../../common/icons/edit-black.png
[img6]: ../../../../media/icons/marketing-and-forms/form-active.png
