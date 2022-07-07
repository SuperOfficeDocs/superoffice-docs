---
uid: help-en-formsguide
title: FormsGuide
description: FormsGuide
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Marketing
so.topic: help
language: en
---

# How to create forms (examples)

Create your own custom forms with the **Forms** feature in SuperOffice Marketing. In this topic we will show you how to create two different forms that might be relevant for your company:

* [Newsletter sign-up](FormsGuide.md#DNT-newslettersignup): Let your customers sign up for one or more of your newsletters.
* [Contact me](FormsGuide.md#DNT-contactme): Use a "contact me" form to open up another communication channel with your customers or prospects. Use this form to generate support requests or generate leads for your sales team.

The procedures below will guide your through the form creation using examples. We will not cover every field and option, but you can find comprehensive instructions in [Create a new form](form-create.md).

## Newsletter sign-up

This form will let your customers sign up for one or more newsletters. The sign-up process will also include <!-- Fix reuse ID=a1 -->(in addition to submitting the form, the customers must verify their e-mail address by clicking the link in a confirmation e-mail) to eliminate erroneous or fake subscriptions.

Open SuperOffice CRM and create a static selection of companies/contacts called "Newsletter subscribers (form)". We will use this selection later in this guide.

Open SuperOffice Marketing and go to the **Forms** tab.

Select **Form** under **Create new** on the right side of the screen. The **Edit form** screen displays.

Enter "Newsletter sign-up" in the **Form name** field.

Fill in the options/fields in the **Properties** category as relevant. Do NOT activate any options under **Deactivate form automatically**.

Click **Apply now** to save the form and continue editing.

In the **Fields** category, click ![icon](media/btn-Field-Add.png) and add the following fields:

First and last name (remove the **Contact - Name field**)

**Contact - E-mail** (make this field mandatory)

Contact - Subscription

* Select one or more newsletters which should be available
* Set the field to **Mandatory**.
* Change the name of the field to "Select your subscriptions".

Select the **OK** field, change the name to "Submit", and edit the font/background colour and position.

Edit the names of the other fields as necessary. **Tip**: Remove "Contact -".

Click ![icon](media/btn-Field-Move.png) at the top of a field and drag it to the desired position in the form. The fields should have a logical order.

Click **Apply now** to save the form and continue editing.

In the **Style** category, edit the layout, colours, size and fonts of the form. Now might be a good time to involve your web design colleagues.

Click **Apply now** to save the form and continue editing.

In the **Double opt-in** category, select **Enable double opt-in**. <!-- Fix reuse ID=a2 --><span id="POPUP467953676" class="expandtext" style="display: none;">This option adds an extra layer of security to the form. If you activate this option, the person submitting the form must also confirm their e-mail address. This is done by sending them an e-mail when they submit the form. The e-mail contains a link they must click to confirm that the e-mail address is correct.  
The link is valid for 30 minutes by default.

In the **Message** tab, enter the text to display after the form has been submitted. This message should inform the customer that they will receive an e-mail confirmation. <!-- Fix reuse ID=a3 -->. Click **Show/hide toolbar** (![icon](media/btn-editor-toolbar-showhide.png)) to display formatting options for the text.

We will now send an e-mail to the address you have registered in our form.

Click the link in the e-mail to confirm your e-mail address and activate your subscription(s).

Best regards,

SuperShop

In the **E-mail** tab, create the confirmation e-mail sent to the persons submitting the form. <!-- Fix reuse ID=a4 -->.

Hi and thanks for your interest in our newsletters

Please click the link below to confirm your e-mail address and start your subscription.

Click here to confirm your e-mail address

Best regards,

The SuperShop Team

Click **Show/hide toolbar** (![icon](media/btn-editor-toolbar-showhide.png)) and then click **Insert confirm link** (![icon](media/btn-ConfirmLink.png)). The confirmation link is inserted in the body text.

Click the confirmation link, select **Edit link** (![icon](media/btn-EditLink.png)), and change the link text to "Click here to confirm your e-mail address". The link is valid for 30 minutes by default.

Click **Apply now** to save the form and continue editing.

In the **Thank you page** category, you can either redirect the customer to a web page or display a message (such as "Thank you for subscribing"). This will display after the customer has verified their e-mail address.

Click **Apply now** to save the form and continue editing.

In the **Page for inactive form** category, enter a URL or a message. This is relevant if a customer accesses the form after it has been set to inactive.

Click **Apply now** to save the form and continue editing.

In the **Actions** category, you must set up the actions to be performed when the form is processed:

* Do not select **Create request**. The subscriptions will activate automatically, so no action is required by the support team.
* Select **Manually if submitter is unknown. Automatically if submitter is known**: If the e-mail address submitted in the form matches an e-mail address in SuperOffice, the form submission is processed automatically. Otherwise, it must be processed manually.
* **Add contact to selection**: Select the selection you created in step 1. Use this selection to keep track of contacts added via this form.
* **Add interest to contact**: Select the interest called **Newsletter**. This interest will be added to contacts who submit this form.
* **E-mail response**: Select a form response to send to contacts when their form is processed. This e-mail can for example inform the customer of your company's privacy policy and can also include a link to manage subscriptions. To create a form response, see [Form response: Step 1: Setup](form-create-step1-setup.md).

Click **Save**. The form is saved and the **Edit form** screen closes.

Set the form to **Active** (![icon](media/btn-form-active.png)) in the header.

Go to the **Publish** tab.

Copy the direct link and/or JavaScript into a newsletter, website or customer centre to publish it to your customers or prospects.

Open the link to the form, fill in the form and check that everything works as expected.

What happens now? See the following topics:

[Form submissions](form-submissions.md)

[Track form submissions and view statistics](form-submission-track.md)

[Process form submissions](form-submissions-process.md)

## Contact me

Put a "contact me" form on your company's web pages to provide an easy channel of communication for existing or potential customers.

In this example we will show you how to create short form for customers who want to get in touch with a support representative. The form submission will trigger a new request for your support department.

Open SuperOffice Marketing and go to the **Forms** tab.

Select **Form** under **Create new** on the right side of the screen. The **Edit form** screen displays.

Enter "Contact me (support)" in the **Form name** field.

Fill in the options/fields in the **Properties** category as relevant. Do NOT activate any options under **Deactivate form automatically**.

In the **Fields** category, click ![icon](media/btn-Field-Add.png) and add the following fields:

* First and last name. Remove the **Contact - Name field**.
* **View elements** &gt; **Text block**: Enter the text in "How can we contact you?" in bold.
* **Contact - Mobile**: Enter an example of a correctly formatted phone number for your country (include the country code) in the **Placeholder** field (example: +47 999 88 777).
* **Contact - E-mail**
* **Form elements** &gt; **Text area**: Change the name of the field to "Comment (optional)" and write "How can we help you today?" in the **Placeholder** field.

Select the **OK** field, change the name to "Submit", and edit the font/background colour and position.

Edit the names of the other fields as necessary. **Tip**: Remove "Contact -".

Click ![icon](media/btn-Field-Move.png) at the top of a field and drag it to the desired position in the form. The fields should have a logical order.

Click **Apply now** to save the form and continue editing.

In the **Style** category, edit the layout, colours, size and fonts of the form. Now might be a good time to involve your web design colleagues.

Click **Apply now** to save the form and continue editing.

Optional: If you want to enable double opt-in, you should also set the **E-mail** field to **Mandatory**. <!-- Fix reuse ID=a21 -->This option adds an extra layer of security to the form. If you activate this option, the person submitting the form must also confirm their e-mail address. This is done by sending them an e-mail when they submit the form. The e-mail contains a link they must click to confirm that the e-mail address is correct.

In the **Thank you page** category, you can either redirect the customer to a web page or display a message (such as "Thank you for contacting us. We will be in touch shortly."). This will display after the customer has submitted the form.

In the **Page for inactive form** category, enter a URL or a message. This is relevant if a customer accesses the form after it has been set to inactive.

In the **Actions** category, you must set up the actions to be performed when the form is processed:

Select **Create request** and do the following:

1. Enter a descriptive title for the requests that will be generated from this form.
2. Select the relevant request category, for example "Support" or a sub-category called "Form submissions".
3. Set the request priority to **Medium**.

Select **Manually if submitter is unknown. Automatically if submitter is known**: If the e-mail address submitted in the form matches an e-mail address in SuperOffice, the form submission is processed automatically. Otherwise, it must be processed manually.

**E-mail response**: Select a form response to send to contacts when their form is processed. This e-mail can for example inform the customer of your company's privacy policy and can also include a link to manage subscriptions. To create a form response, see [Form response: Step 1: Setup](form-create-step1-setup.md).

Click **Save**. The form is saved and the **Edit form** screen closes.

Set the form to **Active** (![icon](media/btn-form-active.png)) in the header.

Go to the **Publish** tab.

Copy the direct link and/or JavaScript into a newsletter, website or customer centre to publish it to your customers or prospects.

Open the link to the form, fill in the form and check that everything works as expected.

What happens now? See the following topics:

[Form submissions](form-submissions.md)

[Track form submissions and view statistics](form-submission-track.md)

[Process form submissions](form-submissions-process.md)
