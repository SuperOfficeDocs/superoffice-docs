---
uid: help-en-form-prefilled
title: form prefilled
description: form prefilled
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Forms
so.topic: help
language: en
---

# Using pre-filled fields in forms

To save your customers the time and trouble of filling in their name, e-mail address, phone number etc. in forms, you can do this work for them. When the customer opens a form, existing customer data will be filled in using SuperOffice data.

This is done by adding field identifiers and template variables to the form links/URLs.

In order to do this:

1. [Create a new form](form_create.md).
2. For each field you want to be pre-filled: Click **Advanced options** (![icon](../media/btn_Field_AdvancedOptions.png)) to display the **Identifier** field, where you can add an ID for the field. This will be a unique ID for this field, and will not change even if the field name/label or the language changes. This way you can ensure that links to this field are not broken after publishing the form.
3. [Publish forms](form_publish.md).
4. Select **Show with pre-filled fields** to add field identifiers to the link/JavaScript.  
    It should look something like this:  
    ...formId=F-FH2K4Vru&field\_name\_1=&field\_mail=
5. Copy the link or JavaScript to a text editor or similar.
6. Enter the relevant [template variables](../../Service/topics/Template_variables.md) between two square brackets (\[\[ \]\] ) AFTER the equal sign:  
    ...formId=F-FH2K4Vru&field\_name\_1=\[\[customer.name\]\]&field\_mail=\[\[customer.email\]\]
7. Copy the complete link or JavaScript and publish it.
