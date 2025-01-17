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

Fields on quote line that are not enabled will have blank values for their tags – even if you add data to the database manually. To use all tags, go to the quote settings in Settings and maintenance and enable all fields.

To insert fields into your template, you can use one of the following methods:

### Method 1: Use the Field dialog

1. Place the cursor where you want to insert the field.

1. Click **Insert** > **Quick Parts** > **Field**.

    ![Quick Parts -screenshot][img1]

1. In the **Field names** list, type "merge" to highlight **MergeField**.

1. In **Field properties**, type your [field name][3](without «»):

    ![Field properties in Microsoft Word -screenshot][img2]

1. Click **OK** and the variable will be inserted in your document:

    ![Insert MERGEFIELD -screenshot][img3]

### Method 2: Copy and paste existing fields (quickest)

1. **Copy** an existing field from the template. Ensure you copy the entire field, including the «» brackets.

2. **Paste** the field into your template where needed.

3. Right-click the pasted field and select **Edit fields**.

4. In the **Field name** box under **Field properties**, enter or paste the new field name (without «»).

5. Click **OK**.

## Calculations

You can perform calculations with the merge fields.

### Net price per unit

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
* [Quote templates and merge fields][4]
* [Merge field reference][3]
* [Template variable reference][6]

<!-- Referenced links -->
[1]: template-variables.md
[4]: quote-templates.md
[2]: ../admin/link-template.md
[3]: ../merge-fields/index.md
[6]: ../variables/for-quote-line.md
[9]: https://docs.aspose.com/words/net/fields-overview/

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/document/word-insert-quick-parts.png
[img2]: ../../../../media/loc/en/document/word-field-dialog.png
[img3]: ../../../../media/loc/en/document/6764-11541.jpg
