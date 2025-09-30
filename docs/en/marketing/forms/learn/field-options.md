---
uid: help-en-form-field-options
title: Field options
description: List of fields (and their options) you can add to a SuperOffice Marketing form.
keywords: form, field, form element, view element, reCAPTCHA
author: SuperOffice Product and Engineering
date: 09.26.2025
version: 10.5
content_type: reference
category: marketing
topic: forms
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: en
---

# Field options

This is an overview of special options in some of the available fields.

## SuperOffice elements

* **Replace:** Select this option to replace an existing value in SuperOffice with the value in the form. This is relevant for country, title and mr/mrs.

* **Contact - consent**

  * **Purpose:** Select why the person must give their consent.

  * **Show link to privacy statement:** Select this option to include the link to the privacy statement.

    [Privacy settings][4] for GDPR are defined in Settings and maintenance

* **Contact - subscription:** Select the [subscriptions][3] that should be visible in the form.

* **Company name: Use existing company if found**.

  * If this option is ON: If a person submits a form where the company name matches a company in SuperOffice, the person is automatically added to the company as a new contact.

  * If this option is OFF: Both the person and company are added to SuperOffice.

  > [!NOTE]
  > Normally this setting is OFF to avoid "random" people being added to companies they do not belong to.

## Form elements

* **Text field:** A simple 1-row text field.

* **Text area:** A large multi-row text field.

* **Radio buttons:** A selection field where you can select one of multiple values.

  * **Vertical:** Display the values horizontally or vertically.

  * **Data:** Here you enter the values for each radio button. Enter a value in this field and click **+**. Repeat to add additional values.

* **Checkbox:** A selection field where you can select multiple values.

  * **Vertical:** Display the values horizontally or vertically.

  * **Data:** Here you enter the values for each checkbox. Enter a value in this field and click **+**. Repeat to add additional values.

* **Drop-down:** A selection field where you can select a value from a list.

  * **Data:** Here you enter the list values. Enter a value in this field and click **+**. Repeat to add additional values.

* **Hidden:** A field that is not visible in the published form. In the **Default value** field you can enter a code, a project name/number or other information that should be associated with this form.

* **Date:** A date field.

* **Upload file:** A field for uploading files.

  * **Allow multiple files:** Select this option to allow multiple files to be uploaded.

  * **Maximum file size (kb):** Enter a file size in kilobytes to prevent large file from being uploaded. Leave this field empty to allow all file sizes.

  * **Allowed file types:** Enter the file types that can be uploaded. Use the format *jpg,gif,png,bmp* (comma-separated, no space). Leave this field empty to allow all file types.

* **Rating:** A field where customers can rate for instance the service they received, using various rating types (stars, dice, 1-10 scale, and similar).

* **Google reCAPTCHA:** The [reCAPTCHA feature][1] ("I'm not a robot" check-box) is a free Google service that will ensure that only real users can send in web forms. This prevents spam and automated bots from sabotaging your data collection.

## View elements

* **Text block:** Enter a text to display in the form, such as a short introduction or detailed description.

    [!include[Show toolbar](includes/tip-show-toolbar-open-editor.md)]

* **Image:** Add an image to the form. Click the link to select an image or drag and drop an image to the **Image** field. Use the **Position** radio buttons to place the image on the form.

* **Section:** Add a section between the fields to [create a multi-page form][2]. Useful if your form contains many fields and you want to avoid scrolling.

<!-- Referenced links -->
[1]: recaptcha.md
[2]: create.md#multi-page
[3]: ../../recipients/learn/manage-email-subscriptions.md
[4]: ../../../security/privacy/admin/add-purpose.md

<!-- Referenced images -->
