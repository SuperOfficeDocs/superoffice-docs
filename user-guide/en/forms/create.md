---
uid: help-en-form-create
title: Create a new form
description: Create a new form
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Forms
so.topic: howto
language: en
---

# Create a new form

To create a new form:

1. Go to the **Forms** tab.
2. If required, click **Add folder** to [create a folder for the form][19].

3. Select **Form** under **Create new** on the right side of the screen. The **Edit form** screen displays.
4. Enter a descriptive name for the template in the **Form name** field.
5. Fill in the fields as described below.
6. Remember to click **Apply now** regularly to save your work. The form will not be auto-saved.
7. Click **Save** when you are done.

## Do you want to create a new form based on a form template?

1. Select the **Form templates** tab.
2. Click **All templates**.
3. Click the ![icon][img1] menu button next to the template you want to use.
4. Select **Copy to new form**. The template opens in the **Edit form** dialog.

To activate and publish the form, see [Publish forms][2].

## <a id="multi-page" />Create multi-page forms

If you are creating a form with many fields, it might be useful to split the form into multiple pages. This will make the form more user-friendly and easier to read. The user can navigate using **Next** and **Previous** buttons, and you can also add a progress bar to indicate how much is left to fill in.

1. Create a form as described above.
2. Go to the **Fields** category.
3. Click the **Add** button (![icon][img2]). The **Add element** window opens.
4. Select **View elements**.
5. Select **Section** and click **Add**. The window closes and a section is added to the form. You can also see the section In the form preview.
6. Click ![icon][img3] at the top of the section and drag it to the desired position in the form. The fields above and below the section will be on two separate pages in the form.
7. Click **Apply now** when you are done.
8. Repeat steps 2-7 to add another section.

> [!TIP]
> You can add a progress bar to the form, so the user can see how much is left to fill in. Go to the **Style** category, click the check box next to **Progress bar colour**, and select a colour.

## Filling in form fields

Click the headings to learn how to fill in the fields in the various categories:

### Properties

Fill in the following information in the **Properties** category:

* **Folder**: Select a folder in which to place the form or [create a new][19]

* **Description**: Enter a description of the purpose of this form. This text will only be visible internally.

* **Language**: Select the language used in the form.

* **Managed by**: Optional. Select a user group to limit access to this form. Only members of the selected user group can process submissions from this form and receive notifications of submissions.

* **Deactivate form automatically**: Optional. In some cases the form should only be active until a specific date or until a specific number of responses have been received. Anyone trying to access an inactive form will be redirected to the page for inactive form. You can combine these options.

  * **Until**: Select a date. The form will be deactivated on this date.
  * **Max**: Enter the number of responses. The form will be deactivated after the specified number of responses have been received.

* **Use Google Analytics**: Select this option to track the form and connect it to [Google Analytics][1] (if that is set up for your web site). In the field below this option, you can enter the Google Analytics tracking ID for this form.

### Fields

In the **Fields** category you add the fields that should be included in the form. As you add and edit fields, the preview on the right-hand side is automatically updated.

To add fields to the form:

1. Go to the **Fields** category. By default, the **Contact - name** field and **OK** button have been added to the new form.

2. Click the **Add** button ![icon][img2]. The **Add element** window opens.

