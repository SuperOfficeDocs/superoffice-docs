---
uid: help-en-form-prefilled
title: Using pre-filled fields in forms
description: Using pre-filled fields in forms
keywords: form, pre-fill, pre-filled field, form identifier, field ID
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

# Using pre-filled fields in forms

To save your customers the time and trouble of filling in their name, email address, phone number, and so on, in forms, you can add field identifiers and template variables to the form links/URLs. When the customer opens a form, existing customer data is filled in using SuperOffice data.

A field identifier is a unique ID for a specific field. It will not change even if the field name/label or the language changes. This way you can ensure that links to this field are not broken after publishing the form.

## Steps

1. [Create a new form][1].

2. For each field you want to be pre-filled: Click **Advanced options** (<i class="ph ph-gear" aria-hidden="true"></i>) to display the **Identifier** field, where you can add an ID for the field.

3. [Publish forms][2].

4. Select **Show with pre-filled fields** to add field identifiers to the link/JavaScript. It should look something like this:

    ```text
    ...formId=F-FH2K4Vru&field-name-1=&field-mail=
    ```

    If no field identifiers are added, you have probably not added these IDs to the fields in the form.

5. Copy the link or JavaScript to a text editor or similar.

6. Enter the relevant [template variables][3] between two square brackets AFTER the equal sign:

    ```text
    ...formId=F-FH2K4Vru&field-name-1=[[customer.name]]&field-mail=[[customer.email]]
    ```

7. Copy the complete link or JavaScript and publish it.

<!-- Referenced links -->
[1]: create.md
[2]: publish.md
[3]: ../../../knowledge-base/learn/reply-templates/template-variables.md

<!-- Referenced images -->
