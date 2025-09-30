---
uid: help-en-form-create
title: Create a new form
description: Learn how you can create a web form in this how-to guide.
keywords: form, form template, multi-page
author: SuperOffice Product and Engineering
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
topic: forms
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: en
---

# Create a new form

Web forms make it easier to interact with customers and prospects via your website or customer centre. You have three options: create a form from scratch, create and use a custom form template, or select a free template from the **Online Template Library** in SuperOffice Marketing.

## Create new (from scratch)

1. Go to the **Forms** tab.
2. If required, click **Add folder** to [create a folder for the form][8].
3. Click the **Form** button below **Create new** on the right side of the screen.
4. In the **Edit form** dialog, enter a descriptive **Form name**.
5. [Fill in the fields](#fields) as described below. Remember to click **Apply now** regularly to save your work. The form will not be auto-saved.
6. Click **Save** when you are done.

![Set properties for new contact me form -screenshot][img15]

## Create new based on form template

1. Select the **Form templates** tab.
2. Click **All templates**.
3. Click the <i class="ph ph-list" aria-label="Task menu"></i> menu button next to the template you want to use.
4. Select **Copy to new form**. The template opens in the **Edit form** dialog.
5. [Activate and publish the form][2].

## <a id="multi-page"></a>Create multi-page form

To enhance user-friendliness and facilitate readability, consider dividing a form with many fields into multiple pages. Users can navigate through the form using **Next** and **Previous** buttons, and a progress bar can be added to indicate the remaining fields.

1. Create a form as described above.
2. Select **Fields** from the left menu (in the dialog).
3. Click the **Add** button (<i class="ph ph-plus" aria-hidden="true"></i>).
4. In the **Add element** window, select **View elements**.
5. Select **Section** and click **Add**. The window closes and a section is added to the form. You can also see the section In the form preview.
6. Click <i class="ph ph-dots-six" aria-label="Six dots"></i> at the top of the section and drag it to the desired position in the form. The fields above and below the section will be on two separate pages in the form.
7. Click **Apply now** when you are done.
8. Repeat steps 2-7 to add another section.

> [!TIP]
> You can add a progress bar to the form, so the user can see how much is left to fill in. Go to the **Style** category, click the check box next to **Progress bar color**, and select a color.

## <a id="fields"></a>Filling in form fields

[!include[Show toolbar](includes/tip-show-toolbar-open-editor.md)]

### Properties

* **Folder**: Select where to place the form or [create a new folder][8].

* **Description**: Explain the purpose of this form. This text is visible internally only.

* **Language**: Select the language used in the form.

* **Managed by**: Optional. Select a user group to limit access to this form. Only members of the selected user group can process submissions from this form and receive notifications of submissions.

* **Deactivate form automatically**: Optional. In some cases the form should be active only until a specific date or until a specific number of responses is received. Anyone trying to access an inactive form will be redirected to the page for inactive form. You can combine these options.

  * **Until**: Select a date. The form will be deactivated on this date.
  * **Max**: Enter the number of responses. The form will be deactivated after the specified number of responses are received.

* **Use Google Analytics**: Select this option to track the form and connect it to [Google Analytics][1] (if that is set up for your website). In the field below this option, you can enter the Google Analytics tracking ID for this form.

### Add fields to the form

In the **Fields** category you add the fields that should be included in the form. As you add and edit fields, the preview is automatically updated.

1. Select **Fields** from the left menu. By default, the **Contact - name** field and **OK** button are added to the new form.

2. Click the **Add** button (<i class="ph ph-plus" aria-hidden="true"></i>).

3. In the **Add element** window, select one of the following field categories:

    * **SuperOffice elements**: Fields that are linked to SuperOffice data, such as contact name, country, email address, and so on. Depending on the type of field, values from submitted forms can either replace existing values (such as country or title) or be added to the relevant SuperOffice field (such as mobile phone).

    * **Form elements**: Fields for entering text or date, fields for selecting values (lists, checkboxes and radio buttons) and file upload fields.

    * **View elements**: Sections, texts and images. Use sections to [create multi-page forms](#multi-page).

4. Select a field in the list.

5. Click **Add**. The window closes and the field is added to the form and the form preview.

6. Click <i class="ph ph-dots-six" aria-label="Six dots"></i> at the top of the field and drag it to the desired position in the form.

7. Select the field and edit the field name if relevant. The original field name will always be displayed in the upper right corner of the field.

8. You can also edit these settings (optional):

    * In the **Placeholder** field, enter a short hint on what to enter in the field.

    * Select the **Mandatory** check box if this field must be filled in. The form cannot be submitted if mandatory fields are not filled in.

    * Click **Advanced options** (<i class="ph ph-gear" aria-hidden="true"></i>) to display the **Identifier** field, where you can add an ID for the field. This will be a unique ID for this field, and will not change even if the field name/label or the language changes. This way you can ensure that links to this field are not broken after publishing the form.

    * Click the check box **Full width** if you want the selected field to be the same width as the form.

9. Edit any other [options in the field][4] as relevant.

10. Click **Apply now** when you are done.

11. Repeat steps 2-10 to add another field. You can also click **Duplicate field** (<i class="ph ph-copy" aria-hidden="true"></i>) to create a copy of a field.

### Style

Select **Style** from the left menu to define the look and feel of the form. For example, set the number of columns, placement of field names, borders, background, font color/size, and form size.

The preview on the right updates automatically when you change any settings. If you do not specify the height and width of the form, the form will automatically adapt to the screen size (desktop, tablet or mobile).

> [!TIP]
> You can add a progress bar to the form, so the user can see how much is left to fill in. Click the check box next to **Progress bar color**, and select a color. The progress bar is displayed at the bottom of the form. See also [Create multi-page forms](#multi-page).

### Activate double opt-in (optional)

Double opt-in is an extra step in the form submission process that will guarantee that people submit the correct email address.

1. Click **Enable double opt-in**.

2. In the **Message** tab, enter the text to display after the form is submitted.

3. In the **Email** tab, create the confirmation email sent to the persons submitting the form.

    1. **Subject**: Enter the subject of the confirmation email.

    2. **Sender address**: Enter the email address to display in the **From** field in the confirmation mail.

    3. **Confirmation text**: Enter the body text of the email.

    4. Select **Insert confirm link** (<i class="ph ph-arrow-square-out" aria-hidden="true"></i>) from the toolbar (click <i class="ph ph-text-a-underline" aria-label="Show toolbar"></i> to show). The confirmation link is inserted in the body text. To edit the link, click it and select **Edit link** (<i class="ph ph-pencil-simple" aria-hidden="true"></i>).

4. Click **Apply now** when you are done.

If double opt-in is activated for a form, all submissions for this form have status **Awaiting confirmation** until the email address is confirmed.

> [!NOTE]
> Remember to add the **Contact - email** field in the **Fields** category.

### Thank you page

When a person completes and submits a form, you should thank them and let them know what will happen next. It is always nice to say thank you. People really appreciate it.

Use the "Thank You" page to promote other products or events, linking to relevant parts of your website. This enhances the user experience and fosters customer loyalty.

Choose one of the following options:

* **Redirect to external website**: Enter the link to the web page with more information.
* **Show this message**: Enter the text to display.

### Page for inactive form

If a person opens a form that is inactive, you can either redirect them to another web page or display a message.

* **Redirect to external website**: Enter the link to the web page.
* **Show this message**: Enter the text to display.

### Actions

Here you can [define what happens when someone submits a form response][3].

* Notify of submissions by creating requests
* How should a form submission be processed?
* What should happen when the form is processed?

## Related content

* [Publish forms][2]

<!-- Referenced links -->
[1]: ../../tracked-links/learn/ga-tutorial.md
[2]: publish.md
[3]: define-form-actions.md
[4]: field-options.md
[8]: ../../learn/create-folder.md

<!-- Referenced images -->
[img15]: ../../../../media/loc/en/marketing/contact-me-form-properties.png