3. Select one of the following field categories:
    * **SuperOffice elements**: Fields that are linked to SuperOffice data, such as contact name, country, e-mail address etc. Depending on the type of field, values from submitted forms can either replace existing values (such as country or title) or be added to the relevant SuperOffice field (such as mobile phone).
    * **Form elements**: Fields for entering text or date, fields for selecting values (lists, checkboxes and radio buttons) and file upload fields.
    * **View elements**: Sections, texts and images. Use sections to [create multi-page forms](#multi-page).

4. Select a field in the list.

5. Click **Add**. The window closes and the field is added to the form and the form preview.

6. Click ![icon][img3] at the top of the field and drag it to the desired position in the form.

7. Select the field and edit the field name if relevant. The original field name will always be displayed in the top right corner of the field.

8. You can also edit these settings (optional):

    * In the **Placeholder** field, enter a short hint on what to enter in the field.
    * Select the **Mandatory** check box if this field must be filled in. The form cannot be submitted if mandatory fields are not filled in.
    * Click **Advanced options** ![icon][img5] to display the **Identifier** field, where you can add an ID for the field. This will be a unique ID for this field, and will not change even if the field name/label or the language changes. This way you can ensure that links to this field are not broken after publishing the form.
    * Click the check box **Full width** if you want the selected field to be the same width as the form.

9. Edit any other [options in the field][4] as relevant.

10. Click **Apply now** when you are done.

11. Repeat steps 2-10 to add another field. You can also click **Duplicate field** ![icon][img6] to create a copy of a field.

### Style

In the **Style** category you can define the look and feel of the form. You can among other things set the number of columns, placement of field names, borders, background, font colour/size and form size.

The preview on the right is updated automatically when you change any settings. If you do not specify the height and width of the form, the form will automatically adapt to the screen size (desktop, tablet or mobile).

> [!TIP]
> You can add a progress bar to the form, so the user can see how much is left to fill in. Click the check box next to **Progress bar colour**, and select a colour. The progress bar is displayed at the bottom of the form. See also [Create multi-page forms](#multi-page).

### Double opt-in

This option adds an extra layer of security to the form. If you activate this option, the person submitting the form must also confirm their e-mail address. This is done by sending them an e-mail when they submit the form. The e-mail contains a link they must click to confirm that the e-mail address is correct.

> [!NOTE]
> The link is valid for 30 minutes by default.

To activate double opt-in:

1. Click **Enable double opt-in**.
2. In the **Message** tab, enter the text to display after the form has been submitted. Click **Show/hide toolbar** ![icon][img7] to display formatting options for the text.
3. In the **E-mail** tab, create the confirmation e-mail sent to the persons submitting the form.
    1. **Subject**: Enter the subject of the confirmation e-mail.
    2. **Sender address**: Enter the e-mail address to display in the **From** field in the confirmation mail.
    3. **Confirmation text**: Enter the body text of the e-mail. Click **Show/hide toolbar** ![icon][img7] to display formatting options for the text. Click **Open text editor in dialog** ![icon][img8] to edit the text in a larger editor.
    4. Click **Show/hide toolbar** ![icon][img7] and then click **Insert confirm link** ![icon][img9]. The confirmation link is inserted in the body text. To edit the link, click it and select **Edit link** ![icon][img10].
4. Click **Apply now** when you are done.

If double opt-in has been activated for a form, all [submissions for this form][5] will have status **Awaiting confirmation** until the e-mail address has been confirmed.

> [!NOTE]
> Remember to add the **Contact - e-mail** field in the **Fields** category.

### Thank you page

When a person has completed and submitted a form, you should thank them and let them know what will happen next. You can do this by either redirecting them to another web page with more information or displaying a message.

* **Redirect to external website**: Enter the link to the web page.
* **Show this message**: Enter the text to display. Click **Show/hide toolbar** ![icon][img7] to display formatting options for the text. Click **Open text editor in dialog** ![icon][img8] to edit the text in a larger editor.

### Page for inactive form

If a person opens a form that is inactive, you can either redirect them to another web page or display a message.

* **Redirect to external website**: Enter the link to the web page.
* **Show this message**: Enter the text to display. Click **Show/hide toolbar** ![icon][img7] to display formatting options for the text. Click **Open text editor in dialog** ![icon][img8] to edit the text in a larger editor.

### Actions

Here you can define how a submitted form should be processed. Fill in the following fields:

**Notify of submissions by creating requests**: Select this option to create a request for every form that is submitted. Enter a title and select the category and priority for the request. Submitted forms will be available under **Requests** in SuperOffice Service and in the **Request** section tab in the **Company** and **Contact** screens in SuperOffice CRM.

**How should a form submission be processed?** Here you can define if the submitted forms should be processed automatically or not.

* **Automatically process all submissions. Create new contact if no match found**: All form submissions are processed automatically. There will no notifications of submitted forms.
* **Manually if submitter is unknown. Automatically if submitter is known**: If the e-mail address submitted in the form matches an e-mail address in SuperOffice, the form submission is processed automatically. Otherwise, it must be processed manually. You will receive a notification (![icon][img11]). See [Process form submissions][6].
* **Manually for all submissions**: You will receive a notification (![icon][img11]) for each submitted form. To process form submissions manually, see [Process form submissions][6].

**What should happen when the form is processed?** Here you can select actions to perform when a form is processed (automatically or manually):

* **Add contact to selection**: If you have selected automatic processing above, you should add a selection here to keep track of contacts added via this form. This will also make it easier to remove any irrelevant contacts (and companies).
* **Add contact to project**: Select a project. Contacts who submit this form will be added to this project.
* **Add interest to contact**: Select an interest. This interest will be added to contacts who submit this form.
* **E-mail response**: Select a form response to send to contacts when their form is processed. [How to create a form response][7].
* **Create request**: If you have added a request field in the **Fields** category, you must also select a default category and priority for the requests that are create from this form. Submitted forms will be available under **Requests** in SuperOffice Service and in the **Request** section tab in the **Company** and **Contact** screens in SuperOffice CRM.
* **Execute CRMScript**: Select a script or macro to run when a form submission is processed. See [CRMScript][8].
* **Default category** / **Default business**: Select a default category and business for all contacts or companies that are added to SuperOffice based on submitted forms. With this option, you can group the form submissions and new contacts/campanies to one specific category and/or business.
    For example, if you have a form for prospects, you select prospects as your category. You can then easily create selections based on this category and/or business.

## What would you like to do now?

* [Publish forms][2]

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/Technical/Blog/simple-google-analytics-email-tracking/
[2]: publish.md
[4]: field-options.md
[5]: submissions/index.md
[6]: submissions/process.md
[7]: ../marketing/mailing/create/tutorial-form-mailing.yml
[8]: ../automation/index.md
[19]: ../marketing/create-folder.md

<!-- Referenced images -->
[img1]: ../../media/icons/btn-menu.png
[img2]: ../../media/icons/marketing-and-forms/btn-field-add.png
[img3]: ../../media/icons/marketing-and-forms/btn-field-move.png
[img5]: ../../../common/icons/cog-wheel.png
[img6]: ../../../common/icons/duplicate-icon.png
[img7]: ../../media/icons/marketing-and-forms/btn-editor-toolbar-showhide.png
[img8]: ../../../common/icons/pop-out-icon.png
[img9]: ../../../common/icons/new-window-icon.png
[img10]: ../../../common/icons/edit-black.png
[img11]: ../../media/icons/marketing-and-forms/btn-form-notification.png
