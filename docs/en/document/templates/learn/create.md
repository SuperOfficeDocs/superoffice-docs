---
uid: help-en-document-template-create
title: Create a template document
description: How to create a template document
keywords: document template, document, template
author: Bergfrid Dias, Terje Nøstdahl, samuelholmstroem
date: 07.31.2024
version: 10
topic: howto
language: en
---

# Create a template document

To make sure everyone in your company uses the same documents, you can create and add your own document templates for different file types. Use the template variables available to personalize and automate the input of customer information to your documents.

You create a template as a document in an application which is linked to SuperOffice CRM, for example, a word-processing program. If you create the template in Word, you must save it as a normal document (with the file type **DOC** or **DOCX**), and not as a template (with the file type **DOT** or **DOTX**).

You can also create templates in HTML format, and use the SuperOffice HTML editor to edit the template.

> [!TIP]
> To add new templates, you can easily copy an existing document template file and edit this to fit your needs.

## Steps

1. Start the required application.
2. Create a new document.
3. Insert the [template variables][1] you want to use in the template, for example, variables for name, address and telephone number.
4. Save the template document somewhere where you can find it easily again.

After you define a template and save it in the template folder, an administrator must [link the template to SuperOffice CRM][2] to create documents from it.

## Add merge field to quote template

To use all tags, first go to the Quote Settings in Admin and enable all fields. Fields on Quote Line that are not enabled will have blank values for their tags – even if you add data to the database manually.

1. Click **Insert** > **Quick Parts** > **Field**.

    ![Quick Parts -screenshot][img1]

2. In **Field names**, find MergeField. In **Field properties**, type your [field name][3]:

    ![Field properties -screenshot][img2]

3. Click **OK** and the variable will be inserted in your document:

    ![Insert MERGEFIELD -screenshot][img3]

### Calculations

You can perform calculations with the merge fields.

#### Net price per unit

To show the price per unit after discounts, you can add a merge field like this:

```text
{= {MERGEFIELD line/totalPrice} / {MERGEFIELD line/quantity}}
```

**Steps:**

1. Press Ctrl + F9 to add a new merge field. You will see two curly brackets { }.

1. Inside the brackets:

    1. Add "= " and press Ctrl + F9 again.
    1. Add "MERGEFIELD line/totalPrice" in a new set of brackets.
    1. Type "/" and then press Ctrl + F9.
    1. Add "MERGEFIELD line/quantity" in the last set of brackets.

1. Now you should have a field that looks like this: {= {MERGEFIELD line/totalPrice} / {MERGEFIELD line/quantity}}

## Related content

* [How to work with fields in Aspose Words][9]

<!-- Referenced links -->
[1]: template-variables.md
[2]: ../admin/link-template.md
[3]: ../merge-fields/index.md
[9]: https://docs.aspose.com/words/net/fields-overview/

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/document/6762-11545.jpg
[img2]: ../../../../media/loc/en/document/6763-11543.jpg
[img3]: ../../../../media/loc/en/document/6764-11541.jpg
